﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i*numero}");
            }
            Console.ReadKey();
        }
    }
}
