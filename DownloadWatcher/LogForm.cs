using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWatcher
{
    public partial class LogForm : Form
    {
        private readonly string TableName = "Logs";
        private readonly string FolderPath;
        private readonly DataSet LogSet;

        public LogForm(string folder)
        {
            InitializeComponent();
            FolderPath = folder;
            LogSet = new DataSet("LogOverview");
            BuildLogSet();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            // Search for Logs
            string[] files = Directory.GetFiles(FolderPath, "*.log");

            DataTable dt = LogSet.Tables[TableName];

            foreach(var file in files)
            {
                string filePath = Path.GetDirectoryName(file);
                string fileName = Path.GetFileName(file);
                DateTime creationTime = File.GetCreationTime(file);
                dt.Rows.Add(filePath, fileName, creationTime);
            }

            dataGridView.DataSource = LogSet;
            dataGridView.DataMember = TableName;

            // AutoFit
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                // Last row fill to end
                if (i == dataGridView.Columns.Count - 1)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else    // Fit content
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogSet.Dispose();
        }

        private void BuildLogSet()
        {
            DataTable dt = new DataTable(TableName);
            dt.Columns.Add("Path");
            dt.Columns.Add("File name");
            dt.Columns.Add("Creation time");

            LogSet.Tables.Add(dt);
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header double click returns -1
            if(e.RowIndex < 0)
            {
                return;
            }

            // Get file to open
            string fileToOpen = Path.Combine(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

            if (File.Exists(fileToOpen))
            {
                Process.Start(fileToOpen);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(String.Format("Delete {0} selected logs?", dataGridView.SelectedRows.Count), "Delete logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Cancel if result was no
            if(res == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                // Convert to dataRow
                DataRow dataRow = (row.DataBoundItem as DataRowView).Row;
                // Get filename on disk
                string fileToDelete = Path.Combine(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString());
                // Remove from DataSet
                LogSet.Tables[TableName].Rows.Remove(dataRow);
                // Delete from disk
                if (File.Exists(fileToDelete))
                {
                    try
                    {
                        File.Delete(fileToDelete);
                    }
                    catch(Exception exp)
                    {
                        MessageBox.Show("Could not delete file:\n" +exp.Message, "File cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
