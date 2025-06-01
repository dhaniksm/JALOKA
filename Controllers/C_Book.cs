using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Book
    {
        public bool TambahBuku(M_Book buku)
        {
            try
            {
                using var db = new Connector();
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

        public List<M_Book> DaftarBuku()
        {
            var books = new List<M_Book>();
            try
            {
                using var db = new Connector();
                using var cmd = new NpgsqlCommand("SELECT * FROM books ORDER BY buku_id", db.Connection);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new M_Book
                    {
                        buku_id = Convert.ToInt32(reader["buku_id"]),
                        judul = reader["judul"].ToString(),
                        penulis = reader["penulis"].ToString(),
                        tahun_terbit = Convert.ToInt32(reader["tahun_terbit"])
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan buku: " + ex.Message);
            }

            return books;
        }

        public bool UpdateBuku(M_Book buku)
        {
            try
            {
                using var db = new Connector();
                using var cmd = new NpgsqlCommand("UPDATE books SET title = @title, author = @author, year = @year WHERE id = @id", db.Connection);
                cmd.Parameters.AddWithValue("@title", buku.judul);
                cmd.Parameters.AddWithValue("@author", buku.penulis);
                cmd.Parameters.AddWithValue("@year", buku.tahun_terbit);
                cmd.Parameters.AddWithValue("@id", buku.buku_id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui buku: " + ex.Message);
            }
        }

        public bool HapusBuku(int buku_id)
        {
            try
            {
                using var db = new Connector();
                using var cmd = new NpgsqlCommand("DELETE FROM books WHERE buku_id = @buku_id", db.Connection);
                cmd.Parameters.AddWithValue("@buku_id", buku_id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus buku: " + ex.Message);
            }
        }
    }
}
