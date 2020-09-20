using System;

namespace GoodSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.InsertData();
        }
    }
    class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
            Logger.WriteLog();
        }
    }
    class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() +
                " Log  Data insertion completed successfully");
        }
    }

}
