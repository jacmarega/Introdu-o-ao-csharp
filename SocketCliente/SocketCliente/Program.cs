using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

                socket.Connect(endPoint);
                Console.WriteLine("Conectado com sucesso");
                Console.WriteLine("Insira uma informção");
                Console.WriteLine();
                string info = Console.ReadLine();
                byte[] infoenviar = Encoding.Default.GetBytes(info);

                socket.Send(infoenviar, 0, infoenviar.Length, SocketFlags.None);
            }
            catch (Exception)
            {
                Console.WriteLine("Nao foi possivel conectar no servidor...");
            }

            socket.Close();
            Console.WriteLine("Pressione uma tecla para finalizar");
            Console.ReadKey();
        }
    }
}
