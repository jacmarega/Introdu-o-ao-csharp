using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Joao augusto";
            string nomeFinal = nome.Insert(0, "joao");
            string nomeFinalFinal = nome.Replace('a', 'x');
            Console.WriteLine(nomeFinalFinal);
            Console.ReadKey();
        }
    }
}
