
using Logger.Config;

namespace Logger.Appender
{
    public interface IAppenderFactory
    {
        IAppender Resolve(AppenderConfig appenderConfig);
    }
}
