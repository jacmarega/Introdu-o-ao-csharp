using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsCompareTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Luccas";
            string nome2 = "Luccas";
            if (nome.Equals(nome2))
             {
                Console.WriteLine("Verdade");
            }
            else
            {
                Console.WriteLine("Mentira");
            }
            Console.WriteLine(nome.CompareTo(nome2).ToString());
        }
    }
}
