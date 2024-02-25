using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;
            int[] vetor = new int[5];
            for(int i =  0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine($"{pares} valores pares");
        }
    }
}
