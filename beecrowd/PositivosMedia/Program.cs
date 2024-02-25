using System;

class URI1060
{
    static void Main(string[] args)
    {

        int positivos = 0;
        double numerospositivos = 0;
        double[] vetor = new double[6];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > 0)
            {
                positivos++;
                numerospositivos += vetor[i];
            }
        }
        double media = numerospositivos/positivos;
        Console.WriteLine(positivos + " valores positivos");
        Console.WriteLine($"{media:.0}");
    }
}