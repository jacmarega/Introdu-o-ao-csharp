using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthSubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Joao Augusto";
            //int tamanho = nome.Length;
            //Console.WriteLine($"O nome joao contem {tamanho}");
            for ( int i = 0; i < nome.Length; i++ )
            { Console.WriteLine(nome[i]); }
            Console.ReadKey();

            string parte = nome.Substring(0, 3);
            string parte2 = nome.Substring(nome.IndexOf(" "), 3);
            Console.WriteLine(parte);
            Console.WriteLine(parte2);
        }
    }
}
