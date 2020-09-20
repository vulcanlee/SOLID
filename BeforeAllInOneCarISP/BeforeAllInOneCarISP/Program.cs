using System;

namespace BeforeAllInOneCarISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IAllInOneCar
    {
        void StartEngine();
        void Drive();
        void StopEngine();
        void ChangeEngine();
    }

    public class Driver : IAllInOneCar
    {
        public void ChangeEngine()
        { throw new NotImplementedException(); }

        public void Drive()
        { }

        public void StartEngine()
        { }

        public void StopEngine()
        { }
    }

}
