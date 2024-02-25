using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoMetodosdasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodos m = new metodos();
            string nomeCompleto = m.juntaNome("João", "Augusto");
            Console.WriteLine(nomeCompleto);

            m.cumprimentar("Gabriel");
            m.cumprimentar("Gabriel", 17);

            bool resultadoUm = m.Comparar(100, 50 * 2);
            bool resultadoDois = m.Comparar("Ola", "ola");
            Console.WriteLine(resultadoDois);
            Console.WriteLine(resultadoUm);

        }

    }
}
