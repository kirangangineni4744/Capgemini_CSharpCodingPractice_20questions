using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    class TimestampLogger : ILogger
    {
        private ILogger logger;

        public TimestampLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string message)
        {
            logger.Log($"[{DateTime.Now}] {message}");
        }
    }

    class ErrorLogger : ILogger
    {
        private ILogger logger;

        public ErrorLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string message)
        {
            logger.Log($"[ERROR] {message}");
        }
    }
}
