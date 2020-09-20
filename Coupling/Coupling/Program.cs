using System;

namespace Coupling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Order
    {
        private ShoppingCartContents cart;
        private float salesTax;

        public Order(ShoppingCartContents cart, float salesTax)
        {
            this.cart = cart;
            this.salesTax = salesTax;
        }

        public float OrderTotal()
        {
            float cartTotal = 0;
            for (int i = 0; i < cart.items.Length; i++)
            {
                cartTotal += cart.items[i].Price * cart.items[i].Quantity;
            }
            cartTotal += cartTotal * salesTax;
            return cartTotal;
        }
    }
    public class ShoppingCartContents
    {
        public ShoppingCart[] items;
    }

    public class ShoppingCart
    {
        public float Price;
        public int Quantity;
    }
}
