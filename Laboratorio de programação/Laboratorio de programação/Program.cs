using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_programação
{
    internal class Program
    {

        static void Main(string[] args)
        {
            inicio:
            Console.Write("Qual o nome do responsavél? ");
            string nomeResponsável = Console.ReadLine();

            Console.Write("Qual o nome da criança? ");
            string nomeCrianca = Console.ReadLine();

            Console.Write($"Qual o ano que {nomeCrianca} nasceu? ");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.Write($"Qual o mes que {nomeCrianca} nasceu? ");
            int mesNascimento = int.Parse(Console.ReadLine());
            Console.Write($"Qual o dia que {nomeCrianca} nasceu? ");
            int diaNascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;
            int diferencaAnos = DateTime.Now.Year - anoNascimento;

            if(diferencaAnos < 1 && mesNascimento < 7 && diaNascimento <= 31)
            {
                Console.WriteLine("Não aceitamos crianças com menos de 6 meses");

            } else if(diferencaAnos <= 1 && mesNascimento <= 03 && diaNascimento <=31){
                Console.WriteLine($"Prezado sr(a), a criança {nomeCrianca} será encaminhada para a turma Berçário I");
            
            } else if(diferencaAnos <= 2 && mesNascimento <= 03 && diaNascimento <=31){
                Console.WriteLine($"Prezado sr(a), a criança {nomeCrianca} será encaminhada para a turma Berçário II");
            
            } else if (diferencaAnos <= 3 && mesNascimento <= 03 && diaNascimento <= 31)
            {
                Console.WriteLine($"Prezado sr(a), a criança {nomeCrianca} será encaminhada para a turma Maternal I");
           
            } else if (diferencaAnos <= 4 && mesNascimento <= 03 && diaNascimento <= 31)
            {
                Console.WriteLine($"Prezado sr(a), a criança {nomeCrianca} será encaminhada para a turma Maternal II");
           
            } else
            {
                Console.WriteLine("Aluno deve ser encaminhado para outra escola devido a idade avançada");
            }
            voltar:
            Console.Write("Esolha a operação\n 1.Cadastrar nova criança\n2.Sair\n");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                default:
                    Console.WriteLine("Escolha a opção certa:");
                    goto voltar;
                case 1:
                    goto inicio;
                case 2:
                    break;

            }
            Console.ReadKey();
        }
    }
}
