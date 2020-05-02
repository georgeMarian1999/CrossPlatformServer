using System;
using System.Data;
using log4net;
using Persistance.DBUtils;
using Problem11.Model;

namespace Problem11.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        public static readonly ILog logger = LogManager.GetLogger("ParticipantRepository");


        public ParticipantRepository()
        {
            logger.Info("Se creeaza Repository Participant");
        }

        public void delete(int id)
        {
            logger.InfoFormat("Se sterge participantul cu id-ul {0}", id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "delete from Participant where idParticipant=@id";

                IDbDataParameter paramId = com.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                com.Parameters.Add(paramId);
                var result = com.ExecuteNonQuery();
                if (result == 0)
                {
                    logger.Info("Eroare incercand sa se stearga participantul cu id-ul");
                    throw new Exception("Eroare la stergere");
                }
                logger.InfoFormat("S-a sters participantul cu id-ul {0}", id);
            }
        }

        public int FindMaxId()
        {
            logger.Info("Se cauta id-ul maxim din Participant");

            IDbConnection conn = DBUtils.getConnection();

            using(var com = conn.CreateCommand())
            {
                com.CommandText = "select max(idParticipant) as maxim from Participant";
                using(var Data= com.ExecuteReader())
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

        public Participant findOne(int id)
        {
            logger.InfoFormat("Se cauta participantul cu id-ul {0}", id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "select idParticipant,nume,idEchipa from Participant where idParticipant=@id";
                IDbDataParameter paramId = com.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                com.Parameters.Add(paramId);

                using (var Data = com.ExecuteReader())
                {
                    if (Data.Read())
                    {
                        int idParticipant = Data.GetInt32(0);
                        string nume = Data.GetString(1);
                        int idEchipa = Data.GetInt32(2);

                        Participant P = new Participant(idParticipant, nume, idEchipa);
                        logger.InfoFormat("S-a gasit participantul cu id-ul {0}", P.Id);
                        return P;
                    }
                }
            }
            logger.InfoFormat("Nu s a gasit participantul cu id ul {0}", id);
            return null;
        }

        public void save(Participant entity)
        {
            logger.InfoFormat("Se salveaza participantul cu id-il {0}", entity.Id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "insert into Participant values (@idParticipant,@nume,@idEchipa)";

                IDbDataParameter paramIdParticipant = com.CreateParameter();
                paramIdParticipant.ParameterName = "@idParticipant";
                paramIdParticipant.Value = entity.Id;
                com.Parameters.Add(paramIdParticipant);

                IDbDataParameter paramNume = com.CreateParameter();
                paramNume.ParameterName = "@nume";
                paramNume.Value = entity.Nume;
                com.Parameters.Add(paramNume);

                IDbDataParameter paramidEchipa = com.CreateParameter();
                paramidEchipa.ParameterName = "@idEchipa";
                paramidEchipa.Value = entity.IdEchipa;
                com.Parameters.Add(paramidEchipa);

                var result = com.ExecuteNonQuery();
                if (result == 0)
                {
                    logger.Info("Error while adding");
                    throw new Exception("Nici un participant adaugat!");
                }

            }
            logger.InfoFormat("A fost adaugata participantul cu id-ul {0}", entity.Id);
        }

        
    }
}
