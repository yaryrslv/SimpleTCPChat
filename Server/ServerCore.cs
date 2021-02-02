using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class ServerCore
    {
        static TcpListener tcpListener;
        List<ClientCore> clients = new List<ClientCore>();

        protected internal void AddConnection(ClientCore clientObject)
        {

        }
        protected internal void RemoveConnection(string id)
        {
            
        }
        protected internal void Listen()
        {
            
        }
        protected internal void BroadcastMessage(string message, string id)
        {
           
        }
        protected internal void Disconnect()
        {
            
        }
    }
}
