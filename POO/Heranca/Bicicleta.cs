using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Bicicleta : Veiculo
    {
        public void Pedalar()
        {
        }
        public override void Acelarar()
        {
            Console.WriteLine("Acelerou a bicicleta");
        }


    }
}
