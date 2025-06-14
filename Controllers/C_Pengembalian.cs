using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Pengembalian
    {
        public List<M_Peminjaman> AmbilPeminjamanAktif()
        {
            var list = new List<M_Peminjaman>();

            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, b.id_buku, b.judul, p.tanggal_pinjam, p.status FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku WHERE p.id_pelajar = @id_pelajar AND p.status = 'aktif'", db.Connection);
                cmd.Parameters.AddWithValue("@id_pelajar", H_Sesi.id_user);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new M_Peminjaman
                    {
                        id_peminjaman = reader.GetInt32(0),
                        id_buku = reader.GetInt32(1),
                        judul = reader.GetString(2),
                        tanggal_pinjam = reader.GetDateTime(3),
                        status = reader.GetString(4)
                    });
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data peminjaman: " + ex.Message);
            }

            return list;
        }

        public void ProsesPengembalian(int id_peminjaman, int id_buku)
        {
            try
            {
                using var db = new D_Connector();

                using (var update = new NpgsqlCommand("UPDATE peminjaman SET status = 'dikembalikan', tanggal_kembali = @tanggal_kembali WHERE id_peminjaman = @id", db.Connection))
                {
                    update.Parameters.AddWithValue("@id", id_peminjaman);
                    update.Parameters.AddWithValue("@tanggal_kembali", DateTime.Now);
                    update.ExecuteNonQuery();
                }

                using (var tambahStok = new NpgsqlCommand("UPDATE buku SET stok = stok + 1 WHERE id_buku = @id", db.Connection))
                {
                    tambahStok.Parameters.AddWithValue("@id", id_buku);
                    tambahStok.ExecuteNonQuery();
                }

                H_Pesan.Sukses("Buku berhasil dikembalikan.");
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengembalikan buku: " + ex.Message);
            }
        }
    }
}
