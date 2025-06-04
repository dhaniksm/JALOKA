using System;
using System.Collections.Generic;
using JALOKA.Database;
using JALOKA.Models;
using Npgsql;

namespace JALOKA.Controllers
{
    public class C_User
    {
        private readonly Connector db = new Connector();
        public bool Login(M_User user)
        {
            if(string.IsNullOrWhiteSpace(user.id_pelajar) || string.IsNullOrWhiteSpace(user.password))
                throw new ArgumentException("ID Pelajar dan Password tidak boleh kosong.");

            try
            {
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE id_pelajar = @id_pelajar AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@id_pelajar", user.id_pelajar);
                cmd.Parameters.AddWithValue("@password", user.password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan login: " + ex.Message);
            }
        }

        public bool Register(M_User user)
        {
            if(string.IsNullOrWhiteSpace(user.id_pelajar) || string.IsNullOrWhiteSpace(user.password) ||
               string.IsNullOrWhiteSpace(user.nama) || string.IsNullOrWhiteSpace(user.email) ||
               string.IsNullOrWhiteSpace(user.nomor_hp) || string.IsNullOrWhiteSpace(user.alamat))
            {
                throw new ArgumentException("Semua field harus diisi.");
            }

            try
            {
                var cmd = new NpgsqlCommand(@"INSERT INTO users (id_pelajar, password, nama, email, nomor_hp, alamat) VALUES (@id_pelajar, @password, @nama, @email, @nomor_hp, @alamat)", db.Connection);
                cmd.Parameters.AddWithValue("@id_pelajar", user.id_pelajar);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@nama", user.nama);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                cmd.Parameters.AddWithValue("@alamat", user.alamat);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan registrasi: " + ex.Message);
            }
        }

        public List<M_User> DaftarPegguna()
        {
            var list = new List<M_User>();
            {
                var cmd = new NpgsqlCommand("SELECT * FROM users", db.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new M_User
                    {
                        id_pelajar = reader["id_pelajar"].ToString(),
                        password = reader["password"].ToString(),
                        nama = reader["nama"].ToString(),
                        email = reader["email"].ToString(),
                        nomor_hp = reader["nomor_hp"].ToString(),
                        alamat = reader["alamat"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
