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
        public List<M_Peminjaman> PeminjamanBelumDikembalikan()
        {
            var daftar = new List<M_Peminjaman>();
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, b.judul, p.tanggal_pinjam, p.tanggal_kembali FROM peminjaman p  JOIN buku b ON p.id_buku = b.id_buku WHERE p.id_user = @id_user AND p.status = 'dipinjam'", db.Connection);

            cmd.Parameters.AddWithValue("@id_user", H_Sesi.id_user);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                daftar.Add(new M_Peminjaman
                {
                    id_peminjaman = reader.GetInt32(0),
                    judul_buku = reader.GetString(1),
                    tanggal_pinjam = reader.GetDateTime(2),
                    tanggal_kembali = reader.GetDateTime(3),
                });
            }
            return daftar;
        }

        public void AjukanPengembalian(int id_peminjaman)
        {
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand("UPDATE peminjaman SET status = 'menunggu pengembalian' WHERE id_peminjaman = @id", db.Connection);
            cmd.Parameters.AddWithValue("@id", id_peminjaman);
            cmd.ExecuteNonQuery();
        }

        public List<M_Peminjaman> DaftarPengembalian()
        {
            var daftar = new List<M_Peminjaman>();
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, u.nama, b.judul, p.tanggal_pinjam, p.tanggal_kembali FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku JOIN pengguna u ON u.id_user = p.id_user WHERE p.status = 'menunggu pengembalian'", db.Connection);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                daftar.Add(new M_Peminjaman
                {
                    id_peminjaman = reader.GetInt32(0),
                    nama_user = reader.GetString(1),
                    judul_buku = reader.GetString(2),
                    tanggal_pinjam = reader.GetDateTime(3),
                    tanggal_kembali = reader.GetDateTime(4)
                });
            }
            return daftar;
        }

        public void KonfirmasiPengembalian(int id_peminjaman)
        {
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand(@"UPDATE peminjaman SET status = 'dikembalikan', tanggal_dikembalikan = CURRENT_DATE, dikonfirmasi_oleh = @admin WHERE id_peminjaman = @id", db.Connection);
            cmd.Parameters.AddWithValue("@admin", H_Sesi.id_user);
            cmd.Parameters.AddWithValue("@id", id_peminjaman);
            cmd.ExecuteNonQuery();
        }
    }
}
