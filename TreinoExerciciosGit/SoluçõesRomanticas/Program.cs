using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluçõesRomanticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.Title = "##JOGO DO AMOR##";
            Console.Write("Digite um nome: ");
            string nomePessoa = Console.ReadLine();
            Console.Write("Digite o nome do camarada: ");
            string nomeCamarada = Console.ReadLine();
            Console.WriteLine("\n...Calculando a parada...");
            if(nomePessoa == "amanda" && nomeCamarada == "renanmouradotwitter")
            {
                Console.WriteLine("PORRAAAA, EXPLODIU A MAQUINA, VAI DAR CERTO PRA KLHR, PORRA");
            }else if(nomePessoa == "joao" && nomeCamarada == "minhaex")
            {
                Console.WriteLine("Para de ser iludido, otario!");
            }
            Console.WriteLine("\n \n \nDeseja Realizar o jogo do amor novamente? S/N");
            string opcao = Console.ReadLine();
            if(opcao == "S")
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("Aperte qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
