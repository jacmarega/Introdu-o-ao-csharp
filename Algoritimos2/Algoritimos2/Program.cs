using System;

class exercicio
{
    int maior = 0;

    public int EncontrarMaior(int i, int i2)
    {
        if (i > i2)
        {
            maior = i;
        }
        else
        {
            maior = i2;
        }

        return maior;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva dois números");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        exercicio p = new exercicio();
        int resultado = p.EncontrarMaior(num1, num2);

        Console.WriteLine($"O maior número é: {resultado}");
    }
}
