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
                using var cmd = new NpgsqlCommand("SELECT id_pustakawan, nama_pustakawan FROM admin WHERE id_pustakawan = @id AND password = @pw", db.Connection);
                cmd.Parameters.AddWithValue("@id", admin.IdPustakawan);
                cmd.Parameters.AddWithValue("@pw", admin.Password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string id_pustakawan = reader["id_pustakawan"].ToString();

                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Login gagal: " + ex.Message);
                return false;
            }
        }
    }
}
