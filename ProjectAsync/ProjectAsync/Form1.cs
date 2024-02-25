using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsync
{
    public partial class Form1 : Form
    {
        public static ListBox lstRes;
        public Form1()
        {
            InitializeComponent();
            lstRes = listaResultado;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Exemplo obj = new Exemplo();
            obj.Task_LongDuracao();

            listaResultado.Items.Add("Evento botao foi concluido");
        }

        private async void executarasnyc_Click(object sender, EventArgs e)
        {
            lstRes.Items.Add("Evento do botao foi iniciado");
            ExemploAsync obj = new ExemploAsync();
            await obj.Task_LongaDuracao2();

            listaResultado.Items.Add("Evento do botao foi concluido");
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
        }
    }
}
