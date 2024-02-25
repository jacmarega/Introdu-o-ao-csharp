using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int valor = 5;
            do
            {
                Console.WriteLine($"Valor: {valor}");
                valor++;
            } while (valor <= 10);
            Console.ReadKey();*/

            int x = 0;
            do
            {
                Console.WriteLine($"Valor: {x}");
                x++;

            }while(x < 10);
            Console.ReadKey();
        }
    }
}
