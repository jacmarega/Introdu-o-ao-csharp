using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius, faren, kelvin;
            Console.Write("Escreva a temperatura em celsius: ");
            celsius = float.Parse(Console.ReadLine());
            faren = ((celsius * 9) + 160) / 5;
            //faren = ((celsius * 9)/ 5) + 32;
            kelvin = celsius + 273.15f;
            Console.WriteLine($"Celsius: {celsius}\nFaren: {faren}\nKelvin: {kelvin}");
            Console.ReadLine();


        }
    }
}
