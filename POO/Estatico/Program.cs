using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classeestatica
            /*
            Matematica.taxa = 10;

            int valor = Matematica.adicionar(200);
            int valorDois = Matematica.diminuir(10);
            Console.WriteLine(valor);
            Console.WriteLine(valorDois);
            Console.ReadKey();*/
            #endregion

           Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Joao";
            p1.idade = Pessoa.CalcularIdade(2004);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);
            p1.Apresentar();
            Console.ReadKey();

        }
    }
}
