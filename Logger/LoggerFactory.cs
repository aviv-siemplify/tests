using System.Collections.Generic;
using Logger.Appender;
using Logger.Config;
using Logger.Helper;

namespace Logger
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly IJsonConverter _jsonConverter;
        private readonly IAppenderFactory _appenderFactory;

        public LoggerFactory(IJsonConverter jsonConverter, IAppenderFactory appenderFactory)
        {
            _jsonConverter = jsonConverter;
            _appenderFactory = appenderFactory;
        }

        public ILogger Resolve()
        {
            var config = _jsonConverter.Deserialize<LoggerConfig>();
            var appenders = new List<IAppender>();

            foreach (var configAppender in config.Appenders)
            {
                appenders.Add(_appenderFactory.Resolve(configAppender));
            }

            return new Logger(config.Severity, appenders);
        }
    }
}
