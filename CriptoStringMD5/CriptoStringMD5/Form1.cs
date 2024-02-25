using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoStringMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncripto_Click(object sender, EventArgs e)
        {
            CripoMD5 md5 = new CripoMD5();
            txtsaida.Text = md5.RetornarMD5(txtEntradaa.Text);
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            string senhaBanco = "202CB962AC59075B964B07152D234B70";
            string senha = txtEntradaa.Text;

            CripoMD5 md5 = new CripoMD5();
            bool resultado = md5.compararMD5(senha, senhaBanco);
            if (resultado)
            {
                lblresultado.Text = "SENHAS IGUAIS";

            }
            else
            {
                lblresultado.Text = "SENHAS DIFERENTES";
            }
        }
    }
}
