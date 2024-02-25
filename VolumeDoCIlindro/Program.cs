using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeDoCIlindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, A, h, V;
            R = 0;
            while(R <= 0)
            {
                Console.WriteLine("Digite o valor do raio da base do cilindro");
                R = double.Parse(Console.ReadLine());
            }
            h = 0;
            while (h <= 0)
            {
                Console.WriteLine("Digite o valor da altura do cilindro");
                h = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //are da base 
            A = Math.PI * Math.Pow(R, 2);
            V = A * h;

            Console.WriteLine($"Volume do cilindo {V}");
        }
    }
}
