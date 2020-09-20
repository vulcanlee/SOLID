using System;
using System.Collections.Generic;

namespace BadSRPOrderManager
{
    class Program
    {
        static void Main(string[] args)
        {
            new OrderManager().Processing();
        }
    }
    public class OrderManager
    {
        public List<Product> products = new List<Product>();

        public void Processing()
        {
            // 1. 檢查商品庫存數量是否足夠
            // 2. 進行付款處理程序
            // 3. 進行送貨處理程序
        }
    }
    public class Product { }
}
