using System;

namespace LSP1Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4; rectangle.Height = 5;
            Console.WriteLine($"Rectangle" +
                $"({rectangle.Width}x{rectangle.Height}) area is " +
                $"{rectangle.GetArea()}");
        }
    }
    public class Rectangle
    {
        protected int _height;
        protected int _width;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public int GetArea()
        {
            return Height * Width;
        }
    }
}
