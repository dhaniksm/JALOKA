using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JALOKA.Controllers
{
    public class C_Buku
    {
        public void TambahBuku(M_Buku buku)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand("INSERT INTO buku (judul, penulis, penerbit, tahun_terbit, sinopsis, cover) VALUES (@judul, @penulis, @penerbit, @tahun_terbit, @sinopsis, @cover)", db.Connection);
                    cmd.Parameters.AddWithValue("@judul", buku.judul);
                    cmd.Parameters.AddWithValue("@penulis", buku.penulis);
                    cmd.Parameters.AddWithValue("@penerbit", buku.penerbit);
                    cmd.Parameters.AddWithValue("@tahun_terbit", buku.tahun_terbit);
                    cmd.Parameters.AddWithValue("@sinopsis", buku.sinopsis);
                    cmd.Parameters.AddWithValue("@cover", buku.cover ?? (object) DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menambah buku: " + ex.Message);
            }
        }

        public List<M_Buku> AmbilSemua()
        {
            var daftar = new List<M_Buku>();
            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand("SELECT * FROM buku ORDER BY id_buku", db.Connection);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            daftar.Add(new M_Buku
                            {
                                id_buku = reader.GetInt32(0),
                                judul = reader.GetString(1),
                                penulis = reader.GetString(2),
                                penerbit = reader.GetString(3),
                                tahun_terbit = reader.GetInt32(4),
                                cover = reader["cover"] as byte[]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data buku: " + ex.Message);
            }
            return daftar;
        }

        public void EditBuku(M_Buku buku)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand("UPDATE buku SET judul = @judul, penulis = @penulis, penerbit = @penerbit, tahun_terbit = @tahun_terbit, cover = @cover WHERE id_buku = @id_buku", db.Connection);
                    cmd.Parameters.AddWithValue("@id_buku", buku.id_buku);
                    cmd.Parameters.AddWithValue("@judul", buku.judul);
                    cmd.Parameters.AddWithValue("@penulis", buku.penulis);
                    cmd.Parameters.AddWithValue("@penerbit", buku.penerbit);
                    cmd.Parameters.AddWithValue("@tahun_terbit", buku.tahun_terbit);
                    cmd.Parameters.AddWithValue("@cover", buku.cover ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengubah data buku: " + ex.Message);
            }
        }

        public void HapusBuku(int id_buku)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand("DELETE FROM buku WHERE id_buku = @id_buku", db.Connection);
                    cmd.Parameters.AddWithValue("@id_buku", id_buku);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus buku: " + ex.Message);
            }
        }

        public static M_Buku? AmbilDetailBuku(int id_buku)
        {
            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand(@"SELECT id_buku, judul, penulis, penerbit, tahun_terbit, sinopsis, cover FROM buku WHERE id_buku = @id_buku", db.Connection);
                    cmd.Parameters.AddWithValue("@id_buku", id_buku);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new M_Buku
                        {
                            id_buku = reader.GetInt32(0),
                            judul = reader.GetString(1),
                            penulis = reader.GetString(2),
                            penerbit = reader.GetString(3),
                            tahun_terbit = reader.GetInt32(4),
                            sinopsis = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            cover = reader["cover"] as byte[]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil detail buku: " + ex.Message);
            }

            return null;
        }

    }
}
