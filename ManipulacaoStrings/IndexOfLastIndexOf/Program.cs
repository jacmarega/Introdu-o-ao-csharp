using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLastIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Joao marega";

           int indice = nome.IndexOf('a');
           int indice2 = nome.LastIndexOf("a");
            Console.WriteLine(indice);
        }
    }
}
