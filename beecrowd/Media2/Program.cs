using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double MEDIA = ((A * 0.2) + (B * 0.3) + (C * 0.5));

                Console.WriteLine($"MEDIA = {MEDIA:0.0}");

        }
    }
}
