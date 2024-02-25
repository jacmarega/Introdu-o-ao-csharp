using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPOO
{
    public class Pessoa
    {
        //Construtores
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;

        }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        //propriedades
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade { get; set; }  

        //metodos

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.Nome}\nIdade: {this.Idade}");
        }

    }
}
