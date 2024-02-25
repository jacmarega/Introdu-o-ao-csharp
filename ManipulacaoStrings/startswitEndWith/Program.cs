using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startswitEndWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "joao";
            bool  res = nome.StartsWith("j", StringComparison.OrdinalIgnoreCase);
            if (res)
            {
                Console.WriteLine("positivo");
            }
            else
            {
                Console.WriteLine("negativo");
            }

            bool res2 = nome.EndsWith("O", StringComparison.OrdinalIgnoreCase);
            if (res2)
            {
                Console.WriteLine("positivo");
            }
            else
            {
                Console.WriteLine("negativo");
            }
        }
    }
}
