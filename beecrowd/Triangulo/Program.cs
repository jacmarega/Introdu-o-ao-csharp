using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros = Console.ReadLine();
            string[] array = numeros.Split(' ');
            
            float a = float.Parse(array[0]);
            float b = float.Parse(array[1]);
            float c = float.Parse(array[2]);

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                float perimetroTriangulo = a + b + c;
                Console.WriteLine($"Perimetro = {perimetroTriangulo:.0}");
            }
            else
            {
                float area = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {area:.0}");
            }

        }
    }
}
