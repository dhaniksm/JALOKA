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
            
            if (string.IsNullOrWhiteSpace(admin.IdPustakawan) || string.IsNullOrWhiteSpace(admin.Password))
            {
                H_Pesan.Peringatan("ID atau Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("SELECT id_pustakawan FROM admin WHERE id_pustakawan = @id_pustakawan AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@id_pustakawan", admin.IdPustakawan);
                cmd.Parameters.AddWithValue("@password", admin.Password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string id_pustakawan = reader["id_pustakawan"].ToString();

                    H_Sesi.AturSesiA(id_pustakawan);
                    return true;
                }
                else
                {
                    return false;
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
