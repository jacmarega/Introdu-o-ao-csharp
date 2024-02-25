using System;

class Program
{
    static void Main()
    {
        string inicioDia = Console.ReadLine();
        string inicioHora = Console.ReadLine();
        string fimDia = Console.ReadLine();
        string fimHora = Console.ReadLine();

        // Parse das strings para DateTime
        DateTime inicio = ParseDateTime(inicioDia, inicioHora);
        DateTime fim = ParseDateTime(fimDia, fimHora);

        // Calcula a diferença entre as datas
        TimeSpan duracao = fim - inicio;

        // Exibe a duração em dias, horas, minutos e segundos
        Console.WriteLine($"{duracao.Days} dia(s)");
        Console.WriteLine($"{duracao.Hours} hora(s)");
        Console.WriteLine($"{duracao.Minutes} minuto(s)");
        Console.WriteLine($"{duracao.Seconds} segundo(s)");
    }

    static DateTime ParseDateTime(string data, string hora)
    {
        string[] dataArray = data.Split(' ');
        int dia = int.Parse(dataArray[1]);

        string[] horaArray = hora.Split(':');
        int horaInt = int.Parse(horaArray[0]);
        int minutoInt = int.Parse(horaArray[1]);
        int segundoInt = int.Parse(horaArray[2]);

        return new DateTime(1, 4, dia, horaInt, minutoInt, segundoInt); // O mês é abril (4)
    }
}
