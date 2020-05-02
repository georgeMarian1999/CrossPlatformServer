using Model.Model;
using Problem11.Model;
using Protocol;
using DTOAngajat = Model.Model.DTOAngajat;

namespace Networking.ProtocolBuffers
{
    public class Master
    {
        public static Protocol.Response CreateOkResponse()
        {
            Protocol.Response response=new Protocol.Response{Type = Protocol.Response.Types.Type.Ok};
            return response;
        }

        public static Protocol.Response CreateErrorResponse(string text)
        {
            Protocol.Response response = new Protocol.Response
                {Type = Protocol.Response.Types.Type.Error, Error = text};
            return response;
        }

        public static Protocol.Response CreateGetDispCurseResponse(DTOBJCursa[] curse)
        {
            Protocol.Response response = new Protocol.Response {Type = Protocol.Response.Types.Type.GetDispCurse};

            foreach (var VARIABLE in curse)
            {
                Protocol.DTOCursa dtoCursa=new DTOCursa{IdCursa = VARIABLE.IdCursa,Capacitate = VARIABLE.Capacitate,NrInscrisi = VARIABLE.NrInscrisi};
                response.Curse.Add(dtoCursa);
            }

            return response;
        }

        public static Protocol.Response CreateSearchResultRespone(DTOBJPart[] part)
        {
            Protocol.Response response=new Protocol.Response{Type = Protocol.Response.Types.Type.GetSearchResult};
            foreach (var VARIABLE in part)
            {
                Protocol.DTOPart dtoPart=new DTOPart
                {
                    Capacitate = VARIABLE.Capacitate,IdParticipant = VARIABLE
                        .idParticipant,NumePart = VARIABLE.Nume
                };
                response.Part.Add(dtoPart);
            }

            return response;
        }

        public static Protocol.Response CreateNewSubmitResponse(DTOBJCursa[] curse)
        {
            Protocol.Response response=new Protocol.Response{Type = Protocol.Response.Types.Type.NewSubmit};
            foreach (var VARIABLE in curse)
            {
                Protocol.DTOCursa dtoCursa=new DTOCursa
                {
                    Capacitate = VARIABLE.Capacitate,
                    IdCursa = VARIABLE.IdCursa,
                    NrInscrisi = VARIABLE.NrInscrisi
                };
                response.Curse.Add(dtoCursa);
            }
            return response;
        }

        public static Protocol.Response CreateAllTeamResultResponse(string[] teams)
        {
            Protocol.Response response=new Protocol.Response{Type = Protocol.Response.Types.Type.AllTeamResult};
            foreach (var VARIABLE in teams)
            {
                response.Echipe.Add(VARIABLE);
            }

            return response;
        }
        public static DTOAngajat getAngajat(Protocol.Request request)
        {
            DTOAngajat employee=new DTOAngajat(request.Angajat.Username,request.Angajat.Password);
            return employee;
        }

        public static string getTeam(Protocol.Request request)
        {
            string team = request.Team;
            return team;
        }

        public static DTOInfoSubmit getInfoSubmit(Protocol.Request request)
        {
            DTOInfoSubmit dtoInfoSubmit=new DTOInfoSubmit(request.InfoSubmit.Capacitate,request.InfoSubmit.NumeParticipant,request.InfoSubmit.NumeEchipa);
            return dtoInfoSubmit;
        }
    }
}