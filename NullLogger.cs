using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingLibrary
{
    public class NullLogger : ILogger
    {
        public void Error(string message)
        {
        }

        public void Info(string message)
        {
        }

        public void Warning(string message)
        {
        }
    }
}
