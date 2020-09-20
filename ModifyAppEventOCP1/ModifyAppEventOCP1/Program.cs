using System;
using System.IO;

namespace ModifyAppEventOCP1
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppEvent().GenerateEvent("Specific Console Output", "Console");
        }
    }
    public class AppEvent
    {
        public void GenerateEvent(string message, string outputType)
        {
            Logger fooLogger = new Logger(outputType);
            fooLogger.Log(message);
        }
    }
    public class Logger
    {
        private readonly string _Target;

        public Logger(string target) { _Target = target; }
        public void Log(string message)
        {
            if (_Target == "Console")
                Console.WriteLine(message);
            else if (_Target == "File")
                File.WriteAllText("MyLog", message);
            else
                throw new NotImplementedException();
        }
    }
}
