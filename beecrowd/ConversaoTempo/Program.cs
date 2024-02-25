using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());
            int horas = n / 3600;
            int minutos = (n % 3600)/60;
            int segundos = (n%3600) % 60;
            Console.WriteLine(horas+":"+minutos+":"+segundos);
        }
    }
}
