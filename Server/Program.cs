using System;
using System.Threading;

namespace Server
{
    class Program
    {
        static ServerCore server;
        static Thread listenThread;
        static void Main(string[] args)
        {
            try
            {
                server = new ServerCore();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start();
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
