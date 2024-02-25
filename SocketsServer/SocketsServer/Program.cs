﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SocketsServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);

            socket.Bind(endPoint);

            socket.Listen(5);

            Console.WriteLine("Escutando...");

            Socket escutar = socket.Accept();

            byte[] bytes = new byte[255];

            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Cliente falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socket.Close();
            Console.WriteLine("Servidor finalizado \nClique em qualquer tecla pra finalizar");
            Console.ReadKey();


        }
    }
}
