﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
           // this.Text = "Joao";
            //this.Size = new Size(400, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a form";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na form";
            this.Size = new Size(540, 200);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Tbt do al mosso?";
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.Text = "Supresinha safadinha";
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.Text = "Porra safadinha";

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            btn1.Size = new Size(300, 150);
        }
    }
}
