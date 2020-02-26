
using System.Collections.Generic;
using Logger.Model;

namespace Logger.Config
{
    public class LoggerConfig
    {
        public SeverityType Severity { get; set; }
        public IList<AppenderConfig> Appenders { get; set; }
    }
}
