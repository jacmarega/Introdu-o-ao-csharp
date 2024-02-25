using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivosCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCLiente.labelMensagem = labelStatus;
        }

        private void txtarquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar arquivo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtarquivo.Text = dialog.FileName;
            }

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnderecoIP.Text) ||
                string.IsNullOrEmpty(txtPortaHost.Value.ToString()) ||
                txtarquivo.Text == "Selecione a pasta")
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Dados Invalidos";
                return;
            }

            string enderecoIP = txtEnderecoIP.Text;
            int porta = (int)txtPortaHost.Value;
            string nomeArquivo = txtarquivo.Text;
            FTCLiente.EnderecoIP = enderecoIP;
            FTCLiente.PortaHost = porta;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    FTCLiente.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {

                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Erro " + ex.Message;
            }
        }
    }
}
