using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine());
            int kml = int.Parse(Console.ReadLine());
            
            float distancia = kml * horas;
            float combustivel = distancia / 12;
            Console.WriteLine($"{combustivel:.000}");
        }
    }
}
