using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Treino04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quer cadastrar quantas pessoas?");
            int qt = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qt; i ++)
            {
                Pessoa pi = new Pessoa();
                Console.Write($"Escreva o nome da pessoa {i}: ");
                pi.Nome = Console.ReadLine();

                Console.Write($"Escreva a altura da pessoa {i}: ");
                pi.Altura = float.Parse(Console.ReadLine());

                Console.Write($"Escreva a data de nascimento pessoa {i}: ");
                pi.Data = DateTime.Parse(Console.ReadLine());

                pi.imprimirDados();
                pi.idade();

                Console.Write("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
