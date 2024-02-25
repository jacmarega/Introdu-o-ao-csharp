using System;

namespace CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = Console.ReadLine();
            string numero2 = Console.ReadLine();

            string[] array = numero.Split(' ');
            int codigo = int.Parse(array[0]);
            int numeroPecas = int.Parse(array[1]);
            double valorPeca = double.Parse(array[2]);

            string[] array2 = numero2.Split(' ');
            int codigo2 = int.Parse(array2[0]);
            int numeroPecas2 = int.Parse(array2[1]);
            double valorPeca2 = double.Parse(array2[2]);

            double valorTotal = (numeroPecas * valorPeca) + (numeroPecas2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:0.00}");
        }
    }
}
