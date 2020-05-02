using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Serializable]public class DTOInfoSubmit
    {

        public DTOInfoSubmit(int cap,string numepart,string numeechipa)
        {
            this.capacitate = cap;
            this.NumePart = numepart;
            this.NumeEchipa = numeechipa;
        }

        public int capacitate { set; get; }
        public string NumePart { set; get; }
        public string NumeEchipa { set; get; }
    }
}
