using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaEntreDoisPontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiroPonto = Console.ReadLine();
            string segundoPonto = Console.ReadLine();
            string[] array = primeiroPonto.Split(' ');
            string[] array2 = segundoPonto.Split(' ');

            float x1 = float.Parse(array[0]);
            float y1 = float.Parse(array[1]);
            float x2 = float.Parse(array2[0]);
            float y2 = float.Parse(array2[1]);

            float difX = x2 - x1;
            float difY = y2 - y1;

            double distancia = Math.Sqrt((difX * difX) + (difY * difY));

            Console.WriteLine($"{distancia:.0000}");
        }
    }
}
