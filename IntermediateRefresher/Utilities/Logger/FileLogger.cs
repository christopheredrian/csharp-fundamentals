using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Utilities.Logger
{
    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        private void Log(string message, string type)
        {

            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{type}: {message}");
            }
        }

        public void LogError(string errorMessage)
        {
            Log(errorMessage, "ERR");
        }

        public void LogInfo(string infoMessage)
        {
            Log(infoMessage, "NFO");
        }
    }
}
