using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServerException :Exception
    {
        public ServerException() : base()
        {

        }
        public ServerException(string message):base(message) {
        }
        public ServerException(string message,Exception ex) : base(message, ex)
        {

        }
    }
}
