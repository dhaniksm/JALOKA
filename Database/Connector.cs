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
<<<<<<< Updated upstream
        private readonly string connStr = "Host=localhost;Username=postgres;Password=Akugembeng;Database=JALOKA";
=======
        private readonly string connStr = "Host=localhost;Username=postgres;Password=Fahmi77;Database=JALOKA";
>>>>>>> Stashed changes
        private NpgsqlConnection conn;

        public Connector()
        {
            try
            {
                conn = new NpgsqlConnection(connStr);
                conn.Open();
            }

            catch (Exception ex)
            {
                throw new Exception("Gagal memuat database: " + ex.Message);
            }
        }

        public NpgsqlConnection Connection
        {
            get
            {
                if (conn == null || conn.State != ConnectionState.Open)
                
                    throw new Exception ("Koneksi ke database belum dibuka atau telah ditutup.");
                return conn;
            }
        }
        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn?.Dispose();
            }
        }
    }
}

