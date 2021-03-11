using System.Diagnostics;

namespace LoggingLibrary
{
    public static class Log
    {
        public static void Info(string message)
        {
            Trace.TraceInformation(message);
        }

        public static void Warning(string message)
        {
            Trace.TraceWarning(message);
        }

        public static void Error(string message)
        {
            Trace.TraceError(message);
        }
    }
}
