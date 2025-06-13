using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JALOKA.Helpers;
using Npgsql;

namespace JALOKA.Database
{
    public class D_Connector : IDisposable
    {
        private readonly string connStr = "Host=localhost;Username=postgres;Password=@Emcc13;Database=JALOKA";
        private NpgsqlConnection conn;

        public D_Connector()
        {
            try
            {
                conn = new NpgsqlConnection(connStr);
                conn.Open();
            }

            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat database: " + ex.Message);
            }
        }

        public NpgsqlConnection Connection
        {
            get
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    H_Pesan.Peringatan("Koneksi ke database belum dibuka atau telah ditutup.");
                }
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

