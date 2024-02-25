using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção que deseja: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                default:
                    Menu();
                    break;
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtrair();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    EncontrarRestoDivisao();
                    break;
                case "6":
                    Potenciacao();
                    break;
            }
        }
        public static void Somar()
        {
        Console.Write("Entre com o primeiro valor: ");
        double valorUm = double.Parse(Console.ReadLine());
        Console.Write("Entre com o primeiro valor: ");
        double valorDois = double.Parse(Console.ReadLine());

        Console.WriteLine($"{valorUm} + {valorDois} = {valorUm + valorDois}");
        Console.Write("Aperte qualquer tecla para voltar ao menu. ");
        Console.ReadLine();
        Menu();
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
        }
    }
}