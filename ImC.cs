using System;

namespace PesoM
{
    class Program
    {
        static void Main(string[] args)
        {
            float wpeso;
            float altura;
            float imc;

            Console.Write("Escribe el peso: ");
            wpeso = float.Parse(Console.ReadLine());

            Console.Write("Escribe la altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = (wpeso / (altura * altura));
            Console.WriteLine("imc =" + imc);
            
            if (imc <= 18.5)
            {
                Console.WriteLine("Bajo de peso");
            }
            else if ((imc > 18.5) && (imc <= 25))
            {
                Console.WriteLine("Peso normal");
            }
            else if ((imc > 25)&&(imc <=  30))
            {
                Console.WriteLine("Sobrepeso");
            
            }
            else if ((imc > 30)&&(imc <= 35))
            {
                Console.WriteLine("Obesidad de grado I");
            }
            else if ((imc > 35)&& (imc <40))
            {
                Console.WriteLine("Obesidad de grado II");

            }
            else if (imc>=40)
            {
                Console.WriteLine("Obesidad de grado III");
            }
            Console.ReadKey();
        }
    }
}
