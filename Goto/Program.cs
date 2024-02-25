using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            inicio:
            Console.Write("Escolha uma opção:");
            int opcao = int.Parse(Console.ReadLine());
            int valor = 0;
            switch (opcao)
            {
                default:
                    Console.Write("Escolha uma opção de 1 a 2:");
                    goto inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
                    
            }
            Console.WriteLine($"O valor final foi de: {valor}");
            Console.ReadKey();
        }
    }
}
