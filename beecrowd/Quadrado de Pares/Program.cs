using System;
using System.Linq;

namespace Quadrado_de_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int numeroquadrado = 0;
            string alfabeto = "ABCDEFGHIJKKJAJO" +
                "0101010101010101010101010101010101010101010101010101010101010101" +
                "0101010101010101010101010101010101010101010101010101010101010101" +
                "DHQDQNPR1I02RN01IRNQEOANLIBDHIOABSDIA DLAHISD DP3U10101100011111000010010101010111111111000000" +
                "101011000111110000100101010101111111110000008H1R3OR198R7BQOEPBHOLUC";
            Random random = new Random();

            for (int i = 1; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    numeroquadrado = i * i;

                    // Embaralhar o alfabeto antes de cada linha
                    alfabeto = new string(alfabeto.OrderBy(c => random.Next()).ToArray());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}^{i} {numeroquadrado}{alfabeto}");
                }
            }
        }
    }
}
