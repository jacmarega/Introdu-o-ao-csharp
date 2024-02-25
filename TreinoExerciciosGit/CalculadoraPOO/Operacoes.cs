using CalculadoraPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacoes
    {
        public static void Somar()
        {
            Console.Write("Entre com o primeiro valor: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o primeiro valor: ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valorUm} + {valorDois} = {valorUm + valorDois}");
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
        public static void Subtrair()
        {
            Console.Write("Entre com o primeiro valor: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o primeiro valor: ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valorUm} - {valorDois} = {valorUm - valorDois}");
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
        public static void Multiplicar()
        {
            Console.Write("Entre com o primeiro valor: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o primeiro valor: ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valorUm} * {valorDois} = {valorUm * valorDois}");
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
        public static void Dividir()
        {
            Console.Write("Entre com o dividendo: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o divisor: ");
            double valorDois = double.Parse(Console.ReadLine());
            if (valorDois != 0)
            {
                Console.WriteLine($"{valorUm} / {valorDois} = {valorUm / valorDois}");
            }
            else
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
        public static void EncontrarRestoDivisao()
        {
            Console.Write("Entre com o primeiro valor: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o primeiro valor: ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine($"Resto: {valorUm} / {valorDois} = {valorUm % valorDois}");
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
        public static void Potenciacao()
        {
            Console.Write("Entre com o primeiro valor: ");
            double valorUm = double.Parse(Console.ReadLine());
            Console.Write("Entre com o o expoente ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valorUm} elevado a {valorDois} = {Math.Pow(valorUm, valorDois)}");
            Console.Write("Aperte qualquer tecla para voltar ao menu. ");
            Console.ReadLine();
            Start.Menu();
        }
    }
}
    }
}
