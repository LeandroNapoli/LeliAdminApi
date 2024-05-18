using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace LeliAdminApi.Repository
{
    public abstract class Repository
    {
        protected readonly IDbConnection Connection;

        public Repository(IDbConnection connection)
        {
            Connection = connection;
        }

        protected IDbConnection CreateConnectionLeli()
        {
            var connectionString = string.Format(ConfigurationManager.ConnectionStrings["conexaoLeli"].ConnectionString);
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
