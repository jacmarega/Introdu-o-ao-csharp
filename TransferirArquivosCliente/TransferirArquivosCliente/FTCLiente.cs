using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;


namespace TransferirArquivosCliente
{
    internal class FTCLiente
    {
        static IPEndPoint IpEnd_cliente;
        static Socket clienteSock_cliente;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static System.Windows.Forms.Label labelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                IpEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                clienteSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

                if (nomeArquivoByte.Length > 50000 * 1024)
                {
                    labelMensagem.Invoke(new Action(() =>
                    {
                        labelMensagem.ForeColor = Color.Red;
                        labelMensagem.Text = "Tamanho maior ue 60 mb";
                    }));
                    return;
                }
                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 0);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                clienteSock_cliente.Connect(IpEnd_cliente);
                clienteSock_cliente.Send(clientData, 0, clientData.Length, 0);
                clienteSock_cliente.Close();

                labelMensagem.Invoke(new Action(() =>
                {
                    labelMensagem.ForeColor = Color.Red;
                    labelMensagem.Text = "Arquivo transferido";

                }));
            }
            catch (Exception ex)
            {
                labelMensagem.Invoke(new Action(() =>
                {
                    labelMensagem.ForeColor = Color.Red;
                    labelMensagem.Text = "Erro: " + ex.Message;

                }));

            }
            finally
            {
                clienteSock_cliente.Disconnect(false);
                clienteSock_cliente.Close();
            }
        }
    }
}
