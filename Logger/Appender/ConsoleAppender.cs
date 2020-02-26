using System;
using Logger.Model;

namespace Logger.Appender
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(string color)
        {
            if (!Enum.TryParse(color, out ConsoleColor consoleColor))
            {
                consoleColor = ConsoleColor.White;
            }
            Console.ForegroundColor = consoleColor;
        }

        public void Append(CustomError error)
        {
            Console.WriteLine(error.ToString());
        }
    }
}
