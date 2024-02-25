using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();
            Console.Write("Digite o primeiro numero: ");
            float numeroUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            float numeroDois = float.Parse(Console.ReadLine());

            Console.Write("Esolha a operação (+ - x /)");
            char opcao = char.Parse(Console.ReadLine());
            switch(opcao)
            {
                default:
                    Console.Write("Escolha uma opção certa");
                    goto inicio;
                case '+':
                    float resultadoAdicao = numeroUm + numeroDois;
                    Console.WriteLine($"{numeroUm} + {numeroDois} = {resultadoAdicao} ");
                    break;
                case '-':
                    float resultadoSubtracao = numeroUm - numeroDois;
                    Console.WriteLine($"{numeroUm} - {numeroDois} = {resultadoSubtracao} ");
                    break;
                case 'X':
                    float resultadoMultiplicacao= numeroUm * numeroDois;
                    Console.WriteLine($"{numeroUm} X {numeroDois} = {resultadoMultiplicacao} ");
                    break;
                case '/':
                    if ( numeroDois == 0 )
                    {
                        Console.WriteLine("Não é possivel dividir por 0.");
                    }else
                    {
                        float resultadoDivisao = numeroUm * numeroDois;
                        Console.WriteLine($"{numeroUm} / {numeroDois} = {resultadoDivisao} ");
                    }

                    break;

            }
            Console.Write("Continuar calculador? (s/n)? ");
            string opcaoDois = Console.ReadLine();
            if (opcaoDois == "s")
            {
                goto inicio;
            }
            Console.ReadKey();
        }
    }
}
