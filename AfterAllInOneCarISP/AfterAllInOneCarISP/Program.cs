using System;

namespace AfterAllInOneCarISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDriver o = new Driver();
            o.StartEngine();
            o.Drive();
            o.StopEngine();
        }
    }
    public interface IDriver
    {
        void StartEngine();
        void Drive();
        void StopEngine();
    }
    public class Driver : IDriver
    {
        public void Drive()
        { }

        public void StartEngine()
        { }

        public void StopEngine()
        { }
    }
    public interface IMechanic
    {
        void ChangeEngine();
    }

    public class Mechanic : IMechanic
    {
        public void ChangeEngine()
        { throw new NotImplementedException(); }
    }
}
