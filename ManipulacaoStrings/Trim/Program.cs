using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "-5Olá ";
            Console.WriteLine(mensagem.Trim());

            char[] c = { ' ', '-', '5' };
            Console.WriteLine(mensagem.Trim(c));
        }
    }
}
