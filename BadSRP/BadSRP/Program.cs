using System;

namespace BadSRP
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
            // 底下是在存取資料庫
            Console.WriteLine("Data inserted into database successfully");
            // 底下是寫入 Log 內
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
        }
    }
}
