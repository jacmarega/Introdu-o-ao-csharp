using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float renda = float.Parse(Console.ReadLine());
            float isento = 2000.00f;
            float imposto8 = 0;
            float imposto18 = 0;
            float imposto28 = 0;

            float imposto = 0;
            if(renda <= isento)
            {
                Console.WriteLine("Isento");

            }else if (renda <= 3000.00f)
            {
                imposto = ((renda - isento) * 0.08f);
                Console.WriteLine($"R$ {imposto:.00}");

            }else if (renda <= 4500.00f)
            {
                imposto18 = ((renda - 3000.00f) * 0.18f);
                imposto = imposto18 + ((3000.00f - 2000.00f) * 0.08f);
                Console.WriteLine($"R$ {imposto:.00}");
            }

            else
            {   
                imposto28 = ((renda - 4500.00f) * 0.28f);
                imposto18 = imposto28 + ((4500.00f - 3000.00f) * 0.18f);
                imposto = imposto18 + ((3000.00f - 2000.00f) * 0.08f);
                Console.WriteLine($"R$ {imposto:.00}");
            }
        }
    }
}
