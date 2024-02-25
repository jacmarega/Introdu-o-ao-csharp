using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o lado do quadrado");
            float lado = float.Parse(Console.ReadLine());

            float area = funcao(lado);
            Console.WriteLine(area);

        }
        static float funcao(float lado)
        {
            return lado * lado;
        }
    }
}
