using System;

namespace _1Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de Y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de Z");
            double z = double.Parse(Console.ReadLine());
            double b = 90;
            double t;
            double a;
            double c;
            double catetos = (Math.Pow(y, 2) + Math.Pow(z, 2));
            t = Math.Sqrt(catetos);

            double resultado = Math.Asin(y / t);
            a = resultado * (180 / Math.PI);

            double resultado2 = Math.Asin(z / t);
            c = resultado2 * (180 / Math.PI);

            Console.WriteLine("t= " + t);
            Console.WriteLine("a= " + a);
            Console.WriteLine("c= " + c);

            // y = double.Parse(Console.ReadLine());
        }
    }
}
