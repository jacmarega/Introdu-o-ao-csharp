using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());
            int SOMA = A + B;
            Console.WriteLine("SOMA = "+SOMA);

            int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());
            int PROD = A + B;
            Console.WriteLine("SOMA = " + PROD);
        }
    }
}
