using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[] vet = new float[n];

            for (int i = 0; i < n; i++)
            {
                string numero = Console.ReadLine();
                string[] vetor = numero.Split(' ');

                float n1 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
                float n2 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
                float n3 = float.Parse(vetor[2], CultureInfo.InvariantCulture);

                ///primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5./
                float mediaPonderada = (n1 * 2 + n2 * 3 + n3 * 5) /10;
                vet[i] = mediaPonderada;
 
            }
            foreach(float media in vet) 
            {
                Console.WriteLine("{0:f1}", media);
            }
        }
    }
}
