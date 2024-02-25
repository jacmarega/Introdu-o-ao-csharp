using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);

        bool conectado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if(txtIP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP.");
                txtIP.Focus();
                return;
            }
            try
            {
                //analisa o íp
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text); 
                int portaHost = (int)numPorta.Value;
                //cria uma nova instancia do objeto0 chatservidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);
                //vincula o tratamento de evento statuschanged a mainserver_statuschanged
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);
                //inicia atendimento das conexoes
                mainServidor.IniciaAtendimento();
                //mostra que iniciou
                listalog.Items.Add("Servidor ativo, aguardando usuarios conectarem-se...");
                listalog.SetSelected(listalog.Items.Count - 1, true);
            }
            catch (Exception ex)
            {

                listalog.Items.Add("Erro de conexao: " + ex.Message);
                listalog.SetSelected(listalog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtIP.Enabled = false;
            numPorta.Enabled = false;
            btnStartServer.ForeColor = Color.Red;
            btnStartServer.Text = "Sair";
        }
        public void mainServidor_StatusChanged(object sender, EventArgs e)
        {
            //chama o metodo que atualiza o formulario
            string mensagem = sender as string;

            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { mensagem });
        }
        private void AtualizaStatus(string strMensagem)
        {
            //Atualiza o logo com mensagens
            listalog.Items.Add(strMensagem);
            listalog.SetSelected(listalog.Items.Count - 1, true);
        }
    }
}
