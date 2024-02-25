using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetup.ShowDialog();
        }
    }
}
