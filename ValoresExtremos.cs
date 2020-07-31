using System;

namespace Intento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cantidad de datos: ");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int menor = 200;
            string nombreMayor = "";
            string nombreMenor = "";
            while (contador < datos)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Nombre:");
                string nombre = Console.ReadLine();
                if (edad > maximo)
                {
                    maximo = edad;
                    nombreMayor = nombre;
                }
                if (edad < menor)
                {
                    menor = edad;
                    nombreMenor = nombre;
                }
                total += edad;
                contador += 1;
            }
            double promedio = total / contador;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nombre de quien es mayor:" + nombreMayor);
            Console.WriteLine("Edad de quien es mayor: " + maximo);
            Console.WriteLine("Nombre de quien es menor: " + nombreMenor);
            Console.WriteLine("Edad de quien es menor: " + menor);
        }
    }
}
