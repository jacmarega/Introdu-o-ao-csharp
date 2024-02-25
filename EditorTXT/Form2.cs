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
    public partial class FormAJuda : Form
    {
        public FormAJuda()
        {
            InitializeComponent();
            webBrowser.Navigate("https://www.google.com.br/?hl=pt-BR");
        }

        private void FormAJuda_Load(object sender, EventArgs e)
        {

        }
    }
}
