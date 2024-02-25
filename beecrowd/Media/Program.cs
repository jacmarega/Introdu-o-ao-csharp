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
            double MEDIA = ((A * 3.5) + (B * 7.5))/11;
            if (MEDIA >10) {
                float MEDIAnova = 10.0F;
                Console.WriteLine($"MEDIA = {MEDIAnova:0.00000}");
            }
            else
            {
                Console.WriteLine($"MEDIA = {MEDIA:0.00000}");

            }
        }
    }
}
