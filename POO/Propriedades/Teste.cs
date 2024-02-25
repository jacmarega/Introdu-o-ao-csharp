using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //definição de um campo
        private string _nome;
        public string sobrenome { get; } = "Marega";
        private int _idade;

        //definição de uma propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Não permitido");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if(_nome != "")
                Console.WriteLine("Bem vindo, "+ _nome);
        }
    }
}
