using Model.Model;
using Problem11.Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientCtrl : Observer
    {
        public event EventHandler<UserEventArgs> updateEvent;
        private readonly IServices server;
        private DTOAngajat crtEmpl;

        public ClientCtrl(IServices services)
        {
            this.server = services; 
        }

        protected virtual void OnUserEvent(UserEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
            Console.WriteLine("Update event called");
        }

        public void login(string user,string pass)
        {
            DTOAngajat angajat = new DTOAngajat(user, pass);
            this.server.login(angajat, this);
            Console.WriteLine("Login succeded");
            crtEmpl = angajat;
            Console.WriteLine("Current user {0}", crtEmpl);
        }

        public void logout()
        {
            Console.WriteLine("Ctrl logout");
            this.server.logout(crtEmpl, this);
            crtEmpl = null;
        }

        public List<DTOBJCursa> getCurrent()
        {
            List<DTOBJCursa> result = new List<DTOBJCursa>();
            DTOBJCursa[] curse = this.server.getCurrentRaces();
            foreach(DTOBJCursa c in curse)
            {
                result.Add(c);
            }
            return result;
                
        }

        public List<DTOBJPart> searchByTeam(string team)
        {
            List<DTOBJPart> result = new List<DTOBJPart>();
            DTOBJPart[] part = this.server.searchbyteam(team);
            foreach (DTOBJPart p in part)
            {
                result.Add(p);
            }
            return result;
        }
        public void submit_insc(DTOInfoSubmit infoSubmit)
        {
            this.server.submitInsc(infoSubmit);
            DTOBJCursa[] curse = this.getCurrent().ToArray();
            UserEventArgs userEventArgs = new UserEventArgs(Event.NEW_SUBMIT, curse);
            OnUserEvent(userEventArgs);
        }    
        public void AngajatSubmitted(DTOBJCursa[] curse)
        {
            UserEventArgs userEventArgs = new UserEventArgs(Event.NEW_SUBMIT, curse);
            Console.WriteLine("Submit received");
            OnUserEvent(userEventArgs);
        }
    }
}
