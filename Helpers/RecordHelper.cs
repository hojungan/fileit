using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIT.Helpers
{
    public static class RecordHelper
    {
        private static readonly string _LogFile = $"C:\\FileIT\\Logs\\{DateTime.Now.ToString("yyyy-MM-dd")}.log";
        private static readonly string _AppLogFile = $"C:\\FileIT\\AppLogs\\{DateTime.Now.ToString("yyyy-MM-dd")}.log";

        private static void CreateAppLogFile()
        {
            if (!File.Exists(_AppLogFile))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_AppLogFile));
            }
        }

        public static string LogDirectory()
        {
            return Path.GetDirectoryName(_LogFile);
        }

        /// <summary>
        /// Creates log folder and log file if the file does not exist
        /// </summary>
        private static void CreateLogFile()
        {
            if (!File.Exists(_LogFile))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_LogFile)); // If the directory exists, this function does nothing
                File.AppendAllText(_LogFile, $"Action^Result^TimeStamp^SourceFileName^Destination^Message{Environment.NewLine}");
            }
        }

        /// <summary>
        /// Logs result and errors during copy, move, and delete of file
        /// </summary>
        /// <param name="actiontype">Copy, Move, Delete</param>
        /// <param name="sourcefile">Provide absolute path of the file with the filename</param>
        /// <param name="destination">Provide absolute path of the destination folder</param>
        /// <param name="message">Do not include newline along with the message</param>
        public static void LogResult(string actiontype, string result, string sourcefile, string destination, string message)
        {
            // Create file if today's log file does not exist
            CreateLogFile();

            string formattedMsg = string.Empty;

            // Append message to log file
            if(actiontype == ActionTypes.DELETE)
            {
                formattedMsg = Message(actiontype, result, sourcefile, "NULL", message);
            }
            else { 
                formattedMsg = Message(actiontype, result, sourcefile, destination, message); 
            }

            try
            {
                WriteToLog(formattedMsg, _LogFile);
            }
            catch (Exception ex)
            {
                formattedMsg = Message(actiontype, result, sourcefile, destination, ex.Message);
                WriteToLog(formattedMsg, _AppLogFile);
            }
        }

        /// <summary>
        /// Returns formatted log string
        /// </summary>
        /// <param name="sourcefile"></param>
        /// <param name="destnation"></param>
        /// <param name="message">Do not include newline</param>
        /// <returns>Formatted log string</returns>
        private static string Message(string action, string result, string sourcefile, string destnation, string message)
        {
            var today = DateTime.Now;
            return $"[{action}]^[{result}]^[{today.Hour}:{today.Minute}:{today.Second}:{today.Millisecond}]^{sourcefile}^{destnation}^{message}{Environment.NewLine}";
        }

        private static void WriteToLog(string message, string logFile)
        {
            File.AppendAllText(logFile, message);
        }
    }
}
