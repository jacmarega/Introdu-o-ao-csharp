using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Treino03
{
     public class Retangulo
     {
        //metodo construtor
        public Retangulo()
        {
            this.Altura = 0;
            this.baseret = 0;

        }
        //base do retangulo
        private int baseret;

        public int Base
        {
            get { return baseret; }
            set { baseret = value; }
        }

        //altura do retangulo
        private int alturaret;

        public int Altura
        {
            get { return alturaret; }
            set
            {
                if (value >= 0) alturaret = value;
                else alturaret = 0;
            }
        }
        //area do retangulo
        public int Area
        {
            get { return alturaret * baseret; }
        }
        //metodo
        public void ExibeDados()
        {
            Console.WriteLine($"Base: {this.Base}");
            Console.WriteLine($"Base: {this.Altura}");
            Console.WriteLine($"Base: {this.Area}");
        }
    }
}
