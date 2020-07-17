using System;

namespace _2Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
              Console.WriteLine("Ingrese valores para a y t");
            double t = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double aRad = a * (Math.PI / 180.0);
           
            double aSen = Math.Sin(aRad);
            double aCos = Math.Cos(a);


            double z = t * a;
            double c = Math.Asin(z / t);
            double y = t * aSen;

            
            double cAnguloGrados = c * (180 / Math.PI);
            


            Console.WriteLine("z: "+ z);
            Console.WriteLine("c: "+ c);
            Console.WriteLine("y: "+ y);



             
            

            
           
    }
}
