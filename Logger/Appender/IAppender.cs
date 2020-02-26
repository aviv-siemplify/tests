using Logger.Model;

namespace Logger.Appender
{
    public interface IAppender
    {
        void Append(CustomError error);
    }
}