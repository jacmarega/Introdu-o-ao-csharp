using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluçõesRomanticas2
{
    internal class Classe
    {
        Random gerador = new Random();
        public string nome;
        public string nomeDois;

        public int Gerar()
        {
            return gerador.Next(1, 11);
        }
    
        public float CalcularProbalidade()
        {
            float probalidade2 = ((float)Gerar() / 10) * 100;
            return probalidade2;
        }
    }
}
