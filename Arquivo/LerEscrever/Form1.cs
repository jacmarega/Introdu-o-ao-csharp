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

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "@c:\teste\file.txt";
            StreamWriter writer = new StreamWriter(path, true);
 
                string linha = txtConteudo.Text;
                writer.WriteLine(linha);

                writer.Flush();
                writer.Dispose();
                writer.Close();
  
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            string path = "@c:\teste\file.txt";
            StreamReader reader = new StreamReader(path, true);

            string txt = reader.ReadToEnd();

            string linha = reader.ReadLine();
            while (linha != null)
            {
                txtConteudo.Text = linha + "\n";
            }
            txtConteudo.Text = txt;

            reader.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "@c:\teste\file.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                byte b = reader.ReadByte();
                txtConteudo.Text += b + " ";

            }

            byte[] conteudo = reader.ReadBytes((int)reader.BaseStream.Length);
           foreach(byte b in conteudo)
            {
                txtConteudo.Text += b;
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "@c:\teste\arquivoNovo.txt";
            FileStream file = File.OpenRead(path);
            BinaryWriter writer= new BinaryWriter(file);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
 }
