using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i < numero + 1; i++) {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
