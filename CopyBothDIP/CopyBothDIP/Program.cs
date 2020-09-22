using System;
using System.IO;

namespace CopyBothDIP
{
    public interface IReader
    {
        ReadResult Read();
    }
    public interface IWriter: IDisposable
    {
        void Writer(char character);
    }
    public class ConsoleReader : IReader
    {
        public ReadResult Read()
        {
            var consoleKeyInfo = Console.ReadKey(true);
            return new ReadResult(consoleKeyInfo.KeyChar,
                consoleKeyInfo.Key == ConsoleKey.Escape);
        }
    }
    public class ConsoleWriter : IWriter
    {
        public void Dispose()
        {
        }
        public void Writer(char character)
        {
            Console.Write(character);
        }
    }
    public class FileWriter : IWriter
    {
        private readonly StreamWriter writer;
        public FileWriter(string filePath)
        {
            writer = new StreamWriter(filePath);
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        public void Writer(char character)
        {
            writer.Write(character);
        }
    }
    public class ReadResult
    {
        public readonly char character;
        public readonly bool shouldQuit;
        public ReadResult(char character, bool shouldQuit)
        {
            this.character = character;
            this.shouldQuit = shouldQuit;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Composition Root
            // Pure DI / Pool Man DI
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Copy(reader, writer);
            writer.Dispose();
        }
        private static void Copy(IReader reader, IWriter writer)
        {
            #region 這樣的寫法會造成緊密耦合
            //IReader reader = new ConsoleReader();
            //IWriter writer = new ConsoleWriter();
            #endregion

            while (true)
            {
                var readResult = reader.Read();
                if (readResult.shouldQuit)
                    break;
                writer.Writer(readResult.character);
            }
        }
    }
}
