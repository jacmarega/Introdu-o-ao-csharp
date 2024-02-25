using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa um: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da pessoa um: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa dois: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da pessoa tres: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Pessoa p3 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa tres: ");
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da pessoa tres: ");
            p3.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if (p2.Idade > p1.Idade && p2.Idade > p1.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if (p3.Idade > p1.Idade && p3.Idade > p1.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            } else {
                Console.WriteLine("Duas pessoas com a mesma idade");
            }
            Console.ReadKey();
        }
    }
}
