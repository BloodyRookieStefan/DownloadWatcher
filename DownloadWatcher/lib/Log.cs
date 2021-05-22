using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWatcher
{
    class Log
    {
        public static string FolderPath = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Logs");
        private static string FilePath = null;

        public static void Write(string text)
        {
            if(FilePath == null)
            {
                CreateFile();
            }

            File.AppendAllText(FilePath, DateTime.Now.ToString() +": " +text + Environment.NewLine);
        }

        public static void CreateLogFolder()
        {
            if(!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
        }

        private static void CreateFile()
        {
            string fileName = String.Format("Log_{0}_{1}_{2}_{3}_{4}_{5}.log", DateTime.Now.Day.ToString(),
                                                                              DateTime.Now.Month.ToString(),
                                                                              DateTime.Now.Year.ToString(),
                                                                              DateTime.Now.Hour.ToString(),
                                                                              DateTime.Now.Minute.ToString(),
                                                                              DateTime.Now.Second.ToString());
            FilePath = Path.Combine(FolderPath, fileName);
        }
    }
}
