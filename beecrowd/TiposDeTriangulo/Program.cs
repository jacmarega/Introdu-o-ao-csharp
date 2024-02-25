using System;

namespace TiposDeTriangulo
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

            if (a < b + c && b < a + c && c < a + b)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) ||
                    Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) ||
                    Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2) ||
                         Math.Pow(b, 2) > Math.Pow(a, 2) + Math.Pow(c, 2) ||
                         Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
        }
    }
}
