using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int i = int.Parse(Console.ReadLine());
            i--;
            Console.WriteLine(meses[i]);
        }
    }
}
