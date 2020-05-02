using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking.Utils
{
    public abstract class ConcurrentServer : AbstractServer
    {
        public ConcurrentServer(string host,int port) : base(host, port)
        {

        }
        protected abstract Thread createWorker(TcpClient client);
        public override void processRequest(TcpClient client)
        {
            Thread tw = createWorker(client);
            tw.Start();
        }
    }
}
