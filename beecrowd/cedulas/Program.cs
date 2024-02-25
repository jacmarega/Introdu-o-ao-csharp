using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int notas100 = valor / 100;
            int restoNotas100 = valor % 100;

            int notas50 = restoNotas100 / 50;
            int restoNotas50 = restoNotas100 % 50;

            int notas20 = restoNotas50 / 20;
            int restoNotas20 = restoNotas50 % 20;

            int notas10 = restoNotas20 / 10;
            int restoNotas10 = restoNotas20 % 10;

            int notas5 = restoNotas10 / 5;
            int restoNotas5 = restoNotas10 % 5;

            int notas2 = restoNotas5 / 2;
            int restoNotas2 = restoNotas5 % 2;

            int notas1 = restoNotas2;

            Console.WriteLine(valor);
            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1} nota(s) de R$ 1,00");

        }
    }
}
