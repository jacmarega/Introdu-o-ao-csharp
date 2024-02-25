using System;

internal class Program
{
    static void Main(string[] args)
    {
    inicio:
        string entrada = Console.ReadLine();
        string[] array = entrada.Split(' ');

        int codigo1 = int.Parse(array[0]);
        float quantidade = float.Parse(array[1]);

        switch (codigo1)
        {
            default:
                Console.WriteLine("Escolha uma opção válida");
                goto inicio;
            case 1:
                float valor1 = 4.00f * quantidade;
                Console.WriteLine($"Total: R$ {valor1:0.00}");
                break;
            case 2:
                float valor2 = 4.50f * quantidade;
                Console.WriteLine($"Total: R$ {valor2:0.00}");
                break;
            case 3:
                float valor3 = 5.00f * quantidade;
                Console.WriteLine($"Total: R$ {valor3:0.00}");
                break;
            case 4:
                float valor4 = 2.00f * quantidade;
                Console.WriteLine($"Total: R$ {valor4:0.00}");
                break;
            case 5:
                float valor5 = 1.50f * quantidade;
                Console.WriteLine($"Total: R$ {valor5:0.00}");
                break;
        }
    }
}
