using System;

namespace LSPFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Console.WriteLine($"Apple is {apple.GetColor()}");
            Orange orange = new Orange();
            Console.WriteLine($"Apple is {orange.GetColor()}");
            Apple appleOrange = new Orange();
            Console.WriteLine($"AppleOrange is {apple.GetColor()}");
        }
    }
    public class Apple
    {
        public string GetColor() => "Red";
    }
    public class Orange:Apple
    {
        public string GetColor() => "Orange";
    }
}
