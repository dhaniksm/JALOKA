using System;
using Npgsql;
using JALOKA.Database;
using JALOKA.Models;
using JALOKA.Helpers;

namespace JALOKA.Controllers
{
    public class C_Admin
    {
        public bool Login(M_Admin admin)
        {
            
            if (string.IsNullOrWhiteSpace(admin.id_pustakawan) && string.IsNullOrWhiteSpace(admin.password))
            {
                H_Pesan.Peringatan("ID dan Password tidak boleh kosong.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(admin.id_pustakawan))
            {
                H_Pesan.Peringatan("ID tidak boleh kosong.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(admin.password))
            {
                H_Pesan.Peringatan("Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM admin WHERE id_pustakawan = @id AND password = @pw", db.Connection);
                    cmd.Parameters.AddWithValue("@id", admin.id_pustakawan);
                    cmd.Parameters.AddWithValue("@pw", admin.password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        H_Pesan.Gagal("ID atau Password salah.");
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Login gagal: " + ex.Message);
                return false;
            }
        }
    }
}
