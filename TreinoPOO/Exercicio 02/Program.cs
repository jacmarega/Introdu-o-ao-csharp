using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();

            int contCachorro = 0, contGato = 0, contPeixe = 0;
            Console.WriteLine("Qual o nome do animal um: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal um: ");
            a1.Tipo = Console.ReadLine();
            if (a1.Tipo == "Cachorro")
            {
                contCachorro++;
            }
            else if (a1.Tipo == "Gato")
            {
                contGato++;
            }
            else
            {
                contPeixe++;
            }

            Console.WriteLine("Qual o nome do animal 2: ");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal 2: ");
            a2.Tipo = Console.ReadLine();
            if (a2.Tipo == "Cachorro")
            {
                contCachorro++;
            }
            else if (a2.Tipo == "Gato")
            {
                contGato++;
            }
            else
            {
                contPeixe++;
            }

            Console.WriteLine("Qual o nome do animal 3: ");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal 3: ");
            a3.Tipo = Console.ReadLine();
            if (a3.Tipo == "Cachorro")
            {
                contCachorro++;
            }
            else if (a3.Tipo == "Gato")
            {
                contGato++;
            }
            else
            {
                contPeixe++;
            }

            Console.WriteLine("Qual o nome do animal 4: ");
            a4.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal 4: ");
            a4.Tipo = Console.ReadLine();
            if (a4.Tipo == "Cachorro")
            {
                contCachorro++;
            }
            else if (a4.Tipo == "Gato")
            {
                contGato++;
            }
            else
            {
                contPeixe++;
            }

            Console.WriteLine("Qual o nome do animal 5: ");
            a5.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal 5: ");
            a5.Tipo = Console.ReadLine();
            if (a5.Tipo == "Cachorro")
            {
                contCachorro++;
            }
            else if (a5.Tipo == "Gato")
            {
                contGato++;
            }
            else
            {
                contPeixe++;
            }
            Console.WriteLine($"Cachorro: {contCachorro}");
            Console.WriteLine($"Gato: {contGato}");
            Console.WriteLine($"Peixe: {contPeixe}");
        }
    }
}
