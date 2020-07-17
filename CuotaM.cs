using System;

namespace CuotaM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu salario: ");
            Double monto = Double.Parse(Console.ReadLine());
            Double smmlv = 877803;

            if (monto < smmlv * 2)
            {
                Console.WriteLine("Paga tarifa A.");
                Console.WriteLine("Valor de cuota moderadora: $3400");
            }

            else if ((smmlv * 2) <= monto && monto <= (smmlv * 5))
            {
                Console.WriteLine("Paga tarifa B");
                Console.WriteLine("Valor de cuota moderadora: $13500 ");
            }

            else
            {
                Console.WriteLine("Paga tarifa C");
                Console.WriteLine("Valor de cuota moderadora: $35600");
            }
        }
    }
}


 
