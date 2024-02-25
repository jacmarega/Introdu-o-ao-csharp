using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDeJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 60;
            string horas = Console.ReadLine();
            string[] array = horas.Split(' ');
            
            int h1 = int.Parse(array[0]);
            int h2 = int.Parse(array[1]);
            if(h1 == h2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            if(h2 > h1)
            {   
                int tempo = ((h2 * w - h1 * w) / w);
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
            else if (h1> h2)
            {
                int tempo2 = (24 - h1) + h2;
                Console.WriteLine($"O JOGO DUROU {tempo2} HORA(S)");

            }
        }
    }
}
