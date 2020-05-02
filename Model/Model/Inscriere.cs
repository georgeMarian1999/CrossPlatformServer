using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    public class Inscriere : Entity<int>
    {
        public Inscriere(int id, int idpart, int idcursa)
        {
            Id = id;
            IdPart = idpart;
            IdCursa = idcursa;
        }
        [XmlAttribute]
        public int Id { get; set; }
        public int IdPart { get; set; }
        public int IdCursa { get; set; }


    }
}
