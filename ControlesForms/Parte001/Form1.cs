using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte001
{
    public partial class lblTItulo : Form
    {
        public lblTItulo()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao #C");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkRed;
        }
    }
}
