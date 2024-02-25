using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Diagnostics.Contracts;

namespace ChatServer
{
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    class Servidor
    {
        //essa hash table armazena os usuarios e as conexoes (
        public static Hashtable htUsuarios = new Hashtable(30); //30 é o limite de usuarios

        public static Hashtable htConexao = new Hashtable(30);//armazea os usuarios e conexoes

        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpClient;
        //o evento e seu argumento ira notificar o formulario quando um usuario se conecta
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;
        
        //o construtor define o endereco ip para aquele retornado pela instanciação do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }
        //Thread ira tratar o escutador das conecoes
        private Thread thrListener;

        private TcpListener tlsCliente;

        bool ServRodando = false;

        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
        {
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);  
            Servidor.htConexao.Add(tcpUsuario, strUsername);
            //informa a nova conexao para todos os usuarios

            EnviaMensagemAdmin(htConexao[tcpUsuario] + "entrou...");

        }
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            if (htConexao[tcpUsuario] != null)
            {
                //primeiro mostra a informação sobre a conexao
                EnviaMensagemAdmin(htConexao[tcpUsuario] + " saiu...");

                //remove usuario da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexao[tcpUsuario]);
                Servidor.htConexao.Remove(tcpUsuario);
            }
        }
        //esse evento é chamado quando queremos disparar o evento status changed
        public static void OneStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;
            if (statusHandler != null)
            {
                //invoca o delegate
                statusHandler(null, e);
            }
        }

        public static void EnviaMensagemAdmin(string mensagem)
        {
            StreamWriter swSenderSender;

            //exibe primeiro na aplicação
            e = new StatusChangedEventArgs("Admin: " + mensagem);
            OneStatusChanged(e);

            //Cria um array de cliente TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpCLientes = new TcpClient[Servidor.htUsuarios.Count];
            //COpia os objetos tcp cliente no array
            Servidor.htUsuarios.Values.CopyTo(tcpCLientes, 0);
            //percorre a lista de clientes tcp
            for (int i = 0; i < tcpCLientes.Length; i++)
            {
                //tenta enviar a mensagem para cada cliente
                try
                {
                    //se a mensagem estiver em branco ou conexao nula sai do if
                    if (mensagem.Trim() == "" || tcpCLientes[i] == null)
                    {
                        continue;
                    }
                    //envia a mensagem para o usuario do laço
                    swSenderSender = new StreamWriter(tcpCLientes[i].GetStream());
                    swSenderSender.WriteLine("Admin: " + mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch (Exception ex)
                {
                    RemoveUsuario(tcpCLientes[i]);
                    
                }
            }
        }
        //envia mensagem para todos os usuarios
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            //primeiro exibe a mensagem na aplicação
            e = new StatusChangedEventArgs(Origem + " disse:" + Mensagem);
            OneStatusChanged(e);

            //cria um array de clientes tcps do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            //copia os objetos TcpCliente no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);
            //percorre a linha de clientes tcp

            for (int i = 0; i< tcpClientes.Length; i++)
            {
                //Tenta enviar uma mensagem para cada cliente
                try
                {
                    //se a mensagem estiver em branco ou conexao nula sai do if
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }
                    //envia a mensagem para o usuario do laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine("Admin: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch (Exception ex)
                {
                    RemoveUsuario(tcpClientes[i]);

                }
            }
        }
        public void IniciaAtendimento()
        {
            try
            {
                //Pega IP
                IPAddress ipLocal = enderecoIP;
                int portalocal = portaHost;
                //cria um objeto TCP listener usando o ip do servidor e porta definidas
                tlsCliente = new TcpListener(ipLocal, portalocal);
                //inicia o tcp listener e escutar as conexoes
                tlsCliente.Start();

                ServRodando = true;
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true;
                thrListener.Start();
            }
            catch (Exception ex)
            {


            }
        }
        private void MantemAtendimento()
        {
            //enquanto servidor estiver rodando
            while (ServRodando)
            {
                //aceita conexao pendente
                tcpClient = tlsCliente.AcceptTcpClient();
                //cria uma nova instancia da conexao
                Conexao newConnection = new Conexao(tcpClient);
            }
        }
    }
}
