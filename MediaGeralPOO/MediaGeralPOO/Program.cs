using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "##Media Geral dos alunos##";

            Console.Write("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ALuno[] alunos = new ALuno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Aluno #{(i + 1)} Nome..:");
                string nome = Console.ReadLine();

                Console.Write($"Aluno #{(i + 1)} Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new ALuno(nome, provas);

                Console.Write("Insira as notas do aluno" + nome);
                alunos[i].InserirNotas();
            }
            Console.Clear();
            double mediaGeral = 0;

            foreach (ALuno aluno in alunos)
            {
                Console.WriteLine("Aluno: "+ aluno.Nome);
                Console.WriteLine("Aluno: " + aluno.Media);

                Console.WriteLine();
                mediaGeral += aluno.Media;

            }

            double resultadoFInal = mediaGeral / alunos.Length;

            Console.WriteLine("Media Geral dos alunos: " + resultadoFInal);
            
            Console.ReadKey();
        }
    }
}
