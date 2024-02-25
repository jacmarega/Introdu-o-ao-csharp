using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numero = int.Parse(Console.ReadLine());
        for(int i = 0; i < numero; i++) 
        {
            int numero2 = int.Parse(Console.ReadLine());
                if (numero2 == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (numero2 < 0 && numero2 % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if ((numero2 < 0 && numero2 % 2 != 0))
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numero2 > 0 && numero2 % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (numero2 > 0 && numero2 % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }   
            }
        }
    }
}

