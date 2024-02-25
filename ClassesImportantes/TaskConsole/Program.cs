using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //    Task t = new Task(Tarefa);
            //    t.Start();

            //    Task t2 = Task.Run(Tarefa);

            //    //    Task.Run(Tarefa);

            //    Task.Factory.StartNew(Tarefa);

            //    Task.Run(() => {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.WriteLine("Tarefa do task");
            //        }
            //    });
            //    for(int i = 0;i < 10;i++)
            //    {
            //        Console.WriteLine("Principal");
            //    }
            //}

            /*
            Task[] tasks =
            {
            Task.Factory.StartNew(() => {
            Console.WriteLine("Tarefa 1");
            }),

            Task.Factory.StartNew(() => {
            Console.WriteLine("Tarefa 2");
            }),

            Task.Factory.StartNew(() => {
            Console.WriteLine("Tarefa 3");
            })

        };
            Task.WaitAll(tasks);
            Console.WriteLine("Principal");
            Console.ReadKey();*/
            #endregion

            //Task<int> tarefa1 = new Task.Factory.StartNew(() => dobro(5));

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);

            });
            Task<int> tarefa2 = tarefa1.ContinueWith((num) => {
                return num.Result * 2;

            });
            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return "Valor final " + num.Result;
                }) ;

            Console.WriteLine(tarefa3.Result);
        }
        static int  dobro(int num)
        {
            return num * 2;
        }
            //static private void Tarefa()
            // {
            //      for (int i = 0; i < 10; i++)
            //   {
            //       Console.WriteLine("Tarefa do task");
            //     }
           }
        }
    

