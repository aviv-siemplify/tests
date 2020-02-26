using Logger.Config;
using Logger.Model;

namespace Logger.Appender
{
    public sealed class FileAppender : BaseFileAppender
    {
        public FileAppender(AppenderConfig config) : base(config)
        {
        }

        public override void AppendToFileWhenFileSizeIsExceeded(string filePath, CustomError error)
        {
            CreateOrOverwriteFile(filePath, error);
        }
    }
}
