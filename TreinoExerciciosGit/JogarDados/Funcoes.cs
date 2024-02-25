using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarDados
{
    internal class Funcoes
    {
        public static string JogadorUm;
        public static string JogadorDois;
        public static int PontosJogadorUm;
        public static int PontosJogadorDois;
        public static int empates;
        public static int RodadaAtual;
        public static void ConfigurarJogo()
        {
            RodadaAtual = 0;
            CriarJogadores();
            AtualizarPlacar();
        }
        public static void CriarJogadores()
        {
            Console.WriteLine("Digite o nome do primeiro jogador: ");
            JogadorUm = Console.ReadLine();
            PontosJogadorUm = 0;
        voltar:
            Console.WriteLine("Digite o nome do segundo jogador: ");
            JogadorDois = Console.ReadLine();
            if (JogadorDois == JogadorUm)
            {
                Console.WriteLine("Nomes iguais. Volte e digite novamente o nome do jogador 2.");
                goto voltar;
            }
            PontosJogadorDois = 0;
        }
        public static void AtualizarPlacar()
        {
            Console.Clear();
            Console.WriteLine($"Pontos do {JogadorUm}: {PontosJogadorUm}");
            Console.WriteLine($"Pontos do {JogadorDois}: {PontosJogadorDois}");
            Console.WriteLine($"Empates: {empates}");
            Console.WriteLine();
        }
        public static void IniciarRodada()
        {
            AtualizarPlacar();
            if (RodadaAtual == 3)
            {
                FinalizarJogo();
                return;
            }
            RodadaAtual++;
            Console.WriteLine($"Rodada {RodadaAtual} iniciada:");
            Console.WriteLine($"Jogador {JogadorUm}, pressione Enterr para jogar o dado...");
            Console.ReadLine();
            int valorDadoJogadorUm = JogarDado();

            Console.WriteLine($"Valor tirado pelo {JogadorUm}:{valorDadoJogadorUm} ");

            Console.WriteLine($"Jogador {JogadorDois}, pressione Enterr para jogar o dado...");
            Console.ReadLine();
            int valorDadoJogadorDois = JogarDado();

            Console.WriteLine($"Valor tirado pelo {JogadorDois}:{valorDadoJogadorDois} ");
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();

            if (valorDadoJogadorUm == valorDadoJogadorDois)
            {
                empates++;
                Console.WriteLine($"Empate entre os jogadores na rodada {RodadaAtual}!\n Pressione enter para continuar jogando.");
            }
            else
            { 
                string vencedor;
                if (valorDadoJogadorUm > valorDadoJogadorDois)
                {
                    vencedor = JogadorUm;
                    PontosJogadorUm++;
                }
                else
                {
                    vencedor = JogadorDois;
                    PontosJogadorDois++;
                }
            Console.WriteLine($"{JogadorUm} tirou o numero {PontosJogadorUm} e o {JogadorDois} tirou o numero {PontosJogadorDois}. {vencedor} ganhou a {RodadaAtual} ");
        }
            IniciarRodada();
    }
        public static int JogarDado()
        {
            Random random = new Random();
            return Convert.ToInt32(random.Next(1, 6));
        }
        public static void FinalizarJogo()
        {
            AtualizarPlacar();
            Console.WriteLine("---------Jogo finalizado--------");
            if(PontosJogadorUm == PontosJogadorDois)
            {
                Console.WriteLine("Empate entre jogadores nas rodadas");
            }
            else if(PontosJogadorUm > PontosJogadorDois)
            {
                Console.WriteLine($"{JogadorUm} venceu com {PontosJogadorUm}");
            }
            else
            {
                Console.WriteLine($"{JogadorDois} venceu com {PontosJogadorDois}");
            }
        }
    }
}
