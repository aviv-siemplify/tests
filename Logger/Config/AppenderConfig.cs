
using Logger.Model;

namespace Logger.Config
{
    public class AppenderConfig
    {
        public AppenderType Type { get; set; }
        public string Color { get; set; }
        public string Path { get; set; }
        public int? MaxFileSize { get; set; }
        public string Host { get; set; }
    }
}
