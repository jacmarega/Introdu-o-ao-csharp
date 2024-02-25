using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação_de_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrizUm = new int[2, 3];
            int[,] matrizDois = new int[3, 2];
            int[,] matrizResultante = new int[2, 3];

            Console.WriteLine("Preencha a matriz 01: ");
            for(int linha = 0; linha < 2; linha++) 
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"#1. Posição [{linha}][{coluna}]: ");
                    matrizDois[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
