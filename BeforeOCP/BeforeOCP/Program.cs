using System;

namespace BeforeOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 功能寫死，無法輕易擴充存取其他資料庫
            SqlDataProvider SqlDataProvider = 
                new SqlDataProvider();
            SqlDataProvider.OpenConnection();
            SqlDataProvider.ExecuteCommand();
            SqlDataProvider.CloseConnection();
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
