using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Teste");
            comboBox1.Items.AddRange(new object[] { "cabalo", "sla" });


        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.Items.Count.ToString());

            object ITEM = comboBox1.SelectedItem;
            object indice = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();
            comboBox1.Items.RemoveAt(1);
            comboBox1.Items.Insert(1, "joao");
            MessageBox.Show(comboBox1.Items.IndexOf("joao").ToString()) ;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
