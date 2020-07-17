using System;

namespace Tarifa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu salario: ");
            double monto = double.Parse(Console.ReadLine());

            if ( monto <= 877803 * 2)
            {
                Console.WriteLine("Es tarifa A");
            }

            else if ((877803 * 2) <= monto && monto <= (877803 * 4))
            {
                Console.WriteLine("Es tarifa B");
            }

            else
            {
                Console.WriteLine("Es tarifa C");
            }
        }
    }
}
