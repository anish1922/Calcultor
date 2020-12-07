using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc c = new Calc();

            Console.Write(c.Add(2, 3));
        }
    }
}
