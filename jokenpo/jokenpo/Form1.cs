using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jokenpo
{
    public partial class Form1 : Form
    {
        private Game jogo = new Game();
        public Form1()
        {
            InitializeComponent();
            labelJogador.Visible = false;
            labelpc.Visible = false;
            labelempate.Visible = false;
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnpapel_Click(object sender, EventArgs e)
        {
            StartGame(2);

        }

        private void btntesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);

        }

        private void StartGame(int opcao)
        {
            labelResultado.Visible = false;
            labelJogador.Visible = true;
            labelpc.Visible = true;
            labelempate.Visible = true;

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    pictureBox3.BackgroundImage = Image.FromFile("Imagens/ganhou.png");
                    goto default;
                case Game.Resultado.Perder:
                    pictureBox3.BackgroundImage = Image.FromFile("Imagens/Derrota.png");
                    goto default;
                case Game.Resultado.Empatar:
                    pictureBox3.BackgroundImage = Image.FromFile("Imagens/empate.png");
                    goto default;
                default:
                    picresultado.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
           
            }
            labelempate.Text = $"Empates: {jogo.empateContador}";
            labelpc.Text = $"Pc: {jogo.pcContador}";
            labelJogador.Text = $"Jogador: {jogo.jogadorContador}";
        }
    }
}
