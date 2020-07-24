using System;

namespace Deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu salario: ");
            int salario = int.Parse(Console.ReadLine());
             
            
            {
                salario = 877803;
                Console.WriteLine("Ingresa tipo de contrato(1: dependiente, 2: independiente)");
                int tipoCon = int.Parse(Console.ReadLine());
                if (tipoCon == 2)
                {
                    Console.WriteLine("Ingresa valor del 1 al 5 dpendiendo de la clase de riesgo");
                    int riesg = int.Parse(Console.ReadLine());
                    if (riesg == 1)
                    {
                        double riesg1 = 0.522;
                        int baseCot = (salario) * (40 / 100);
                        int pension = (baseCot) * (16 / 100);
                        double eps = (baseCot) * (12.5 / 100);
                        double arl = (baseCot) * (riesg1 / 100);
                        

                        double salReal = salario - pension - eps - arl;
                        double salAnual = salReal * 12;

                        Console.WriteLine("Salario real: " + salReal);
                        Console.WriteLine("Salario anual: " + salAnual);
                    }
                    else if (riesg == 2)
                    {
                        double riesg2 = 1.044;
                        int baseCot = salario * (40 / 100);
                        int pension = baseCot * (16 / 100);
                        double eps = baseCot * (12.5 / 100);
                        double arl = baseCot * (riesg2 / 100);

                        double salReal = salario - pension - eps - arl;
                        double salAnual = salReal * 12;

                        Console.WriteLine("Salario real: " + salReal);
                        Console.WriteLine("Salario anual: " + salAnual);
                    }
                    else if (riesg == 3)
                    {
                        double riesg3 = 2.436;
                        int baseCot = salario * (40 / 100);
                        int pension = baseCot * (16 / 100);
                        double eps = baseCot * (12.5 / 100);
                        double arl = baseCot * (riesg3 / 100);

                        double salReal = salario - pension - eps - arl;
                        double salAnual = salReal * 12;

                        Console.WriteLine("Salario real: " + salReal);
                        Console.WriteLine("Salario anual: " + salAnual);
                    }
                    else if (riesg == 4)
                    {
                        double riesg4 = 4.350;
                        int baseCot = salario * (40 / 100);
                        int pension = baseCot * (16 / 100);
                        double eps = baseCot * (12.5 / 100);
                        double arl = baseCot * (riesg4 / 100);

                        double salReal = salario - pension - eps - arl;
                        double salAnual = salReal * 12;

                        Console.WriteLine("Salario real: " + salReal);
                        Console.WriteLine("Salario anual: " + salAnual);
                    }
                    else if (riesg == 5)
                    {
                        double riesg5 = 6.960;
                        int baseCot = salario * (40 / 100);
                        int pension = baseCot * (16 / 100);
                        double eps = baseCot * (12.5 / 100);
                        double arl = baseCot * (riesg5 / 100);

                        double salReal = salario - pension - eps - arl;
                        double salAnual = salReal * 12;

                        Console.WriteLine("Salario real: " + salReal);
                        Console.WriteLine("Salario anual: " + salAnual);
                    }

                    int baseCoDep = salario * (40 / 100);
                    int pensioDep = baseCoDep * (4 / 100);
                    double epsDep = baseCoDep * (14 / 100);
                

                    double salRealDep = salario - pensioDep - epsDep;
                    double salAnualDep = (salRealDep * 12) + salario;

                    Console.WriteLine("Salario real: " + salRealDep);
                    Console.WriteLine("Salario anual: " + salAnualDep);
                }

                else
                {

                }


            }
        }
    }
}
