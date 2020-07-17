using System;

namespace BinDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            int valorbinario;
            int valordecimal = 0;
            int bases = 1;
            int u;

            Console.Write("Ingresar un valor en binario : ");
            num = int.Parse(Console.ReadLine());
            valorbinario = num;
            while (num > 0)
            { 
                u = num % 10;
                valordecimal = valordecimal + u * bases;
                num = num / 10;
                bases = bases * 2;
            }
            Console.Write("el numero binario es : " + valorbinario);
            Console.Write("el decimal es: " + valordecimal);
            Console.ReadLine();

        }
    }
}
