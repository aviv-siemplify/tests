using System;
using System.IO;
using Logger.Config;
using Logger.Model;

namespace Logger.Appender
{
    public sealed class RollingFileAppender : BaseFileAppender
    {
        private readonly AppenderConfig _config;

        public RollingFileAppender(AppenderConfig config) : base(config)
        {
            _config = config;
        }

        public override void AppendToFileWhenFileSizeIsExceeded(string filePath, CustomError error)
        {
            var newFileName = SetCurrentErrorFilePath();
            CreateOrOverwriteFile(newFileName, error);
        }

        private string SetCurrentErrorFilePath()
        {
            var fileName = Path.GetFileNameWithoutExtension(_config.Path);
            var newFileName =  $"{fileName}-{DateTime.Now:yy-MM-dd-hh-mm-ss}{Path.GetExtension(_config.Path)}";
            _config.Path = newFileName;
            return newFileName;
        }
    }
}
