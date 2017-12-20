using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Util
{
    public class Logger
    {
        private static string _log_file_path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Log.txt";
        private object locker = new object();

        private static Logger _instance;
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }

            private set { _instance = value; }
        }

        public static string Path
        {
            get { return _log_file_path; }
        }

        private Logger()
        {
            if (!File.Exists(_log_file_path))
                File.Create(_log_file_path);
        }
        /// <summary>
        /// Записываем сообщение об ошибке в лог
        /// </summary>
        /// <param name="ex"></param>
        public void WriteToLog(Exception ex) {
            WriteToLog(ex.Message);
        }

        public void WriteToLog(string message)
        {
            using (StreamWriter file = new StreamWriter(_log_file_path, true))
            {
                lock (locker)
                    file.WriteLine(DateTime.Now + " " + message + "\n");
            }
        }
    }
}
