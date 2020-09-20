using System;

namespace LSPFruitFix
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
            Console.WriteLine($"AppleOrange is {appleOrange.GetColor()}");
        }
    }
    public class Apple
    {
        public virtual string GetColor() => "Red";
    }
    public class Orange : Apple
    {
        public override string GetColor() => "Orange";
    }
}
