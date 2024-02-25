using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace termothistreino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acessar a = new acessar();
            if (a.Login("abc123"))
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("AcessoNegado");
            }
        }
    }
}
