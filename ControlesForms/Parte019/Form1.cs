using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MontarTree();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string node = treeView.SelectedNode.Text;
            MessageBox.Show(node);
        }
        private void MontarTree()
        {
            treeView.BeginUpdate();
            treeView.Nodes.Add("Nomes");
            treeView.Nodes[0].Nodes.Add("Joao");

            treeView.EndUpdate();

        }
    }
}
