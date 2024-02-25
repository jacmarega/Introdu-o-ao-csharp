using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero = 0;
            Console.Write("Digite um numero real: ");
            float.TryParse(Console.ReadLine(), out numero);
            int numeroInt = (int)numero;
            int numeroIntArrendodado = Convert.ToInt32(numero);
            Console.WriteLine($"Você digitou o valor: {numero}");
            Console.WriteLine($"A parte inteira é: {numeroInt}");
            Console.WriteLine($"O valor arrendodado é: {numeroIntArrendodado}");
            Console.ReadKey();


        }
    }
}
