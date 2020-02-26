using System.IO;
using Logger.Config;
using Logger.Model;

namespace Logger.Appender
{
    public abstract class BaseFileAppender : IAppender
    {
        private readonly AppenderConfig _config;

        protected BaseFileAppender(AppenderConfig config)
        {
            _config = config;
        }

        public abstract void AppendToFileWhenFileSizeIsExceeded(string filePath, CustomError error);

        public void Append(CustomError error)
        {
            var logFileInfo = new FileInfo(_config.Path);
            if (!logFileInfo.Exists)
            {
                CreateOrOverwriteFile(_config.Path, error);
                return;
            }

            if (logFileInfo.Length < _config.MaxFileSize)
            {
                using (StreamWriter streamWriter = File.AppendText(_config.Path))
                {
                    streamWriter.WriteLine(error.ToString());
                }
            }
            else
            {
                AppendToFileWhenFileSizeIsExceeded(_config.Path, error);
            }
        }

        protected void CreateOrOverwriteFile(string filePath, CustomError error)
        {
            using (StreamWriter streamWriter = File.CreateText(filePath))
            {
                streamWriter.WriteLine(error.ToString());
            }
        }
    }
}
