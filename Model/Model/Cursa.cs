using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    public class Cursa : Entity<int>

    {
        public Cursa(int id, int capacitate)
        {
            Id = id;
            Capacitate = capacitate;
        }
        [XmlAttribute]
        public int Id { get; set; }
        public int Capacitate { get; set; }


    }
}
