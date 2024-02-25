using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclofor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite o valor que deseja saber a tabuada: ");
            int j = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * j;
                Console.WriteLine($"{i} x {j} = {resultado}");
            }
            Console.ReadKey();*/

            Console.Write("Digite o valor que deseja saber a tabuada: ");
            int x = int.Parse(Console.ReadLine());
            
            for(int  i = 1; i < 10; i++)
            {
                int valor = i * x;
                Console.WriteLine($"{i} X {x} = {valor}");

            }
            Console.ReadKey();
        }
    }

}

