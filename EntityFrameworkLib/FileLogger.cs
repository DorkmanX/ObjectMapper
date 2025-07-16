using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace EntityFrameworkLib
{
    public static class FileLogger
    {
        private static readonly string logPath = "error_log.txt";

        public static void LogToFile(string message, Exception exception)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR] {message}";
            if (exception != null)
            {
                logMessage += Environment.NewLine + exception.ToString();
            }
            File.AppendAllText(logPath, logMessage + Environment.NewLine);
        }

        public static void LogError(string message)
        {
            LogToFile(message, null);
        }
    }
}