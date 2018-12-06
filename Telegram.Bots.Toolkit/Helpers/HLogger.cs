namespace Telegram.Bots.Toolkit.Helpers
{
    using NLog;
    using NLog.Config;
    using NLog.Targets;

    /// <summary>
    /// The hn log.
    /// </summary>
    internal class HLogger
    {
        /// <summary>
        /// The init.
        /// </summary>
        public HLogger()
        {
            var config = new LoggingConfiguration();

            var logfile = new FileTarget("logfile") { FileName = "logs.txt" };
            var logconsole = new ConsoleTarget("logconsole");

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            LogManager.Configuration = config;
        }
    }
}