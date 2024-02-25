using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.
            int numero;
            numero = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10000; i++) 
            {
                if(i % numero == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
