﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Parte032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(worker.WorkerSupportsCancellation)
            {
                worker.CancelAsync();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i<10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                { 
                    Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString() + "%";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "Cancelado";
            }
            else 
            {
                label1.Text = "100% Concluido";
                progressBar1.Value = 100;
            }
        }
    }
}
