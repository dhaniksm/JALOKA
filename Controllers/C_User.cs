using System;
using System.Collections.Generic;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;


namespace JALOKA.Controllers
{
    public class C_User : ILogin
    {
        public bool Login(string id, string password)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                H_Pesan.Peringatan("NISN dan Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("SELECT id_user, nama FROM pengguna WHERE nisn = @nisn AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", id);
                cmd.Parameters.AddWithValue("@password", password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id_user = Convert.ToInt32(reader["id_user"]);
                    string nama = reader["nama"].ToString();

                    H_Sesi.AturSesiP(id_user, nama);
                    return true;
                }
                else
                {
                    H_Pesan.Gagal("NISN atau Password salah.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal melakukan login: " + ex.Message);
                return false;
            }
        }

        public bool Register(M_Pengguna user)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"INSERT INTO pengguna (nisn, password, nama, email, nomor_hp, alamat) VALUES (@nisn, @password, @nama, @email, @nomor_hp, @alamat)", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", user.Nisn);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@nama", user.Nama);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@nomor_hp", user.NomorHp);
                cmd.Parameters.AddWithValue("@alamat", user.Alamat);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal melakukan registrasi: " + ex.Message);
                return false;
            }
        }

        public List<M_Pengguna> DaftarPengguna()
        {
            var daftar = new List<M_Pengguna>();
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("SELECT * FROM pengguna ORDER BY id_user ASC", db.Connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new M_Pengguna
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Nisn = reader["nisn"].ToString(),
                        Password = reader["password"].ToString(),
                        Nama = reader["nama"].ToString(),
                        Email = reader["email"].ToString(),
                        NomorHp = reader["nomor_hp"].ToString(),
                        Alamat = reader["alamat"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data pengguna: " + ex.Message);
            }
            return daftar;
        }

        public M_Pengguna AmbilProfil()
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("SELECT * FROM pengguna WHERE id_user = @id_user", db.Connection);
                cmd.Parameters.AddWithValue("@id_user", H_Sesi.IdUser);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new M_Pengguna
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Nisn = reader["nisn"].ToString(),
                        Nama = reader["nama"].ToString(),
                        Email = reader["email"].ToString(),
                        NomorHp = reader["nomor_hp"].ToString(),
                        Alamat = reader["alamat"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data profil: " + ex.Message);
            }

            return null;
        }

        public bool EditPengguna(M_Pengguna user)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"UPDATE pengguna SET nama = @nama, email = @email, nomor_hp = @nomor_hp, alamat = @alamat WHERE nisn = @nisn", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", user.Nisn);
                cmd.Parameters.AddWithValue("@nama", user.Nama);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@nomor_hp", user.NomorHp);
                cmd.Parameters.AddWithValue("@alamat", user.Alamat);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memperbarui data pengguna: " + ex.Message);
                return false;
            }
        }

        public bool HapusPengguna(string nisn)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("DELETE FROM pengguna WHERE nisn = @nisn", db.Connection);
                cmd.Parameters.AddWithValue("@nisn", nisn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus data pengguna: " + ex.Message);
                return false;
            }
        }
    }
}
