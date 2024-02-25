using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"c:\curso");

            listBox1.Items.Add(info.FullName);
            listBox1.Items.Add(info.Parent);
            listBox1.Items.Add(info.Name);
            listBox1.Items.Add(info.CreationTime);
            listBox1.Items.Add(info.Exists);


        }
    }
}
