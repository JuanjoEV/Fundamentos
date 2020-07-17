using System;

namespace _2Triangul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valores para t ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valores para a");
            double a = double.Parse(Console.ReadLine());

            double aRad = a * (Math.PI / 180.0);

            double aSen = Math.Sin(aRad);
            double aCos = Math.Cos(a);

            double b = 90;
            double z =(t) * a;
            double c = 180 - (90+a);
            double y = t * aSen;


            double cAnguloGrados = c * (180 / Math.PI);



            Console.WriteLine("z: " + z);
            Console.WriteLine("c: " + c);
            Console.WriteLine("y: " + y);
        }
    }
}
