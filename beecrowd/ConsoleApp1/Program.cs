using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            string numeros = Console.ReadLine();
            string[] array = numeros.Split(' ');
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int c = int.Parse(array[2]);

            if (a >= b && a >= c)
            {
                maior = a;
            }else if (b >= a && b >= c)
            {
                maior = b;
            }else
            {
                maior = c;
            }

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
