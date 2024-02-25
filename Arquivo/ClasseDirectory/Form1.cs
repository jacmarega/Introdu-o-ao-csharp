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

namespace ClasseDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso\";

            bool res = Directory.Exists(path + "logan");
            lista.Items.Add(res);
            if (!res)
            {
                Directory.CreateDirectory(path + "logan");
            }
            if (res)
            {
                Directory.Delete(path + "logan");
            }
            if (res)
            {
                Directory.Move(path, path + "logan");
            }
            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                lista.Items.Add(dir);
            }

            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                lista.Items.Add(file);
            }

            string[] drivers = Directory.GetLogicalDrives();
            foreach(string driver in drivers)
            {
                lista.Items.Add(driver);
            }
            DirectoryInfo  info = Directory.GetParent(path);
            string dir = Directory.GetCurrentDirectory();

        }
    }
}
