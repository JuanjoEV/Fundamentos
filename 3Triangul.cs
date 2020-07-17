using System;

namespace _3Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valores de c ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valores de z ");
            double z = double.Parse(Console.ReadLine());

            double cAnguloRad = c * (Math.PI / 180.0);

            double t = z / Math.Sin(cAnguloRad);
            double a = Math.Acos(z / t);
            double y = t * Math.Sin(a);


            double aAnguloGrad = a * (180.0 / Math.PI);


            Console.WriteLine("t: " + t);
            Console.WriteLine("a: " + aAnguloGrad);
            Console.WriteLine("y: " + y);
        }
    }
}
