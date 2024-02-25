using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    class Game
    {
        public  int empateContador = 0;
        public  int jogadorContador = 0;
        public  int pcContador = 0;
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("Imagens/PedraJ.png"),
            Image.FromFile("Imagens/TesouraJ.png"),
            Image.FromFile("Imagens/PapelJ.png")
        };

        public Image ImgPC {  get; private set; }
        public Image ImgJogador {  get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPc();

            ImgJogador = images[jogador];
            ImgPC = images[pc];

            if (jogador == pc)
            {
                empateContador++;
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                jogadorContador++;
                return Resultado.Ganhar;
            }
            else 
            { 
                pcContador++;
                return Resultado.Perder;
            }
        }
        private int JogadaPc()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            } else if (mil >= 333 && mil <667)
            {
                return 1;
            }else 
            {
                return 2;
            }
        }
    }
}
