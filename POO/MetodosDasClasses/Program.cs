using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          metodos m = new metodos();
            #region Metodo simples
            /* m.Cumprimentar();*/
            #endregion
            #region Metodo com parametros
            /* m.Somar(10, 11);
              m.apresentar("Joao", 19);*/
            #endregion
            #region Metodo com parametros  por valor e referencia.
            /*int valorUm = 100;
            int valorDois = 100;

            m.aumentarValor(valorUm);
            m.aumentarRef(ref valorDois);*/
            #endregion
            #region Metodo com retorno de valores
            /*
            string nomeCompleto =  m.MontaNome("Joao", "Augusto");
            int codigoChar = m.CodigoChar('a');
            double pi = m.ValorPI();
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);*/
            #endregion

            m.Cumprimentar();
            m.Cumprimentar("Gabriel");
            m.Cumprimentar("Gabriel", 18);

            bool resultadoUm =  m.Comparar(100, 50 * 2);
            bool resultadoDois = m.Comparar("Ola", "ola");

            Console.WriteLine(resultadoUm);
            Console.WriteLine(resultadoDois);
            Console.ReadKey();
        }
    }
}
