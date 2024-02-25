using System;

namespace TempoJogoMinutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            string[] partes = entrada.Split(' ');

            int horaInicial = int.Parse(partes[0]);
            int minutoInicial = int.Parse(partes[1]);
            int horaFinal = int.Parse(partes[2]);
            int minutoFinal = int.Parse(partes[3]);

            int minutosTotais = CalcularMinutosTotais(horaInicial, minutoInicial, horaFinal, minutoFinal);

            if (minutosTotais == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                int horasTotais = minutosTotais / 60;
                minutosTotais %= 60;
                Console.WriteLine($"O JOGO DUROU {horasTotais} HORA(S) E {minutosTotais} MINUTO(S)");
            }
        }

        static int CalcularMinutosTotais(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
        {
            if (horaFinal > horaInicial || (horaFinal == horaInicial && minutoFinal >= minutoInicial))
                return (horaFinal - horaInicial) * 60 + (minutoFinal - minutoInicial);

            return ((24 - horaInicial) + horaFinal) * 60 + (minutoFinal - minutoInicial);
        }
    }
}
