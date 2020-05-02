using System;
using System.Xml.Serialization;
using Problem11.Model;
namespace Problem11
{
    
        public class Angajat : Entity<int>
        {
            public Angajat(int ID, String user, String pass)
            {
                this.Id = ID;
                this.User = user;
                this.Pass = pass;
            }
            [XmlAttribute]
            public int Id { get; set; }
            public String User { get; set; } = String.Empty;
            public String Pass { get; set; } = String.Empty;


        }
    
}
