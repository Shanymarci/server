using MySql.Data.MySqlClient;

namespace sql.Data
{
    public class MySqlConnectionFactory
    {
        private readonly string connectionString;

        public MySqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}