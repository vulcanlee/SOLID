using System;

namespace LSP1Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle o = new Rectangle();
            o.Width = 40; o.Height = 50;
            Console.WriteLine($"Rectangle" +
                $"({o.Width}x{o.Height}) area is " +
                $"{o.GetArea()}");
        }
    }
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int GetArea()
        {
            return Height * Width;
        }
    }
}
