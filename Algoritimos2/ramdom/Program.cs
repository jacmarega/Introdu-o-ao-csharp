using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ramdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(1, 20);
            int numero2 = 0;
            //Console.WriteLine(numero);
            do
            {
                Console.WriteLine("Digite um numero");
                numero2 = int.Parse(Console.ReadLine());
            } while (numero != numero2);

            Console.WriteLine("Numero certo");
        }
    }
}
