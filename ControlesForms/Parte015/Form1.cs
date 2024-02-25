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

namespace Parte015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task parte1 = Task.Factory.StartNew(new Action(()=>
            {
                Thread.Sleep(2000);
                progressBar1.Invoke(new Action(() => progressBar1.Value = 25));
            }));

            Task parte2 = parte1.ContinueWith((x) => {

                Thread.Sleep(2000);
                progressBar1.Invoke(new Action(() => progressBar1.Value = 50));

            });
            Task parte3 = parte2.ContinueWith((x) => {

                Thread.Sleep(2000);
                progressBar1.Invoke(new Action(() => progressBar1.Value = 75));

            });
            Task parte4 = parte3.ContinueWith((x) => {

                Thread.Sleep(2000);
                progressBar1.Invoke(new Action(() => progressBar1.Value = 100));

            });

            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(1000);
                progressBar1.Invoke(new Action(()=> progressBar1.PerformStep()));

            })));
            progressBar1.Maximum = tasks.Count;
            progressBar1.Step = 1;
            
            for(int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Start();
            }

        }
    }
}
