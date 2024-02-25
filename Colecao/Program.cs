using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[1];
            Console.Write("Digite um numero: ");
            int.TryParse(Console.ReadLine(), out numeros[0]);
            Console.WriteLine(numeros[0]);
            Console.ReadKey();
            /*
             int[] vetor = new int [2]
             vetor[0] = 10;
             vetor[1] = 20;*/



        }
    }
}
