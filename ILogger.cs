using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingLibrary
{
    public interface ILogger
    {
        void Info(string message);
        void Warning(string message);
        void Error(string message);
    }
}
