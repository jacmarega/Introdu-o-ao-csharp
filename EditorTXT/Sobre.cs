using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            WebBrowser wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            wb.Navigate(Application.StartupPath + @"sobre\index.html");
            this.Controls.Add(wb);
        }

        private void Sobre_Load(object sender, EventArgs e)
        {

        }
    }
}
