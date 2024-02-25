using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcoes = new Funcoes();
            Funcoes.ConfigurarJogo();
            Funcoes.IniciarRodada();
        }
    }
}
