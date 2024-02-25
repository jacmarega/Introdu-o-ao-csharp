using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Digite quantas linhas tem a matriz");
            int linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas da matriz");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j<coluna; j++)
                {
                    matriz[i, j] = contador;
                    contador++;
                    Console.WriteLine(matriz[i, j]);
                }
            }

        }
    }
}
