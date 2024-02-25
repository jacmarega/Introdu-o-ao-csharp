using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoMediaGeralPOO
{
    internal class Aluno
    {
        public string Nome {  get; private set; }

        private double[] _notas;
        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }
        public Aluno(string nomeAluno, int qtProvas)
        {
            Nome = nomeAluno;
            _notas = new double[qtProvas]; 
        }
        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.WriteLine($"Nota de numero { (i+1)}: ");
                _notas[i] = double.Parse(Console.ReadLine()); 
            }
        }
        private double CalcularMedia()
        {
            double total = 0;
            for(int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];

            }
            return total /_notas.Length;
        }

    }
}
