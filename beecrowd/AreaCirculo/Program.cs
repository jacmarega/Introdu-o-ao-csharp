using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal raio = decimal.Parse(System.Console.ReadLine().Trim());
            decimal n = 3.14159m;
            decimal area = n * (raio * raio);
            Console.WriteLine(string.Format("A={0:0.0000}", area));
        }
    }
}
