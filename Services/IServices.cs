
using Model.Model;
using Problem11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServices
    {
        void login(DTOAngajat angajat, Observer client);
        void logout(DTOAngajat angajat, Observer client);
        void submitInsc(DTOInfoSubmit infoSubmit);
        DTOBJCursa[] getCurrentRaces();
        DTOBJPart[] searchbyteam(string team);
        string[] getTeams();
    }
}
