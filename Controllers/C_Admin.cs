using System;
using Npgsql;
using JALOKA.Database;
using JALOKA.Models;
using JALOKA.Helpers;
using JALOKA.Controllers;

namespace JALOKA.Controllers
{
    public class C_Admin : ILogin
    {
        public bool Login(string id, string password)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                H_Pesan.Peringatan("ID dan Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using var db = new D_Connector();
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM admin WHERE id_pustakawan = @id AND password = @pw", db.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pw", password);

                var result = cmd.ExecuteScalar();

                if (result == null)
                {
                    H_Pesan.Gagal("ID atau Password salah.");
                    return false;
                }

                // ✅ Simpan sesi admin
                string idAdmin = result.ToString();
                H_Sesi.AturSesiA(idAdmin);


                return true;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Login gagal: " + ex.Message);
                return false;
            }
        }
    }
}
