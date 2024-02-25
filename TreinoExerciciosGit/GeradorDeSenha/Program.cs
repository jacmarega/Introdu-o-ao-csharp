using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {   inicio:
            string caracteres = "abcdefghijklmnopqwyxz1234567890ABCDEFGHIJKLMNOQPWYZX";

            Console.WriteLine("Qual o tamanho da senha que voce quer?");
            int tamanho = int.Parse(Console.ReadLine());
            char[] charsArray = new char[tamanho];

            Random random = new Random();
            for (int i= 0; i < charsArray.Length; i ++)
            {
                charsArray[i] = caracteres[random.Next(caracteres.Length)];
            }
            string resultado = new String(charsArray);
            Console.WriteLine(resultado);
            Console.WriteLine("Deseja gerar outra senha?");
            string opcao = Console.ReadLine();
            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                goto inicio;
            }
        }
    }
}
