using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPOO
{
    internal class Pessoa
    {
        //Atributos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //Metodo simples
        public void cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou o {nome} {sobrenome}");

        }

        //metodos com parametros
        public void idadePessoa(int idade, int ano)
      {
            idade = ano - anoNascimento;
            Console.WriteLine($"Minha idade é: {idade}");
        }

        //parametros por valor e por referencia
        public void aumentar(ref int valor)
        {
            valor += 10;
            Console.WriteLine(valor);

        }
       
    }
}
