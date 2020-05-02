using System;
using System.Xml.Serialization;

namespace Problem11.Model
{
    public class Participant : Entity<int>
    {
        public Participant(int id, String nume, int idEchipa)
        {
            Id = id;
            Nume = nume;
            IdEchipa = idEchipa;

        }


        [XmlAttribute]

        public int Id { get; set; }

        public String Nume { get; set; } = String.Empty;

        public int IdEchipa { get; set; }


    }
}
