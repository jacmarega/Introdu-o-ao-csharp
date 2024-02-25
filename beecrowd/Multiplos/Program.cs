using System;

class Program
{
    static void Main(string[] args)
    {
        string numeros = Console.ReadLine();
        string[] array = numeros.Split(' ');

        int n1 = int.Parse(array[0]);
        int n2 = int.Parse(array[1]);

        if (n1 % n2 == 0 || n2 % n1 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
