using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano em que voce nasce: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - ano;
            Console.WriteLine($"Estamos no ano de {anoAtual}");
            Console.WriteLine($"Sua idade é: {idade}");
        }
    }
}
