using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    public class Echipa : Entity<int>
    {
        public Echipa(int id, String nume)
        {
            Id = id;
            Nume = nume;
        }
        [XmlAttribute]
        public int Id { get; set; }
        public String Nume { get; set; } = String.Empty;

    }
}
