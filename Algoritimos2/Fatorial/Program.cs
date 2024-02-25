using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fatorial(num));
        }
        static int Fatorial(int num)
        {
            if(num == 0) {
                return 1;
            }
            return num * Fatorial(num-1);
        } 
    }
}
