using System;

namespace Ex_DI_Logger_SOLID
{
    // ISP/SRP hint:
    // Keep interfaces small and focused.
    // ILogger has only one responsibility: logging.
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("[Console] " + message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // In real apps, write to file (omitted here).
            Console.WriteLine("[File] " + message);
        }
    }

    public class App
    {
        private readonly ILogger _logger;

        // ✅ DIP (Dependency Inversion Principle):
        // High-level module (App) depends on abstraction (ILogger),
        // not on concrete classes (ConsoleLogger/FileLogger).
        public App(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            // ✅ SRP:
            // App runs business logic; Logger logs. Do not mix concerns.
            _logger.Log("App started.");
        }
    }

    class Program
    {
        static void Main()
        {
            // ✅ OCP (Open/Closed Principle):
            // We can "extend" logging behavior by adding a new logger class
            // without modifying App.
            App app1 = new App(new ConsoleLogger());
            app1.Run();

            App app2 = new App(new FileLogger());
            app2.Run();

            Console.ReadKey();
        }
    }
}

/*
SOLID Links:
- DIP: App -> ILogger (abstraction)
- OCP: add new logger types without changing App
- SRP: logging responsibility separated from application logic
*/
