
using Logger.Config;
using Logger.Model;

namespace Logger.Appender
{
    /// <summary>
    /// TODO: move this to Castle.Windsor
    /// </summary>
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender Resolve(AppenderConfig appenderConfig)
        {
            switch (appenderConfig.Type)
            {
                case AppenderType.Console:
                    return new ConsoleAppender(appenderConfig.Color);
                case AppenderType.File:
                    return new FileAppender(appenderConfig);
                case AppenderType.RollingFile:
                    return new RollingFileAppender(appenderConfig);
                case AppenderType.Tcp:
                    return new TcpAppender();
                default:
                    return  new ConsoleAppender(appenderConfig.Color);
            }
        }
    }
}
