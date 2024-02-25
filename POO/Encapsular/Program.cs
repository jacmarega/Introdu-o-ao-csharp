﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conta c = new conta();
            c.Cliente = "Gabriel";

            double valor = 100;
            c.Depositar(valor);

            double valor2 = 50;
            c.Sacar(valor2);

            Console.WriteLine($"Cliente: {c.Cliente}");
            Console.WriteLine($"Saldo: {c.Saldo}");

            Console.ReadKey();
        }
    }
}
