using System;

namespace LSP3Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4; rectangle.Height = 5;
            Console.WriteLine($"Rectangle=" +
                $"{rectangle.GetArea()}");
            Square square = new Square();
            square.SideLength = 4;
            Console.WriteLine($"Square=" +
                $"{square.GetArea()}");
            // 將子類別物件設定給父類別型別物件
            IShape sharp = square;
            Console.WriteLine($"IShape Square=" +
                $"{sharp.GetArea()}");
            sharp = rectangle;
            Console.WriteLine($"IShape Rectangle=" +
                $"{sharp.GetArea()}");
        }
    }
    public interface IShape
    {
        int GetArea();
    }
    public class Rectangle : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int GetArea()
        {
            return Height * Width;
        }
    }
    public class Square : IShape
    {
        public int SideLength { get; set; }
        public int GetArea() => SideLength * SideLength;
    }
}
