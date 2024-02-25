using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToupperELower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            string nomeMaiusculo = nome.ToUpper();
            string nomeMinusculo = nome.ToLower();
            Console.WriteLine($"Nome em maicusulo: {nomeMaiusculo}");
            Console.WriteLine($"Nome em minusculo: {nomeMinusculo}");
            Console.ReadKey();
        }

    }
}
