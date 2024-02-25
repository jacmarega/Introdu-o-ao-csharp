using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public string VelociadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou");
        }
        public override void Acelarar()
        {
            Console.WriteLine("Acelerou o carro");
        }
    }
}
