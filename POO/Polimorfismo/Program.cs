using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma a = new Forma();
            a.Altura = 3;
            a.Largura = 4;
            a.Raio = 5;
            Forma b = new Triangulo();
            b.Altura = 3;
            b.Largura = 4;
            Forma c = new Circuclo();
            c.Raio = 5;
            Forma d = new Retangulo();
            d.Altura = 3;
            d.Largura = 4;

            Console.WriteLine("Forma");
            a.Desenhar();
            a.Area();
            Console.WriteLine("Triangulo");
            b.Desenhar();
            b.Area();
            Console.WriteLine("CIrculo");
            c.Desenhar();
            c.Area();

            Console.WriteLine("Retangulo");
            d.Desenhar();
            d.Area();
            Console.ReadKey();

        }
    }
}
