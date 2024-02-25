using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 3];

            //Linha 01
            numeros[0, 0] = 1;
            numeros[0, 1] = 2;
            numeros[0, 2] = 3;

            //Linha 02
            numeros[1, 0] = 4;
            numeros[1, 1] = 5;
            numeros[1, 2] = 6;

            Console.Write($"[{numeros[0, 0]}]");
            Console.Write($"[{numeros[0, 1]}]");
            Console.WriteLine($"[{numeros[0, 2]}]");

            Console.Write($"[{numeros[1, 0]}]");
            Console.Write($"[{numeros[1, 1]}]");
            Console.Write($"[{numeros[1, 2]}]");

            Console.ReadKey();


        }

    }
}
