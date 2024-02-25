using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ola meu amigos");
            //MessageBox.Show("Mensagem a ser impressa", "Titulo da mensagem");
            //DialogResult res = MessageBox.Show("Texto da mensagem", "titulo", MessageBoxButtons.YesNo);
            //if(res == DialogResult.Yes)
            //{
            //    lblResultado.Text = "Clicou em sim";
            //}else if( res == DialogResult.No)
            //{
            //    lblResultado.Text = "Clicou em no";
            //}

            //MessageBox.Show("Mensagem", "titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Mensagem", "titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        private void btnaleatorio_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int valor = random.Next(100);

            lblResultado.Text = valor.ToString();
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
           //lblResultado.Text = TimeSpan.FromMinutes(60).ToString();
           //lblResultado.Text = TimeSpan.TicksPerMillisecond.ToString();

            TimeSpan inicio = new TimeSpan(5, 30, 30);
            TimeSpan fim = new TimeSpan(18, 25, 0);
            TimeSpan intervalo = fim - inicio;



            lblResultado.Text = intervalo.TotalHours.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
           // lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2020, 02).ToString();
           // lblResultado.Text = DateTime.IsLeapYear(2019).ToString();
            lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime data = new DateTime(1985, 01, 10);
            lblResultado.Text = data.AddYears(1).ToString();
            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);//tem como add pelo time span

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color Amarelo = Color.Green;
            Color Cor1 = Color.FromArgb(100, Amarelo);
            Color Cor2 = Color.FromArgb(255, 255, 255, 255);
            Color Cor3 = Color.FromArgb(100, 50, 135);
            Color Cor4 = Color.FromKnownColor(KnownColor.Control);
            Color Cor5 = Color.FromName("DarkRed");


            lblResultado.BackColor = Cor5;
            lblResultado.ForeColor = Cor5;
            
            Color cor6 = lblResultado.BackColor;

            btncolor.BackColor = Cor5;

            lblResultado.ForeColor = Color.LightGreen;
        }

        private void btnAplicattion_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            string exec = Application.ExecutablePath;
            string pasta = Application.StartupPath;

            Application.Restart();
            lblResultado.Text = pasta;
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Arial", 36, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);

            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);
            lblResultado.Text = "Bem vindo ao c#";

            lblResultado.Font = letra;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string meuDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dirAtual = Environment.CurrentDirectory;
            //Environment.NewLine
            string varAmbi = Environment.GetEnvironmentVariable("Path");
            string[] discos = Environment.GetLogicalDrives();
            foreach(string disco in discos)
            {
                lblResultado.Text += "\n" + disco;
            }
            string user = Environment.UserName;
            string dominio = Environment.UserDomainName;
           // lblResultado.Text += varAmbi;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
