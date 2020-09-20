using System;

namespace BeforeOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class SqlDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("\nSql Connection opened successfully");
            return 1;
        }
        public int CloseConnection()
        {
            Console.WriteLine("Sql Connection closed successfully");
            return 1;
        }
        public int ExecuteCommand()
        {
            Console.WriteLine("Sql Command Executed successfully");
            return 1;
        }
    }
}
