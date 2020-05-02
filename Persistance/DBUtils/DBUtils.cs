using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DBUtils
{
    public static class DBUtils
    {


        private static IDbConnection instance = null;

        public static IDbConnection getConnection()
        {
            if (instance == null || instance.State == System.Data.ConnectionState.Closed)
            {
                instance = getNewConnection();
                instance.Open();
            }
            return instance;
        }

        private static IDbConnection getNewConnection()
        {

            return ConnectionFactory.getInstance().createConnection();


        }
    }
    public abstract class ConnectionFactory
    {
        protected ConnectionFactory()
        {
        }

        private static ConnectionFactory instance;

        public static ConnectionFactory getInstance()
        {
            if (instance == null)
            {

                Assembly assem = Assembly.GetExecutingAssembly();
                Type[] types = assem.GetTypes();
                foreach (var type in types)
                {
                    if (type.IsSubclassOf(typeof(ConnectionFactory)))
                        instance = (ConnectionFactory)Activator.CreateInstance(type);
                }
            }
            return instance;
        }

        public abstract IDbConnection createConnection();
    }

    public class SqliteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection()
        {
            Console.WriteLine("creating ... sqlite connection");
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CurseDB"].ConnectionString;
            Console.WriteLine(connectionString);
            return new SqliteConnection(connectionString);


        }
    }
}

