using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Logger
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine($"ERR: {errorMessage}");
        }

        public void LogInfo(string infoMessage)
        {
            Console.WriteLine($"NFO: {infoMessage}");
        }
    }
}
