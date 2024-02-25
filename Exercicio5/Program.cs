using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorteador de numero");

            Console.Write("Inicio: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final: ");
            int final = Convert.ToInt32(Console.ReadLine());

            Random gerador =  new Random();
            int numeroSorteado = gerador.Next(inicio, final);

            Console.SetCursorPosition(0, 10);
            Console.Write("Sorteando...");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 10);
            Console.Write($"Entre os numeros {inicio} e {final} eu sorteei o numero {numeroSorteado + 1}");
            Console.ReadKey();


        }
    }
}
