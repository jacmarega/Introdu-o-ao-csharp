using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float reajuste, novoSalario, reajustePorcen;
            float salario = float.Parse(Console.ReadLine());

            if(salario <= 400)
            {
                reajustePorcen = 0.15f;
                reajuste = salario * reajustePorcen;
                novoSalario = salario + reajuste;

            }else if(salario <= 800 && salario > 400)
            {
                reajustePorcen = 0.12f;
                reajuste = salario * reajustePorcen;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 1200 && salario > 800)
            {
                reajustePorcen = 0.10f;
                reajuste = salario * reajustePorcen;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 2000 && salario > 1200)
            {
                reajustePorcen = 0.07f ;
                reajuste = salario * reajustePorcen;
                novoSalario = salario + reajuste;
            }
            else
            {
                reajustePorcen = 0.04f;
                reajuste = salario * reajustePorcen;
                novoSalario = salario + reajuste;
            }

            Console.WriteLine($"Novo salario: {novoSalario:.00}");
            Console.WriteLine($"Reajuste ganho: {reajuste:.00}");
            Console.WriteLine($"Em percentual: {reajustePorcen*100} %");
        }
    }
}
