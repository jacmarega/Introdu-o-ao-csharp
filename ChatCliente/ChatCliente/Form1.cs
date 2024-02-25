using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class btnConectar : Form
    {
        //Trata o nome do ususario
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        //Necessario para atualizar o formulario da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //Necessario para definir o formulario para o estado disconnected de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;

        public btnConectar()
        {
            //Na saida da aplicação : desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se nao esta conectado aguarda a conexao
            if (!Conectado)
            {
                InicilizarConexao();

            }
            else
            {
                FechaConexao("Descontado a pedido do usuario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void txtLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se pressionou a tecla enter
            if(e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        private void btnConectar_Load(object sender, EventArgs e)
        {

        }

        private void InicilizarConexao()
        {
            try
            {
                //Trta o endereco iP INFORMADO EM UM objeto ipadress
                enderecoIP = IPAddress.Parse(txtServidorIP.Text);
                //trata valor da porta host
                portaHost = (int)numPortaHost.Value;
                //inicia uma nova conexao tcp com o chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);

                //AJUDA A VERIFICAR SE ESTAMOS CONECTADOS OUNAO
                Conectado = true;

                //prepara formulario
                NomeUsuario = txtUsuario.Text;

                //desbilita e habilita campos apropriados
                txtServidorIP.Enabled = false;
                numPortaHost.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnenviar.Enabled = true;
                btconectar.ForeColor = Color.Red;
                btconectar.Text = "Desconectar";

                //envia o nome do usuario ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtUsuario.Text);
                stwEnviador.Flush();

                //inicia a trhead de mensagens
                mensagemThread = new Thread(new ThreadStart(ReceberMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Conectado ao servidor de chat {enderecoIP}:{portaHost}";
                }));
            }
            catch (Exception ex)
            {
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Red;
                    labelStatus.Text = "Erro na conexao com o servidor:" +  ex.Message;
                }));
            }
        }

        private void ReceberMensagens()
        {
            //recebe mensagens do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            //se o primeiro caracter da conexao for 1 é pq conectou com sucesso
            if (ConResposta[0] == '1')
            {
                //atauliza o formulario para ifnormar que ta concetado
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] {"Conectado com sucesso"});

            }
            else
            {
                string motivo = "Ñão conectado";
                //extrai o motivo no 3 caractere
                motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                //atualiza o formulairio com o motivo da falha na conexao
                this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] {motivo});
                //Sai do metodo
                return;
            }
            //While que enquanto estiver conectado le as linhas que chegam do servidor
            while (Conectado)
            {
                //exibe as mensagens no textbox
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
           
            }
        }
        private void AtualizaLog(string strMensagem)
        {
            //anexa o texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");
        }
        private void EnviaMensagem()
        {
            //envia a mensagem para o servidor
            if(txtMensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(txtMensagem.Text);
                stwEnviador.Flush();
                txtMensagem.Lines = null;

            }
            txtMensagem.Text = "";
        }
        private void FechaConexao(string motivo)
        {
            //fecha a conexao com o servidor
            //mostra o motivo do encerramento
            txtLog.AppendText(motivo + "\r\n");
            // habilita e desabilita os controles apropriados no formulario
            txtServidorIP.Enabled = true;
            numPortaHost.Enabled = true;
            txtMensagem.Enabled = false;
            btnenviar.Enabled = false;
            btconectar.ForeColor = Color.Green;
            btconectar.Text = "Conectar";

            //fecha os objetos que abrimos
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            labelStatus.Invoke(new Action(() => 
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = $"Desconectado do servidor do chat {enderecoIP}:{portaHost}";
            }));
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            //tratador do evento da saida da aplicação
            if(Conectado)
            {
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Desconectado do servidor do chat {enderecoIP}:{portaHost}";
                }));
            }
        }
    }
}
