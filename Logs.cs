using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoggerDelegate
{
    /// Delegate type for logging messages
    public delegate void LogHandler(string message);
    public class Logs
    {

        // Methods to log messages with different background colors
        //log info message
        public void LogInfo(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        //log warning message
        public void LogWarning(string message)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        //log error message
        public void LogError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
