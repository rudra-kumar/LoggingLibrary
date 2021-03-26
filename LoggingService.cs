using System.Diagnostics;

namespace LoggingLibrary
{
    public static class LoggingService
    {
        private static ILogger _logger = new NullLogger();

        public static ILogger Logger => _logger;

        public static void Provide(ILogger logger)
        {
            if (logger == null)
                _logger = new NullLogger();
            else
                _logger = logger;
        }
    }
}
