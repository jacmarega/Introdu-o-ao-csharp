using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int[] numeros = new int[numero];
            int inn = 0, ot = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] >= 10 && numeros[i] <= 20)
                {
                    inn++;
                }
                else
                {
                    ot++;
                }
            }
            Console.WriteLine($"{inn} in");
            Console.WriteLine($"{ot} out");
        }
    }
}
