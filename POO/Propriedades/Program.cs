﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "João";
            t.Idade = 18;

            Console.WriteLine(t.Nome + t.sobrenome);
            Console.WriteLine(t.Idade);

            Console.ReadKey();
        }
    }
}
