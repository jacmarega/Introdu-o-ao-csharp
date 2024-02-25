using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = @"c:\curso\";
            string arquivo = "teste.txt";

            bool res = (!File.Exists(pasta + arquivo));
            label1.Text = res.ToString();

            File.Delete(pasta + arquivo);  

            File.Create(pasta + arquivo).Close();

            File.Copy(pasta + arquivo, pasta + "Copia.txt");
            label1.Text = "Copiado";

            File.Move(pasta + arquivo, pasta + "movido.txt");

            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo");
            label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);

            File
        }
    }
}
