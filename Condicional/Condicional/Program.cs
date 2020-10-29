using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo;
            string linea;
            Console.Write("Introduce el sueldo: ");
            linea = Console.ReadLine();
            sueldo = double.Parse(linea);
            if (sueldo > 3000)
            {
                Console.WriteLine("Tenés que pagar impuestos.");
            }
        }
    }
}
