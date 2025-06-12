using System;
using System.Collections.Generic;
using System.Data;
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
            if (string.IsNullOrWhiteSpace(user.nisn) || string.IsNullOrWhiteSpace(user.password))
                throw new ArgumentException("ID Pelajar dan Password tidak boleh kosong.");

            try
            {
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE nisn = @nisn AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", user.nisn);
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
            if (string.IsNullOrWhiteSpace(user.nisn) || string.IsNullOrWhiteSpace(user.password) ||
                string.IsNullOrWhiteSpace(user.nama) || string.IsNullOrWhiteSpace(user.email) ||
                string.IsNullOrWhiteSpace(user.nomor_hp) || string.IsNullOrWhiteSpace(user.alamat))
                throw new ArgumentException("Semua field harus diisi.");

            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand(@"
                    INSERT INTO users (nisn, password, nama, email, nomor_hp, alamat)
                    VALUES (@nisn, @password, @nama, @email, @nomor_hp, @alamat)", db.Connection);

                cmd.Parameters.AddWithValue("@nisn", user.nisn);
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

        public List<M_User> DaftarPengguna()
        {
            var list = new List<M_User>();

            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM users ORDER BY id_user ASC", db.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new M_User
                    {
                        id_user = Convert.ToInt32(reader["id_user"]),
                        nisn = reader["nisn"].ToString(),
                        password = reader["password"].ToString(),
                        nama = reader["nama"].ToString(),
                        email = reader["email"].ToString(),
                        nomor_hp = reader["nomor_hp"].ToString(),
                        alamat = reader["alamat"].ToString()
                    });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data pengguna: " + ex.Message);
            }

            return list;
        }

        public bool UpdateUser(M_User user)
        {
            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand(@"
                    UPDATE users 
                    SET nama = @nama, email = @email, nomor_hp = @nomor_hp, alamat = @alamat
                    WHERE nisn = @nisn", db.Connection);

                cmd.Parameters.AddWithValue("@nisn", user.nisn);
                cmd.Parameters.AddWithValue("@nama", user.nama);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                cmd.Parameters.AddWithValue("@alamat", user.alamat);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui data pengguna: " + ex.Message);
            }
        }

        public bool DeleteUser(string nisn)
        {
            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand("DELETE FROM users WHERE nisn = @nisn", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", nisn);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data pengguna: " + ex.Message);
            }
        }
    }
}
