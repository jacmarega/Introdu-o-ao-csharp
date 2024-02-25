using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoMediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos alunos? ");
            int numeroAluos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Aluno[] alunos = new Aluno[numeroAluos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Nome do Aluno #{(i+1)}: ");
                string nome = Console.ReadLine();

                Console.Write($"Quantidade de provas do aluno {(i + 1)}: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine("Insira as notas do aluno: " + nome);
                alunos[i].InserirNotas();
            }
            Console.Clear();
            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " +  aluno.Nome);
                Console.Write("Media: " +aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }
            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Media geral dos alunos: "+ resultadoFinal);
            Console.ReadKey();
        }

    }
}
