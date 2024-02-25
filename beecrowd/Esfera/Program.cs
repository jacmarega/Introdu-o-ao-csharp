using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio = float.Parse(Console.ReadLine());
            double pi = 3.14159;
            double volume = (4 / 3.0) * pi * (Math.Pow(raio, 3));
            Console.WriteLine($"VOLUME = {volume:0.000}");
        }
    }
}
