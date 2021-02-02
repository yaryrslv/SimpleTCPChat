using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class ClientCore
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerCore server;

        public ClientCore(TcpClient tcpClient, ServerCore serverCore)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverCore;
        }
        public void Process()
        {
            
        }
        private string GetMessage()
        {

        }
        protected internal void Close()
        {

        }
    }
}
