using Model.Model;
using Problem11;
using Problem11.Model;
using Problem11.Service;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImplementation
{
    public class ServicesImplementation : IServices
    {
        private Service service;
        private readonly IDictionary<string, Observer> loggedEmployees;


        public ServicesImplementation(Service service1)
        {
            this.service = service1;
            loggedEmployees = new Dictionary<String, Observer>();
        }
        public DTOBJCursa[] getCurrentRaces()
        {
            List<DTOBJCursa> curseDisp = this.service.GroupByCapacitate();
            return curseDisp.ToArray();
        }

        public void login(DTOAngajat angajat, Observer client)
        {
            bool isEmployee = this.service.LocalLogin(angajat.Username, angajat.Password);
            
            if (isEmployee)
            {
                if (loggedEmployees.ContainsKey(angajat.Username))
                {
                    throw new ServerException("User is already logged in");
                }
                loggedEmployees[angajat.Username] = client;

            }
            else throw new ServerException("Authentication failed! Wrong username or password");
        }

        public void logout(DTOAngajat angajat, Observer client)
        {
            Observer local = loggedEmployees[angajat.Username];
            if (local == null)
            {
                throw new ServerException("User is not logged in");
            }
            loggedEmployees.Remove(angajat.Username);
        }

        public DTOBJPart[] searchbyteam(string team)
        {
            List<DTOBJPart> part = this.service.cautare(team);
            return part.ToArray();
        }

        public void submitInsc(DTOInfoSubmit infoSubmit)
        {
            try
            {
                this.service.InscrirereParticipant(infoSubmit.capacitate, infoSubmit.NumePart, infoSubmit.NumeEchipa);
                Console.WriteLine("New submit saved in database");
                notifyEmployeeSubmitted();
            }catch(ServerException e)
            {
                throw new ServerException("Could not submit"+e);
            }
        }
        public void notifyEmployeeSubmitted()
        {
            List<Angajat> angajats = this.service.getAllEmployees();
            List<DTOBJCursa> noicurse = this.service.GroupByCapacitate();
            DTOBJCursa[] result = noicurse.ToArray();
            Console.WriteLine("Notifiying all employees about the new submit");
            foreach(Angajat a in angajats){
                if (loggedEmployees.ContainsKey(a.User))
                {
                    Observer employee = loggedEmployees[a.User];
                    Task.Run(() => employee.AngajatSubmitted(result));
                }
            }
        }

        public string[] getTeams()
        {
            List<string> echipe = this.service.getAllTeams();
            return echipe.ToArray();
        }
    }
}
