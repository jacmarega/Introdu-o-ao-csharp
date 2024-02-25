using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e obejtos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = nul;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion
        
            Pessoa p1 = new Pessoa();
            p1.nome = "Joao";
            p1.sobrenome = "Marega";
            p1.anoNascimento = 2004;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                sobrenome = "Comossato",
                anoNascimento = 2029
            };

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNascimento}");
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine($"Pessoa 1: {p2.nome}");
            Console.WriteLine($"Pessoa 1: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p2.anoNascimento}");
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {


    } 

}
