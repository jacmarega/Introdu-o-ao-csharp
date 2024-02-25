using System;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int somaImpares = 0;

            if( x == y)
            {
                somaImpares = 0;
            } 
            else if(x < y)
            {
                for(x=x+1; x<y; x++)
                {
                    if (x % 2 == 1 || x%2 == -1)
                    {
                        somaImpares += x;
                    }
                }
            }
            else if(x>y) 
            {
                for(y=y+1; y<x; y++)
                {
                    if (y % 2 == 1 || y % 2 == -1)
                    {
                        somaImpares += y;
                    }
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}
