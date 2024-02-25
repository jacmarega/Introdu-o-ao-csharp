using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            c.Acelarar();
            b.Acelarar();
            b.Parar();

            Console.ReadLine();

            //Membros sealed
            Humano a = new Humano();    
            Pessoa d = new Pessoa();    
            Homem e = new Homem();

            Console.WriteLine("\nHUMANO");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            d.Olhos();
            d.Cabelos();

            Console.WriteLine("\nHOMEM");
            e.Olhos();
            e.Cabelos();

            Console.ReadKey();

        }
    }
}
