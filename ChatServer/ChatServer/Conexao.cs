using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    // Classe que trata as conexões
    class Conexao
    {
        private TcpClient tcpCliente;
        private StreamReader swReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private bool conectado;

        // O construtor da classe que recebe a conexão TCP
        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;

            // Inicializa os streams de leitura e escrita
            swReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());
            usuarioAtual = "";

            // Inicia a thread para receber mensagens
            Thread thrReceber = new Thread(new ThreadStart(ReceberMensagens));
            thrReceber.Start();
        }

        // Método para receber mensagens do cliente
        private void ReceberMensagens()
        {
            try
            {
                // Recebe o nome de usuário do cliente
                usuarioAtual = swReceptor.ReadLine();

                if (!string.IsNullOrEmpty(usuarioAtual))
                {
                    if (Servidor.htUsuarios.Contains(usuarioAtual) || usuarioAtual == "Administrador")
                    {
                        // Envia mensagem de erro se o nome de usuário já existe
                        swEnviador.WriteLine("0|Este nome de usuário já existe ou é reservado");
                        swEnviador.Flush();
                        FechaConexao();
                        return;
                    }
                    else
                    {
                        // Adiciona o usuário à lista de usuários do servidor
                        Servidor.IncluiUsuario(tcpCliente, usuarioAtual);

                        // Envia mensagem de sucesso para o cliente
                        swEnviador.WriteLine("1");
                        swEnviador.Flush();
                    }
                }
                else
                {
                    FechaConexao();
                    return;
                }

                conectado = true;

                // Continua recebendo mensagens do cliente
                while (conectado)
                {
                    string mensagem = swReceptor.ReadLine();
                    if (mensagem != null)
                    {
                        // Processa a mensagem recebida
                        Servidor.EnviaMensagem(usuarioAtual, mensagem);
                    }
                    else
                    {
                        // Se a mensagem for nula, considera que o cliente se desconectou
                        conectado = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conexão com o cliente: " + ex.Message);
            }
            finally
            {
                FechaConexao();
            }
        }

        // Método para fechar a conexão
        private void FechaConexao()
        {
            if (tcpCliente != null)
                tcpCliente.Close();
            if (swReceptor != null)
                swReceptor.Close();
            if (swEnviador != null)
                swEnviador.Close();

            // Remove o usuário da lista de usuários do servidor
            Servidor.RemoveUsuario(tcpCliente);

            conectado = false;
        }
    }
}
