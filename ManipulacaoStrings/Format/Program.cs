using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 19.95m;
            int temp = 32;
            //{0:N3} - Vai colocar mais um decimal
            string s = String.Format("O valor do produto é: {0} e a temperatura é: {1}", valor, temp);

            string s2 = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);
            Console.WriteLine(s2);
        }
    }
}
