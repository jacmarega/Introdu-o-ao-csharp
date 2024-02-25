using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblCor.BackColor;
            btnCor.BackColor = colorDialog1.Color;
            if()
        }
    }
}
