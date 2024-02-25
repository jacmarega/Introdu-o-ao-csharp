using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal static class Matematica
    {
        public static int taxa;
        public static int adicionar(int valor)
        {
            return valor + taxa;
        }
        public static int diminuir (int valor)
        {
            return valor - taxa;
        }
    }
}
