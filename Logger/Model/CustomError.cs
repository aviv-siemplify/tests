using System;

namespace Logger.Model
{
    public class CustomError
    {
        public DateTimeOffset Time { get; set; }
        public SeverityType Severity { get; set; }
        public string Message { get; set; }

        public CustomError(SeverityType severity, string message)
        {
            Time = DateTimeOffset.Now;
            Severity = severity;
            Message = message;
        }

        public override string ToString()
        {
            return $"{Time} - {Severity.ToString().ToUpper()} - {Message}";
        }
    }
}
