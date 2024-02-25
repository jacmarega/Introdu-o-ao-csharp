using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListViewItem item1 = new ListViewItem("Joao");
            item1.SubItems.Add("3434343434");
            item1.SubItems.Add("JOAO@gmaio.com");


            ListViewItem item2 = new ListViewItem("Joao");
            item2.SubItems.Add("3434343434");
            item2.SubItems.Add("JOAO@gmaio.com");


            ListViewItem item3 = new ListViewItem("Joao");
            item3.SubItems.Add("3434343434");
            item3.SubItems.Add("JOAO@gmaio.com");

            ListViewItem item4 = new ListViewItem(new string[] {"Joao", "87468764", "JOAOAUGU@GJFJ"});

            listView.Items.Add(item1);
            listView.Items.Add(item2);
            listView.Items.Add(item3);
            listView.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            listView.Items.Remove(listView.SelectedItems[0]);
            listView.Items.RemoveAt(1);
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView.SelectedItems[0].Text);
        }
    }
}
