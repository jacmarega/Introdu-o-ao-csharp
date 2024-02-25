using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Produto 1: ");
            string produtoUm = Console.ReadLine();
            float precoUm = 0;
            Console.Write("Preço 1: ");
            float.TryParse(Console.ReadLine(), out precoUm);

            Console.Write("Produto 2: ");
            string produtoDois = Console.ReadLine();
            float precoDois = 0;
            Console.Write("Preço 2: ");
            float.TryParse(Console.ReadLine(), out precoDois);

            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"Produto ",-20}{"Preço ",13}");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{produtoUm,-20}{precoUm,13}");
            Console.WriteLine($"{produtoDois,-20}{precoDois,13}");

            Console.ReadKey();
        }
    }
}
