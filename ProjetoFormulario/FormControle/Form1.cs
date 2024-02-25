using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label label1;
        Button btn1;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Location = new Point(100, 50);
            label1.AutoSize = false;
            label1.Size = new Size(500, 200);
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);
            label1.Text = "Minha label";
            

            btn1 = new Button();
            btn1.Location = new Point(250, 285);
            btn1.Size = new Size(200, 60);
            btn1.Text = "Botão código";
            btn1.Font = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);

            btn1.Click += Btn1_Click;

            //btn1.Click += btn1_Click;

            this.Controls.Add(btn1);
            this.Controls.Add(label1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }
        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "Clicou no botão";
        //}
    }
}
