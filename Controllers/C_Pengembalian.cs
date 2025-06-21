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
            try
            {
                var daftar = new List<M_Peminjaman>();
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, b.judul, p.tanggal_pinjam, p.tanggal_kembali FROM peminjaman p  JOIN buku b ON p.id_buku = b.id_buku WHERE p.id_user = @id_user AND p.status = 'dipinjam'", db.Connection);
                cmd.Parameters.AddWithValue("@id_user", H_Sesi.IdUser);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new M_Peminjaman
                    {
                        IdPeminjaman = reader.GetInt32(0),
                        JudulBuku = reader.GetString(1),
                        TanggalPinjam = reader.GetDateTime(2),
                        TanggalKembali = reader.GetDateTime(3),
                    });
                }
                return daftar;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil data peminjaman: " + ex.Message);
                return new List<M_Peminjaman>();
            }
        }

        public void AjukanPengembalian(int id_peminjaman)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("UPDATE peminjaman SET status = 'menunggu pengembalian' WHERE id_peminjaman = @id_peminjaman", db.Connection);
                cmd.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengajukan pengembalian: " + ex.Message);
            }
        }

        public List<M_Peminjaman> DaftarPengembalian()
        {
            try
            {
                var daftar = new List<M_Peminjaman>();
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, u.nama, b.judul, p.tanggal_pinjam, p.tanggal_kembali FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku JOIN pengguna u ON u.id_user = p.id_user WHERE p.status = 'menunggu pengembalian'", db.Connection);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new M_Peminjaman
                    {
                        IdPeminjaman = reader.GetInt32(0),
                        NamaUser = reader.GetString(1),
                        JudulBuku = reader.GetString(2),
                        TanggalPinjam = reader.GetDateTime(3),
                        TanggalKembali = reader.GetDateTime(4)
                    });
                }
                return daftar;
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil daftar pengembalian: " + ex.Message);
                return new List<M_Peminjaman>();
            }
        }

        public void KonfirmasiPengembalian(int id_peminjaman)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@"UPDATE peminjaman SET status = 'dikembalikan', tanggal_dikembalikan = CURRENT_DATE, dikonfirmasi_oleh = @id_pustakawan WHERE id_peminjaman = @id_peminjaman", db.Connection);
                cmd.Parameters.AddWithValue("@id_pustakawan", H_Sesi.IdAdmin);
                cmd.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengonfirmasi pengembalian: " + ex.Message);
            }
        }
    }
}
