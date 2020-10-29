using System;

namespace Condicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escribe un número.");
            string paco = Console.ReadLine();
            num = int.Parse(paco);

            if((num > 0) && (num < 100))
            {
            if ((num / 10) >= 1) Console.WriteLine("Dos dígitos.");
            else Console.WriteLine("Un dígito.");
            }
            

        }
    }
}
