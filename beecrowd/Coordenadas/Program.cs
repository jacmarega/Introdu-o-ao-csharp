using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pontos = Console.ReadLine();
            string[] array = pontos.Split(' ');

            float ponto1 = float.Parse(array[0]);
            float ponto2= float.Parse(array[1]);

            if (ponto1 >0 && ponto2 >0)
            {
                Console.WriteLine("Q1");
            }
            else if (ponto1 < 0 && ponto2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (ponto1 < 0 && ponto2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (ponto1 > 0 && ponto2 < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(ponto2 == 0 && ponto1 !=0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (ponto1 == 0 && ponto2 !=0)
            {
                Console.WriteLine("Eixo Y");
            }else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
