using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Networking.Utils
{
    public abstract class AbstractServer
    {
        private TcpListener server;
        private string host;
        private int port;
        public AbstractServer(string host,int port)
        {
            this.host = host;
            this.port = port;
        }
        public void Start()
        {
            IPAddress address = IPAddress.Parse(host);
            IPEndPoint endPoint = new IPEndPoint(address, port);
            server = new TcpListener(endPoint);
            server.Start();
            while (true)
            {
                Console.WriteLine("Waiting for employees");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Employee connected");
                processRequest(client);
            }
        }
        public abstract void processRequest(TcpClient client);
    }
}
