using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace JALOKA.Database
{
    public class Connector : IDisposable
    {
        private readonly string connectionString = "Host=localhost;Username=postgres;Password=@Emcc13;Database=JALOKA";
        private NpgsqlConnection connection;

        public Connector()
        {
            connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public void Dispose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}

