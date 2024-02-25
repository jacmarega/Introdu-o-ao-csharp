using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino04
{
    internal class Pessoa
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private DateTime _data;

		public DateTime  Data
		{
			get { return _data; }
			set { _data = value; }
		}
		private float _altura;

		public float Altura
		{
			get { return _altura; }
			set { _altura = value; }
		}

		public void imprimirDados()
		{
            Console.WriteLine($"\nNome: {_nome}");
            Console.WriteLine($"Altura: {_altura}");
            Console.WriteLine($"Data de nascimento: {_data}");
        }
		public void idade()
		{
			int idade = DateTime.Now.Year - _data.Year;
			Console.WriteLine($"Idade: {idade}");
		}
    }
}
