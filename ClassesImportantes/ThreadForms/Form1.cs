using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private  delegate void AtulizarControle(Control controle, string propriedade, object valor);
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnCOntador_Click(object sender, EventArgs e)
        {
            if(!t.IsAlive)
            {
                t.Start();
            }
        }
        private void Tarefa()
        {
            while (true)
            {
                // lblResultado.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString());
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
            }
        }
        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtulizarControle d = new AtulizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
