using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(5, 5);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" MEU" );
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" BRASIL ");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" BRASILEIRO ");
            Console.ReadKey();

        }
    }
}
