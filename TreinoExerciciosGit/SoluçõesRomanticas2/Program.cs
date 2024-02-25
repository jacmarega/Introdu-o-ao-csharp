using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoluçõesRomanticas2
{
    internal class Program
    {
        static void Main(string[] args)
        {   inicio:
            Classe calculador = new Classe();
            Console.Write("Digite o nome da pessoa: ");
            calculador.nome = Console.ReadLine();
            Console.Write("Digite o nome da  outra pessoa: ");
            calculador.nomeDois = Console.ReadLine();
            Console.WriteLine($"As chances das pessoas {calculador.nome} e {calculador.nomeDois} ficarem juntas é: {calculador.CalcularProbalidade()}%");
            Console.WriteLine("Deseja realizar a operação novamente? S/N");
            string opcao = Console.ReadLine();
            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase)){
                goto inicio;
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}
