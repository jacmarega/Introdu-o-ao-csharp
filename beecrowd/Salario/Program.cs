using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            float valorPorHora = float.Parse(Console.ReadLine());

            float salario = valorPorHora * horasTrabalhadas;
            Console.WriteLine($"NUMBER = {numeroDoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:0.00}");

        }
    }
}
