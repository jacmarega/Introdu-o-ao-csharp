using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double totalReceber = salarioFixo + (vendas * 0.15);
            Console.WriteLine($"TOTAL = {totalReceber:0.00}");
        }
    }
}
