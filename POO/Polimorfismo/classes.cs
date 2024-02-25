using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar");

        }

        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine($"Area: {area}");
        }
    }
    public class Circuclo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo");

        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine($"Area do circulo: {area}");
        }
    }
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Retangulo");
            base.Desenhar();

        }
        public override void Area()
        {
            base.Area();
            //Reaproveitou a area la em cima
        }
    }
    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Triangulo");
            base.Desenhar();

        }
        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine($"Area do trinauglo: {area}");
        }
    }
}