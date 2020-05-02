using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    [Serializable]
    public class DTOBJCursa
    {

        public DTOBJCursa(int idcursa,int capacitate,int nrinscrisi)
        {
            this.IdCursa = idcursa;
            this.Capacitate = capacitate;
            this.NrInscrisi = nrinscrisi;

        }
        [XmlAttribute]
        public int IdCursa { get; set; }
        public int Capacitate { get; set; }
        public int NrInscrisi { get; set; }
    }
}
