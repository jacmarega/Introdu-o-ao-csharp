using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeclasComandos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "CLicou no botao X";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            label1.Text = "CLicou no botao Enter";


        }

        private void btnX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                //btnEnter_CLick(sender, EventArgs.Empty)
                btnEnter.PerformClick();
            }
            label1.Text += "- Atraves da tecla backspace.";
        }
        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //btnEnter_CLick(sender, EventArgs.Empty)
                btnEnter.PerformClick();
            }
        }
    }
}
