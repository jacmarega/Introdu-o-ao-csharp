using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Treino03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.Write("Digite a altura do retangulo: ");
            retangulo.Altura = int.Parse(Console.ReadLine());

            Console.Write("Digite a Base do retangulo: ");
            retangulo.Base = int.Parse(Console.ReadLine());

            retangulo.ExibeDados(); 

        }
    }
}
