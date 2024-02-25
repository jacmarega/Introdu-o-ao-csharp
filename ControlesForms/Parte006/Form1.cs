using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkList.Items.Add("Bike", true);
            checkList.Items.Add("Patins", true);
            checkList.Items.Add("Bike", true);
            label1.Visible = false;
            int qtd = checkList.Items.Count;
            //MessageBox.Show("Quantidade de items: " +qtd);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkList.Items.Clear();
            //checkList.Items.AddRange(new object[] {"Bike", "Teste"});
            //if (checkList.Items.Contains("Moto"))
            //{
            //    MessageBox.Show("Contem");
            //}

            checkList.Items.Remove("Moto");
            checkList.Items.RemoveAt(2);
            checkList.Items.Insert(1, "Teste");

           // var intems = checkList.CheckedItems;
            var intems = checkList.SelectedItems;
            foreach( var item in intems ) {
                MessageBox.Show(" " + item.ToString());
            }
        }

        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = checkList.SelectedIndex.ToString(); 
        }
    }
}
