using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Este tipo de variavel é alfanumerica";
            if (texto.Contains("tipo de v"))
             {
                Console.WriteLine("Contem");

            }
            else
            {
                Console.WriteLine("Não contem");
            }
            //to string

            bool res = true;
            Console.WriteLine(res.ToString());

        }
    }
}
