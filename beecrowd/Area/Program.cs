using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros= Console.ReadLine();    

            string[] array = numeros.Split(' ');
            double a = double.Parse(array[0]);
            double b = double.Parse(array[1]);
            double c = double.Parse(array[2]);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = Math.Pow(c, 2) * 3.14159;
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIAGULO : {areaTriangulo:0.000}");
            Console.WriteLine($"CIRCULO : {areaCirculo:0.000}");
            Console.WriteLine($"TRAPEZIO : {areaTrapezio:0.000}");
            Console.WriteLine($"QUADRADO : {areaQuadrado:0.000}");
            Console.WriteLine($"RETANGULO : {areaRetangulo:0.000}");

        }
    }
}
