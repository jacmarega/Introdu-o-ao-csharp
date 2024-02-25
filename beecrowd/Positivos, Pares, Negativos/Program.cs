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
            int pares = 0, positivos = 0, negativos =  0,impar = 0 ;
            int[] vetor = new int[5];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > 0)
                {
                    positivos++;
                }
                else if (vetor[i] <0)
                {
                    negativos++;
                }
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");

        }
    }
}
