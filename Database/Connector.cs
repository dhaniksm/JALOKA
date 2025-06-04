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
<<<<<<< HEAD
<<<<<<< Updated upstream
        private readonly string connStr = "Host=localhost;Username=postgres;Password=Akugembeng;Database=JALOKA";
=======
        private readonly string connStr = "Host=localhost;Username=postgres;Password=Fahmi77;Database=JALOKA";
>>>>>>> Stashed changes
=======
        private readonly string connStr = "Host=localhost;Username=postgres;Password=@Emcc13;Database=JALOKA";
>>>>>>> 48d09d603e55666cd18bade61ae039c3bab64ad6
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

