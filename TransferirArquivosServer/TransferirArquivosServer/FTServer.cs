using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivosServer
{
    internal class FTServer
    {
        static IPEndPoint ipEnd_servidor;
        static Socket sock_Servidor;
        public static string EnderecoIp = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox ListaMensagem;

        public static void IniciarServidor()
        {
            try
            {
                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderecoIp), PortaHost);

                sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock_Servidor.Bind(ipEnd_servidor);
            }
            catch (Exception ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao iniciar servidor: "+ ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
                return;
            }
            try
            {
                sock_Servidor.Listen(100);
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Servidor em atendimento e aguardando para receber arquivos");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));

                Socket clienteSock = sock_Servidor.Accept();
                clienteSock.ReceiveBufferSize = 16384;

                byte[] dadosCliente = new byte[1024 * 50000];
                int tamanhoByteRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArqivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                BinaryWriter bWriter = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArqivo, FileMode.Append));
                bWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoByteRecebidos - 4 - tamanhoNomeArquivo);
                while (tamanhoByteRecebidos > 0)
                {
                    tamanhoByteRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                    if (tamanhoByteRecebidos == 0)
                    {
                        bWriter.Close();
                    }
                    else
                    {
                        bWriter.Write(dadosCliente, 0, tamanhoByteRecebidos);
                    }
                    ListaMensagem.Invoke(new Action(() =>
                    {
                        ListaMensagem.Items.Add("Arquivo recebido "+ nomeArqivo);
                        ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                    }));
                    bWriter.Close();
                    clienteSock.Close();
                }
            }
            catch (SocketException ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro: " + ex);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }
            finally
            {
                sock_Servidor.Close();
                sock_Servidor.Dispose();
                IniciarServidor();
            }
        }

    }
}
