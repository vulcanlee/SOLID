using System;

namespace BeforeAppEventOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppEvent().GenerateEvent("Only Console Output");
        }
    }
    public class AppEvent
    {
        public void GenerateEvent(string message)
        {
            Logger fooLogger = new Logger();
            fooLogger.Log(message);
        }
    }
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
