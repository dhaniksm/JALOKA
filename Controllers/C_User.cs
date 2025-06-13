using System;
using System.Collections.Generic;
using System.Data;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;

namespace JALOKA.Controllers
{
    public class C_User
    {
<<<<<<< HEAD
        private readonly Connector db = new Connector();

        // LOGIN
        public bool Login(M_User user)
        {
            if (string.IsNullOrWhiteSpace(user.nisn) || string.IsNullOrWhiteSpace(user.password))
                throw new ArgumentException("NISN dan Password tidak boleh kosong.");

            try
            {
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE nisn = @nisn AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", user.nisn);
                cmd.Parameters.AddWithValue("@password", user.password);
=======
        public bool Login(M_User user)
        {
            if(string.IsNullOrWhiteSpace(user.id_user) || string.IsNullOrWhiteSpace(user.password))
                throw new ArgumentException("ID Pelajar dan Password tidak boleh kosong.");

            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE id_user = @id_user AND password = @password", db.Connection);
                    cmd.Parameters.AddWithValue("@id_user", user.id_user);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                } ;
>>>>>>> Dhani

            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan login: " + ex.Message);
            }
        }

        // REGISTER
        public bool Register(M_User user)
        {
<<<<<<< HEAD
            if (string.IsNullOrWhiteSpace(user.nisn) || string.IsNullOrWhiteSpace(user.password) ||
                string.IsNullOrWhiteSpace(user.nama) || string.IsNullOrWhiteSpace(user.email) ||
                string.IsNullOrWhiteSpace(user.nomor_hp) || string.IsNullOrWhiteSpace(user.alamat))
                throw new ArgumentException("Semua field harus diisi.");

=======
            if (string.IsNullOrWhiteSpace(user.id_user) || string.IsNullOrWhiteSpace(user.password) ||
               string.IsNullOrWhiteSpace(user.nama) || string.IsNullOrWhiteSpace(user.email) ||
               string.IsNullOrWhiteSpace(user.nomor_hp) || string.IsNullOrWhiteSpace(user.alamat))
                throw new ArgumentException("Semua field harus diisi."); 
>>>>>>> Dhani
            



            try
            {
<<<<<<< HEAD
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
=======
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand(@"INSERT INTO users (id_user, password, nama, email, nomor_hp, alamat) VALUES (@id_user, @password, @nama, @email, @nomor_hp, @alamat)", db.Connection);
                    cmd.Parameters.AddWithValue("@id_user", user.id_user);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@nama", user.nama);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                    cmd.Parameters.AddWithValue("@alamat", user.alamat);
                    return cmd.ExecuteNonQuery() > 0;
                }
>>>>>>> Dhani
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Gagal Melakukan Registrasi" + ex.Message);
            }
        }

        // BACA SEMUA DATA
        public List<M_User> DaftarPengguna()
        {
            var list = new List<M_User>();

            try
            {
<<<<<<< HEAD
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM users ORDER BY id_user ASC", db.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
=======
                using(var db = new D_Connector())
>>>>>>> Dhani
                {
                    var cmd = new NpgsqlCommand("SELECT * FROM users", db.Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
<<<<<<< HEAD
                        id_user = Convert.ToInt32(reader["id_user"]),
                        nisn = reader["nisn"].ToString(),
                        password = reader["password"].ToString(),
                        nama = reader["nama"].ToString(),
                        email = reader["email"].ToString(),
                        nomor_hp = reader["nomor_hp"].ToString(),
                        alamat = reader["alamat"].ToString()
                    });
=======
                        list.Add(new M_User
                        {
                            id_user = reader["id_user"].ToString(),
                            password = reader["password"].ToString(),
                            nama = reader["nama"].ToString(),
                            email = reader["email"].ToString(),
                            nomor_hp = reader["nomor_hp"].ToString(),
                            alamat = reader["alamat"].ToString()
                        });
                    }
>>>>>>> Dhani
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data pengguna: " + ex.Message);
            }

            return list;
        }

        // AMBIL PROFIL PENGGUNA LOGIN
        public M_User GetProfil(string nisn)
        {
            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM users WHERE nisn = @nisn", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", nisn);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var user = new M_User
                    {
                        id_user = Convert.ToInt32(reader["id_user"]),
                        nisn = reader["nisn"].ToString(),
                        nama = reader["nama"].ToString(),
                        email = reader["email"].ToString(),
                        nomor_hp = reader["nomor_hp"].ToString(),
                        alamat = reader["alamat"].ToString()
                    };
                    reader.Close();
                    return user;
                }

                reader.Close();
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data profil: " + ex.Message);
            }
        }

        // EDIT
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

        // HAPUS
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
