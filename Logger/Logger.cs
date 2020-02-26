using System.Collections.Generic;
using Logger.Appender;
using Logger.Model;

namespace Logger
{
    public sealed class Logger : ILogger
    {
        private readonly SeverityType _severity;
        private readonly IList<IAppender> _appenders;

        public Logger(SeverityType severity, IList<IAppender> appenders)
        {
            _severity = severity;
            _appenders = appenders;
        }

        public void LogTrace(string message)
        {
            Append(SeverityType.Trace, message);
        }

        public void LogDebug(string message)
        {
            Append(SeverityType.Debug, message);
        }

        public void LogInfo(string message)
        {
            Append(SeverityType.Info, message);
        }

        public void LogWarn(string message)
        {
            Append(SeverityType.Warn, message);
        }

        public void LogError(string message)
        {
            Append(SeverityType.Error, message);
        }

        public void LogFatal(string message)
        {
            Append(SeverityType.Fatal, message);
        }

        private void Append(SeverityType severity, string message)
        {
            if (severity < _severity)
            {
                return;
            }

            foreach (var appender in _appenders)
            {
                appender.Append(new CustomError(severity, message));
            }
        }
    }
}
