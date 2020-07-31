using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 10);
            int carta2 = aleatorio.Next(1, 10);
            int otraCarta;
            string continuar = "s";
            Console.WriteLine("Primera carta: " + carta1);
            Console.WriteLine("Segunda carta: " + carta2);
            int total = carta1 + carta2;
            Console.WriteLine("Total: " + total);

            Console.WriteLine("Otra carta? (s/n)");
            continuar = Console.ReadLine();

            while (continuar == "s" && total < 21)
            {
                otraCarta = aleatorio.Next(1, 10);
                Console.WriteLine("Carta nueva:" + otraCarta);
                total += otraCarta;
                if (total <= 21)
                {
                    Console.WriteLine("Nuevo puntaje:" + total);
                    Console.WriteLine("Otra carta? (s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Eliminado");
                }
            }

            Console.WriteLine("El puntaje final es:" + total);
        }
    }
}
