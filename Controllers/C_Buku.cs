using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Buku
    {
        private readonly Connector db = new Connector();

        public void TabelBuku()
        {
            Tabel.CekTabel(db.Connection, "buku");
        }

        public bool TambahBuku(M_Buku buku)
        {
            try
            {
                using var cmd = new NpgsqlCommand("INSERT INTO books (judul, penulis, tahun_terbit) VALUES (@judul, @penulis, @tahun_terbit)", db.Connection);
                cmd.Parameters.AddWithValue("@judul", buku.judul);
                cmd.Parameters.AddWithValue("@penulis", buku.penulis);
                cmd.Parameters.AddWithValue("@tahun_terbit", buku.tahun_terbit);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan buku: " + ex.Message);
            }
        }

        public List<M_Buku> DaftarBuku()
        {
            var books = new List<M_Buku>();
            try
            {
                using var cmd = new NpgsqlCommand("SELECT * FROM books ORDER BY id_buku", db.Connection);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new M_Buku
                    {
                        id_buku = Convert.ToInt32(reader["id_buku"]),
                        judul = reader["judul"].ToString(),
                        penulis = reader["penulis"].ToString(),
                        tahun_terbit = Convert.ToInt32(reader["tahun_terbit"]),
                        cover_path = reader.IsDBNull(4) ? null : reader.GetString(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan buku: " + ex.Message);
            }

            return books;
        }

        public bool UpdateBuku(M_Buku buku)
        {
            try
            {
                using var cmd = new NpgsqlCommand("UPDATE books SET judul = @judul, penulis = @penulis, tahun = @yahun WHERE id_buku = @id_buku", db.Connection);
                cmd.Parameters.AddWithValue("@id_buku", buku.id_buku);
                cmd.Parameters.AddWithValue("@judul", buku.judul);
                cmd.Parameters.AddWithValue("@penulis", buku.penulis);
                cmd.Parameters.AddWithValue("@tahun", buku.tahun_terbit);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui buku: " + ex.Message);
            }
        }

        public bool HapusBuku(int id_buku)
        {
            try
            {
                using var cmd = new NpgsqlCommand("DELETE FROM books WHERE buku_id = @buku_id", db.Connection);
                cmd.Parameters.AddWithValue("@buku_id", id_buku);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus buku: " + ex.Message);
            }
        }
    }
}
