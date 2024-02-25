using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_e_Posição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x=y=z=0;
            for (int i =1; i<101; i++)
            {
                 x = int.Parse(Console.ReadLine());
                if (x >  y)
                {
                    y = x;
                    z = i;
                }
            }
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
