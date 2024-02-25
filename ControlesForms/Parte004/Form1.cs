using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            Lista.Items.Add(nome);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object item = Lista.SelectedItem;
            Lista.Items.Remove(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            Lista.Items.Remove(indice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int qtditens = Lista.Items.Count;
            MessageBox.Show("Quantidade de itens:" + qtditens);
        }
    }
}
