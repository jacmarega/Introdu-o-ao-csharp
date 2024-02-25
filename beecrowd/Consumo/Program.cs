using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());

            float consumo = distancia / x;
            Console.WriteLine($"{consumo:.000} km/l");
        }
    }
}
