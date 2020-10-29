using System;

namespace principio
{
    class Program
    {
        static void Main(string[] args)
        {
            string prr;
            int a;
            Console.WriteLine("Dame un numerito.");
            prr = Console.ReadLine();
            a = int.Parse(prr);
            Console.WriteLine(a * 4);
            Console.ReadKey();
        }
    }
}
