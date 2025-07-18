// See https://aka.ms/new-console-template for more information
using EventLoggerDelegate;

//log delegate type
Logs logs = new Logs();

// Create a delegate instance for logging
LogHandler logHandler = null;

// Display options to the user
Console.WriteLine("Event Logger using Delegate");
Console.WriteLine("Choose Log Type:");
Console.WriteLine("1 - Info");
Console.WriteLine("2 - Warning");
Console.WriteLine("3 - Error");
Console.Write("Enter your choice (1/2/3): ");

// Read user input for log type
string input = Console.ReadLine();

// Determine the log type based on user input
switch (input)
{
    case "1":
        logHandler = logs.LogInfo;
        break;
    case "2":
        logHandler = logs.LogWarning;
        break;
    case "3":
        logHandler = logs.LogError;
        break;
    default:
        Console.WriteLine("Invalid choice. Exiting.");
        return;
}
// Prompt for the log message
string message = Console.ReadLine();

// Invoke the delegate
logHandler?.Invoke(message);
