using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using Persistance.DBUtils;

namespace Problem11.Repositories
{
    public class AngajatRepository : IAngajatRepository
    {
        public static readonly ILog logger = LogManager.GetLogger("AngajatRepository");

        public AngajatRepository()
        {
           
            logger.Info("Creating the AngajatRepository");
        }

        public void delete(int id)
        {
            logger.InfoFormat("Se sterge angajatul cu id-ul {0}", id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "delete from Angajat where idAngajat=@id";

                IDbDataParameter paramId = com.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                com.Parameters.Add(paramId);
                var result = com.ExecuteNonQuery();
                if (result == 0)
                {
                    logger.Info("Eroare incercand sa se stearga angajatul cu id-ul");
                    throw new Exception("Eroare la stergere");
                }
                logger.InfoFormat("S-a sters angajatul cu id-ul {0}", id);
            }

        }

        public Angajat findOne(int id)
        {
            logger.InfoFormat("Se cauta angajatul cu id-ul {0}", id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "select idAngajat,username,password from Angajat where idAngajat=@id";
                IDbDataParameter paramId = com.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                com.Parameters.Add(paramId);

                using (var Data = com.ExecuteReader())
                {
                    if (Data.Read())
                    {
                        int idAngajat = Data.GetInt32(0);
                        string user = Data.GetString(1);
                        string pass = Data.GetString(2);
                        Angajat Ang = new Angajat(idAngajat, user, pass);
                        logger.InfoFormat("S-a gasit angajatul cu id-ul {0}", Ang.Id);
                        return Ang;
                    }
                }
            }
            logger.InfoFormat("Nu s a gasit angajatul cu id ul {0}", id);
            return null;
        }
        public List<Angajat> findAll()
        {
            logger.Info("Se cauta toti angajatii");
            List<Angajat> result = new List<Angajat>();
            IDbConnection conn = DBUtils.getConnection();
            using(var com = conn.CreateCommand())
            {
                com.CommandText = "select idAngajat,username,password from Angajat";
                using (var Data = com.ExecuteReader())
                {
                    while (Data.Read())
                    {
                        int idAngajat = Data.GetInt32(0);
                        string user = Data.GetString(1);
                        string pass = Data.GetString(2);
                        Angajat Ang = new Angajat(idAngajat, user, pass);
                        result.Add(Ang);
                    }
                }
            }
            return result;
        }

        public bool LocalLogin(string username, string password)
        {
            logger.InfoFormat("Se cauta daca se poate efectua logarea angajatului {0}", username);

            IDbConnection conn = DBUtils.getConnection();

            using(var com = conn.CreateCommand())
            {
                com.CommandText = "select idAngajat from Angajat where username=@user and password=@pass";

                IDbDataParameter user = com.CreateParameter();
                user.ParameterName = "@user";
                user.Value = username;
                com.Parameters.Add(user);

                IDbDataParameter pass = com.CreateParameter();
                pass.ParameterName = "@pass";
                pass.Value = password;
                com.Parameters.Add(pass);

                using(var Data = com.ExecuteReader())
                {
                    if (Data.Read())
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public void save(Angajat entity)
        {
            logger.InfoFormat("Se salveaza angajatul cu id-il {0}", entity.Id);

            IDbConnection conn = DBUtils.getConnection();

            using (var com = conn.CreateCommand())
            {
                com.CommandText = "insert into Angajat values (@idAngajat,@username,@password)";

                IDbDataParameter paramIdAngajat = com.CreateParameter();
                paramIdAngajat.ParameterName = "@idAngajat";
                paramIdAngajat.Value = entity.Id;
                com.Parameters.Add(paramIdAngajat);

                IDbDataParameter paramUser = com.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = entity.User;
                com.Parameters.Add(paramUser);

                IDbDataParameter paramPass = com.CreateParameter();
                paramPass.ParameterName = "@password";
                paramPass.Value = entity.Pass;
                com.Parameters.Add(paramPass);

                var result = com.ExecuteNonQuery();
                if (result == 0)
                {
                    logger.Info("Error while adding");
                    throw new Exception("Niciun angajat adaugat!");
                }

            }
            logger.InfoFormat("A fost adaugat angajatul cu id-ul {0}", entity.Id);
        }


    }
}
