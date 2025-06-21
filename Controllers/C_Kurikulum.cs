using System;
using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using JALOKA.Helpers;

namespace JALOKA.Controllers
{
    public class C_Kurikulum
    {
        public bool Login(M_Kurikulum kurikulum)
        {
            if (string.IsNullOrWhiteSpace(kurikulum.IdKurikulum) || string.IsNullOrWhiteSpace(kurikulum.Password))
            {
                H_Pesan.Peringatan("ID dan Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kurikulum WHERE id_kurikulum = @id_kurikulum AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@id_kurikulum", kurikulum.IdKurikulum);
                cmd.Parameters.AddWithValue("@password", kurikulum.Password);

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
