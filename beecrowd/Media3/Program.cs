using System;

internal class Program
{
    static void Main(string[] args)
    {
        string notas = Console.ReadLine();
        string[] array = notas.Split(' ');

        decimal n1 = decimal.Parse(array[0]);
        decimal n2 = decimal.Parse(array[1]);
        decimal n3 = decimal.Parse(array[2]);
        decimal n4 = decimal.Parse(array[3]);

        decimal media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1) / 10;
        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Aluno em exame.");
            decimal exame = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {exame}");
            decimal mediaFinal = (exame + media) / 2;

            if (mediaFinal >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
        }
    }
}
