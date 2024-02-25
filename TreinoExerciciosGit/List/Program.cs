using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantos valores deseja calcular: ");
            int qtValores = int.Parse(Console.ReadLine());

            var listaDeValores = ColetarValores(qtValores);
            Console.WriteLine($"A soma dos valores é: {Soma(listaDeValores)}");
            Console.WriteLine($"A media dos valores é: {media(listaDeValores)}");
        }
        static List<decimal> ColetarValores(int qtValores)
        { 
            List<decimal> lista = new List<decimal>();
            for (int i = 0; i < qtValores; i++) {
                 Console.Write($"Informe o valor {(i+1)}: ");
                lista.Add(decimal.Parse(Console.ReadLine()));

            }
            return lista;
        }
        static decimal Soma(List<decimal> lista)
        {
            decimal total = 0;
            foreach (decimal valor in lista) {
            total += valor;
            }
            return total;
        }
        static decimal media(List<decimal> lista) 
        { 
        decimal soma = Soma(lista);
        decimal media = soma / lista.Count;
        return media;
        }
    }
}
