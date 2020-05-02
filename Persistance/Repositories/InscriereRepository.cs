using System;
using System.Data;
using log4net;
using Persistance.DBUtils;
using Problem11.Model;

namespace Problem11.Repositories
{
    public class InscriereRepository : IInscriereRepository
    {
        public static readonly ILog logger = LogManager.GetLogger("InscriereRepository");


        public InscriereRepository()
        {
            logger.Info("Creating the InscriereRepository");
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public int FindMaxId()
        {
            logger.Info("Se cauta id-ul maxim din Inscriere");

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "select max(idInscriere) as maxim from Inscriere";
                using (var Data = com.ExecuteReader())
                {
                    if (Data.Read())
                    {
                        int id = Data.GetInt32(0);
                        return id;
                    }
                }
            }
            logger.Info("Id ul maxim este 0");
            return 0;
        }

        public Inscriere findOne(int id)
        {
            throw new NotImplementedException();
        }

        public void save(Inscriere entity)
        {
            logger.InfoFormat("Se salveaza Inscrierea cu id-il {0}", entity.Id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "insert into Inscriere values (@idInscriere,@idParticipant,@idCursa)";

                IDbDataParameter paramIdAngajat = com.CreateParameter();
                paramIdAngajat.ParameterName = "@idInscriere";
                paramIdAngajat.Value = entity.Id;
                com.Parameters.Add(paramIdAngajat);

                IDbDataParameter paramidPart = com.CreateParameter();
                paramidPart.ParameterName = "@idParticipant";
                paramidPart.Value = entity.IdPart;
                com.Parameters.Add(paramidPart);

                IDbDataParameter paramidCursa = com.CreateParameter();
                paramidCursa.ParameterName = "@idCursa";
                paramidCursa.Value = entity.IdCursa;
                com.Parameters.Add(paramidCursa);

                var result = com.ExecuteNonQuery();
                if (result == 0)
                {
                    logger.Info("Error while adding");
                    throw new Exception("Nici o inscriere adaugata!");
                }

            }
            logger.InfoFormat("A fost adaugat inscrierea cu id-ul {0}", entity.Id);
        }
    }
}
