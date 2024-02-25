using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MediaGeralPOO
{
    internal class ALuno
    {
        public string Nome {get; private set;}

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public ALuno(string nomeALuno, int qtProvas)
        {
            Nome = nomeALuno;
            _notas = new double[qtProvas];

        }
        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write($"Pode informar a nota de numero {(i+1)}: ");
                _notas[i] = double.Parse(Console.ReadLine());

            }
        }
        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];

            }
            return total / _notas.Length;
        }

    }
}
