using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsegunda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSegunda f = new FormSegunda("Bem vindo");

           // f.Mensagem = "Gabriel";
            f.Show();
            f.ShowDialog();
            if(f.Mensagem != null)
            {
                lblprincipal.Text = f.Mensagem;
            }

            this.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(()=> Application.Run(new FormSegunda()));
            t.Start();
        }

        private void mFIle_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form1())).Start();
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();
        }

        private void mFIleSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpSobreDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("João Augusto");
        }

        private void mHelpSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";

            }
            else 
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void menuPesqusisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                lblprincipal.Text = menuPesqusisar.Text;
                menuPesqusisar.Text = "";
            }
        }
    }
}
