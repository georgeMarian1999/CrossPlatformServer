using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    [Serializable]
    public class DTOBJPart
    {
        public DTOBJPart(int idpart,String nume,int capacitate)
        {
            this.idParticipant = idpart;
            this.Nume = nume;
            this.Capacitate = capacitate;
        }
        [XmlAttribute]
        public int idParticipant { get; set; }
        public String Nume { get; set; }
        public int Capacitate { get; set; }
    }
}
