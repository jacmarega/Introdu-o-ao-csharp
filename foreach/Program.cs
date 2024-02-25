using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] nomes = { "Joao", "Gabriel", "Arthur", "Danny" };
            
            foreach (string nome in nomes) 
            {
                Console.WriteLine($"Nome: {nome}");
            }*/

            string[] nomes = { "Joao", "Gabriel", "Maria", "Ana" };
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}

