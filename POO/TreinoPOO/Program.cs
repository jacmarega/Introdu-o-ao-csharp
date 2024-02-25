using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreinoPOO.Pessoa;

namespace TreinoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.sobrenome = "Marega";
            p1.anoNascimento = 2004;
            int anoNascimento = p1.anoNascimento; 
            int ano = DateTime.Now.Year;
            p1.cumprimentar();
            p1.idadePessoa(anoNascimento, ano);
            

            Pessoa p2 = new Pessoa();
            p2.nome = "Carlos";
            p2.sobrenome = "Mantelli";
            p2.anoNascimento = 2005;
            int anoNascimentoDois = p2.anoNascimento;
            p2.cumprimentar();
            p2.idadePessoa(anoNascimentoDois, ano);

            //Chamar metodo com parametros
            int valor = 100;
            p1.aumentar(ref valor);
        }
    }
}
