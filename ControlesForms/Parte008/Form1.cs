﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dia selecioando: " + dateTimePicker1.Value.DayOfWeek);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime atual = DateTime.Now;
            dateTimePicker1.Value = atual;
        }
    }
}
