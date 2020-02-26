namespace Logger
{
    public interface ILoggerFactory
    {
        ILogger Resolve();
    }
}