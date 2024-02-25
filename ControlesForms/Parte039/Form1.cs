using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncor_Click(object sender, EventArgs e)
        {
            //colorDialog1.Color = label1.BackColor;
            //btncor.BackColor = colorDialog1.Color;

            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.BackColor = colorDialog1.Color;
                btncor.BackColor = colorDialog1.Color;
            }
        }
    }
}
