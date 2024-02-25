using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Metodo tryParse
            int num1;
            if(int.TryParse("1985", out num1)) 
            {
                lblResultado.Text = num1.ToString();
            }
            else
            {
                lblResultado.Text = "Erro na conversao";

            }
            //Metodo ToString
            int num = 120;
            lblResultado.Text = num .ToString("x"); //Mostra em hexadeciaml
            lblResultado.Text = num.ToString();
            lblResultado.Text = num.ToString("000.00");
            lblResultado.Text = Convert.ToString(num);

            //Classe math
            double pi = Math.PI;
            double ee = Math.E;
            double seno = Math.Sin(3);
            double coseno = Math.Cos(3);
            double potencia = Math.Pow(2, 2);
            double raiz = Math.Sqrt(49);
            double arrendondar = Math.Round(148.98);
            double inteiro = Math.Truncate(22.57);
            double floor = Math.Floor(1.5);
            double ceil = Math.Ceiling(54.24);
            lblResultado.Text = pi.ToString();
        }
    }
}
