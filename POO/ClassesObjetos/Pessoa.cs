using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        //atributos 
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //Metodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {nome} {sobrenome}");

        }
    }
}
