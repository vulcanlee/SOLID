using System;

namespace CopySourceDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Copy();
        }

        private static void Copy()
        {
            while(true)
            {
                var consoleKeyInfo = Console.ReadKey(true);
                if(consoleKeyInfo.Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.Write(consoleKeyInfo.KeyChar);
            }
        }
    }
}
