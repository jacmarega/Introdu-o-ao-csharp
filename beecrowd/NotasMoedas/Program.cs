using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dinheiro = float.Parse(Console.ReadLine());
            double[] valor = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            int quantidaDeNotas;

            Console.WriteLine("NOTAS: ");
            
            for (int i = 0; i < 6; i++)
            {
                quantidaDeNotas = (int)(dinheiro / valor[i]);
                Console.WriteLine(quantidaDeNotas + " nota(s) de R$ " + valor[i].ToString("0.00"));
                dinheiro -= quantidaDeNotas * valor[i];
                dinheiro = Math.Round(dinheiro, 2);
            }
            Console.WriteLine("MOEDAS: ");
            
            for(int i = 6; i < valor.Length; i++)
            { 
                quantidaDeNotas = (int)(dinheiro / valor[i]);
                Console.WriteLine(quantidaDeNotas + " moedas(s) de R$ " + valor[i].ToString("0.00"));
                dinheiro -= quantidaDeNotas * valor[i];
                dinheiro = Math.Round(dinheiro, 2);
            }
            Console.ReadKey();
        }
    }
}
