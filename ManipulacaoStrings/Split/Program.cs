using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomes = "Joao Augusto Anne Andre Gloria AManda";

            char[] separador = {' '};
            string[] resultado = nomes.Split(separador);

            foreach(string nome in resultado)
            {
                Console.WriteLine(nome + "\n");
            }
        }
    }
}
