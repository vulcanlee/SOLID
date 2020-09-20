using System;

namespace AllInOnePrinterISP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IBusinessPrinters: ICopyPrinter
    {
        void FaxSending();
        void FaxReceiving();
    }
    public interface ICopyPrinter: ISimplePrinter
    {
        void Copy();
        void Scan();
    }
    public interface ISimplePrinter
    {
        void Print();
    }
    public class AllInOnePrinter : IBusinessPrinters
    {
        public void Copy() { Console.WriteLine("拷貝中"); }
        public void FaxReceiving() { Console.WriteLine("傳真接收中"); }
        public void FaxSending() { Console.WriteLine("傳真發送中"); }
        public void Print() { Console.WriteLine("列印中"); }
        public void Scan() { Console.WriteLine("掃描中"); }
    }
    public class SimplePrinter : ISimplePrinter
    {
        public void Print() { Console.WriteLine("列印中"); }
    }
    public class CopyPrinter : ICopyPrinter
    {
        public void Copy() { Console.WriteLine("拷貝中"); }
        public void Print() { Console.WriteLine("列印中"); }
        public void Scan() { Console.WriteLine("掃描中"); }
    }
}
