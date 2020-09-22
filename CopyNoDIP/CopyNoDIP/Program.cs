using System;
using System.IO;

namespace CopyNoDIP
{
    public class File
    {
        private static StreamWriter writer;
        public static void InitializizeStreamWriter(string filePath)
        {
            writer = new StreamWriter(filePath);
        }
        public static void Write(char character)
        {
            writer.Write(character);
        }
        public static void Dispose()
        {
            writer.Close();
            writer.Dispose();
        }
    }
    public enum Target
    {
        Console,
        File
    }
    class Program
    {
        static void Main(string[] args)
        {
            Copy( Target.File);
        }
        private static void Copy(Target target)
        {
            if (target == Target.File)
                File.InitializizeStreamWriter("MyFile.txt");

            while (true)
            {
                var consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (target == Target.Console)
                {
                    Console.Write(consoleKeyInfo.KeyChar);
                }
                else if (target == Target.File)
                {
                    File.Write(consoleKeyInfo.KeyChar);
                }
            }
            if (target == Target.File)
                File.Dispose();
        }
    }
}
