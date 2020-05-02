using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Serializable]public class DTOAngajat
    {
        
        public DTOAngajat(string user,string pass)
        {
            this.Username = user;
            this.Password = pass;
        }


        public string Username { set; get; }
        public string Password { set; get; }
    }
}
