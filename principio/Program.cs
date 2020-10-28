using System;

namespace principio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string prr;
            int a;

            prr = Console.ReadLine();
            a = int.Parse(prr);
            Console.WriteLine(a * 4);
            Console.ReadKey();
        }
    }
}
