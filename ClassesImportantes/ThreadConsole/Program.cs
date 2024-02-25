using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
            t.Start();
            t.Join();

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(1000);
            }
            //Console.ReadKey();
        }
        static void Tarefa()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa executada.");
                Thread.Sleep(1000);
            }
        }
    }
}
