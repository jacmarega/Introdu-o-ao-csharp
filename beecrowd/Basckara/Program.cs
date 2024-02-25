using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basckara
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Delta != de negativo
           //A != 0

            string numeros = Console.ReadLine();
            string[] array = numeros.Split(' ');

            double a = double.Parse(array[0]);
            double b = double.Parse(array[1]);
            double c = double.Parse(array[2]);

            if( a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double delta = (b * b) - (4 * a * c);
                if(delta < 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    double x1 = (-(b) + (Math.Sqrt(delta)))/(2*a);
                    double x2 = (-(b) - (Math.Sqrt(delta)))/(2*a);

                    Console.WriteLine("R1 = {0:f5}", x1);
                    Console.WriteLine("R2 = {0:f5}", x2);
                }
            }
        }
    }
}
