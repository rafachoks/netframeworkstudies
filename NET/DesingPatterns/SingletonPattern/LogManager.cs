using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LogManager
    {
        private static LogManager _instance;
        private FileStream _fileStream;
        private StreamWriter _streamWriter;
        public static LogManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LogManager();
                return _instance;
            }
        }

        private LogManager() //constructor as private
        {
            _fileStream = File.OpenWrite(getExecutionFolder() + "\\ApplicationLog");
        }
        
        public void WriteLog(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Date: " + (DateTime.Now.ToShortDateString()));
            formattedMessage.AppendLine("Message: " + message);

            _streamWriter.WriteLine(formattedMessage.ToString());
            _streamWriter.Flush();
        }

        private string getExecutionFolder()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
    }
}
