using System;
using System.Collections.Generic;
using JALOKA.Database;
using JALOKA.Models;
using Npgsql;

namespace JALOKA.Controllers
{
    public class C_User
    {
        public bool Login(string id_pelajar, string password)
        {
            using (var db = new Connector())
            {
                var conn = db.GetConnection();
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE id_pelajar = @id_pelajar AND password = @password", conn);
                cmd.Parameters.AddWithValue("@id_pelajar", id_pelajar);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool Register(M_User user)
        {
            using (var db = new Connector())
            {;
                var conn = db.GetConnection();
                var cmd = new NpgsqlCommand(@"INSERT INTO users (id_pelajar, password, nama, email, nomor_hp, alamat) VALUES (@id_pelajar, @password, @nama, @email, @nomor_hp, @alamat)", conn);
                cmd.Parameters.AddWithValue("@id_pelajar", user.id_pelajar);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@nama", user.nama);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                cmd.Parameters.AddWithValue("@alamat", user.alamat);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<M_User> GetAll()
        {
            var list = new List<M_User>();
            using (var db = new Connector())
            {
                var conn = db.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM users", conn);
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
