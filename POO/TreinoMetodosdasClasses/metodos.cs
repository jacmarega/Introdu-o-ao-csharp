using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoMetodosdasClasses
{
    internal class metodos
    {
            
        //metodos com retorno de valores
        public string juntaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + sobrenome;
            return nomeCompleto;
        }
        public void cumprimentar(string nome)
        {

            Console.WriteLine($"OLá {nome}");
        }
        public void cumprimentar(string nome, int hora)
        {

            Console.WriteLine($"OLá {nome}, {hora}");
        }
        public bool Comparar(int numUm, int numDois)
        {
            return numUm == numDois;
        }

        public bool Comparar(string txt, string txtDois)
        {
            return txt == txtDois;
        }
    }
}
    

