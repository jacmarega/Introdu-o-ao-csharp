using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSelecao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros = Console.ReadLine();
            string[] array = numeros.Split(' ');
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int c = int.Parse(array[2]);
            int d = int.Parse(array[3]);

            int cd = c + d;
            int ab = a + b;
            if (b > c && d > a && cd > ab && c>0 && d>0 && a%2==0)
            {
                Console.WriteLine("Valores aceitos");

            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
