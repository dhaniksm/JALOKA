using System;
using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using JALOKA.Helpers;


namespace JALOKA.Controllers
{
    public class C_Kurikulum : ILogin
    {
        private readonly D_Connector db = new D_Connector();

        public bool Login(string id, string password)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                H_Pesan.Peringatan("ID dan Password tidak boleh kosong.");
                return false;
            }

            try
            {
                if (db.Connection.State != System.Data.ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM kurikulum WHERE id_kurikulum = @id_kurikulum AND password = @password",
                    db.Connection);
                cmd.Parameters.AddWithValue("@id_kurikulum", id);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    H_Pesan.Gagal("ID atau Password salah.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal login: " + ex.Message);
                return false;
            }
        }
    }
}
