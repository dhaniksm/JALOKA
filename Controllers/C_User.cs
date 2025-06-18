using System;
using System.Collections.Generic;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;

namespace JALOKA.Controllers
{
    public class C_User
    {
        public bool Login(M_User user)
        {
            if (string.IsNullOrWhiteSpace(user.nisn) && string.IsNullOrWhiteSpace(user.password))
            {
                H_Pesan.Peringatan("NISN dan Password tidak boleh kosong.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.nisn))
            {
                H_Pesan.Peringatan("NISN tidak boleh kosong.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.password))
            {
                H_Pesan.Peringatan("Password tidak boleh kosong.");
                return false;
            }

            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("SELECT id_user, nama FROM pengguna WHERE nisn = @nisn AND password = @password", db.Connection);
                    cmd.Parameters.AddWithValue("@nisn", user.nisn);
                    cmd.Parameters.AddWithValue("@password", user.password);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id_user = Convert.ToInt32(reader["id_user"]);
                        string nama = reader["nama"].ToString();

                        H_Sesi.SetSession(id_user, nama); // ✅ menyimpan sesi
                        return true;
                    }
                    else
                    {
                        H_Pesan.Gagal("NISN atau Password salah.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal melakukan login: " + ex.Message);
                return false;
            }
        }

        public bool Register(M_User user)
        {
            

            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand(@"
                        INSERT INTO pengguna (nisn, password, nama, email, nomor_hp, alamat) 
                        VALUES (@nisn, @password, @nama, @email, @nomor_hp, @alamat)", db.Connection);

                    cmd.Parameters.AddWithValue("@nisn", user.nisn);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@nama", user.nama);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                    cmd.Parameters.AddWithValue("@alamat", user.alamat);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal melakukan registrasi: " + ex.Message);
                return false;
            }
        }

        public List<M_User> DaftarPengguna()
        {
            var list = new List<M_User>();

            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("SELECT * FROM pengguna ORDER BY id_user ASC", db.Connection);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new M_User
                        {
                            id_user = reader["id_user"].ToString(),
                            nisn = reader["nisn"].ToString(),
                            password = reader["password"].ToString(),
                            nama = reader["nama"].ToString(),
                            email = reader["email"].ToString(),
                            nomor_hp = reader["nomor_hp"].ToString(),
                            alamat = reader["alamat"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data pengguna: " + ex.Message);
            }

            return list;
        }

        public M_User GetProfil(string nisn)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("SELECT * FROM pengguna WHERE nisn = @nisn", db.Connection);
                    cmd.Parameters.AddWithValue("@nisn", nisn);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new M_User
                        {
                            id_user = reader["id_user"].ToString(),
                            nisn = reader["nisn"].ToString(),
                            nama = reader["nama"].ToString(),
                            email = reader["email"].ToString(),
                            nomor_hp = reader["nomor_hp"].ToString(),
                            alamat = reader["alamat"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data profil: " + ex.Message);
            }

            return null;
        }

        public bool UpdateUser(M_User user)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand(@"
                        UPDATE pengguna 
                        SET nama = @nama, email = @email, nomor_hp = @nomor_hp, alamat = @alamat
                        WHERE nisn = @nisn", db.Connection);

                    cmd.Parameters.AddWithValue("@nisn", user.nisn);
                    cmd.Parameters.AddWithValue("@nama", user.nama);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@nomor_hp", user.nomor_hp);
                    cmd.Parameters.AddWithValue("@alamat", user.alamat);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memperbarui data pengguna: " + ex.Message);
                return false;
            }
        }

        public bool DeleteUser(string nisn)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    var cmd = new NpgsqlCommand("DELETE FROM pengguna WHERE nisn = @nisn", db.Connection);
                    cmd.Parameters.AddWithValue("@nisn", nisn);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus data pengguna: " + ex.Message);
                return false;
            }
        }
    }
}
