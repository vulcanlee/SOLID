using System;

namespace LSP2Square
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
            square.Width = 4;
            Console.WriteLine($"Square=" +
                $"{square.GetArea()}");
            // 將子類別物件設定給父類別型別物件
            Rectangle rectangleSquare = square;
            // 將這個類別視為矩形來使用
            rectangleSquare.Width = 4; rectangleSquare.Height = 5;
            Console.WriteLine($"Rectangle=" +
                $"{rectangleSquare.GetArea()}");
            // 透過第三方類別來計算面積
            rectangleSquare.Width = 2; rectangleSquare.Height = 3;
            Console.WriteLine($"Rectangle By Library=" +
                $"{AreaCalculator.CalculateArea(rectangleSquare)}");
            Console.WriteLine($"Square By Library=" +
                $"{AreaCalculator.CalculateArea(square)}");
        }
    }
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Height;
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
    public class Square : Rectangle
    {
        public int Height
        {
            get { return _height; }
            set { _height = _width = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = _height = value; }
        }
    }
}
