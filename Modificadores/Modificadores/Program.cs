﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.nome = "";
            t.sobrenome = "";
            t.metodoUm();
            t.Executar();
        }
    }
}
