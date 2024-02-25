using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Start
    {
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
                    Operacoes.Somar();
                    break;
                case "2":
                    Operacoes.Subtrair();
                    break;
                case "3":
                    Operacoes.Multiplicar();
                    break;
                case "4":
                    Operacoes.Dividir();
                    break;
                case "5":
                    Operacoes.EncontrarRestoDivisao();
                    break;
                case "6":
                    Operacoes.Potenciacao();
                    break;
            }
        }
    }
}
