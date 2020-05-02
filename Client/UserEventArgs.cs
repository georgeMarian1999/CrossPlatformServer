using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{

    public class UserEventArgs
    {
        private readonly Event employeeEvent;
        private readonly Object data;

        public UserEventArgs(Event newEvent,object data1)
        {
            this.employeeEvent = newEvent;
            this.data = data1;
        }

        public Event EventType
        {
            get { return this.employeeEvent; }
        }
        public object Data
        {
            get
            {
                return this.data;
            }
        }

    }
}
