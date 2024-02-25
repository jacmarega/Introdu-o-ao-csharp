using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;
            switch (escolha)
            {
                default:
                    Console.WriteLine("Opção invalida");
                    break;
                case 1:
                    Console.WriteLine("Opção 01");
                    break;
                case 2:
                    Console.WriteLine("Opção 02");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Opção 3");
                    break;

            }

        }
    }
}
