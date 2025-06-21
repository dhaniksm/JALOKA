using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Riwayat
    {
        public List<M_Riwayat> TampilkanRiwayat()
        {
            var riwayat = new List<M_Riwayat>();

            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand(@" SELECT p.id_peminjaman, p.id_buku, b.judul, p.id_user, u.nama, p.tanggal_pinjam, p.tanggal_kembali, p.status FROM peminjaman p JOIN pengguna u ON p.id_user = u.id_user JOIN buku b ON p.id_buku = b.id_buku ORDER BY p.tanggal_pinjam DESC;", db.Connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    riwayat.Add(new M_Riwayat
                    {
                        IdPeminjaman = Convert.ToInt32(reader["id_peminjaman"]),
                        Judul = reader["judul"].ToString(),
                        Nama = reader["nama"].ToString(),
                        TanggalPinjam = Convert.ToDateTime(reader["tanggal_pinjam"]),
                        TanggalKembali = Convert.ToDateTime(reader["tanggal_kembali"]),
                        Status = reader["status"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan riwayat: " + ex.Message);
            }
            return riwayat;
        }
        public List<M_Riwayat> TampilkanRiwayatPengguna(int id_user)
        {
            try
            {
                using var db = new D_Connector();
                var riwayat = new List<M_Riwayat>();
                using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, b.judul, p.tanggal_pinjam, p.tanggal_kembali, p.status FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku WHERE p.id_user = @id_user ORDER BY p.tanggal_pinjam DESC", db.Connection);
                cmd.Parameters.AddWithValue("@id_user", id_user);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    riwayat.Add(new M_Riwayat
                    {
                        IdPeminjaman = Convert.ToInt32(reader["id_peminjaman"]),
                        Judul = reader["judul"].ToString(),
                        TanggalPinjam = Convert.ToDateTime(reader["tanggal_pinjam"]),
                        TanggalKembali = Convert.ToDateTime(reader["tanggal_kembali"]),
                        Status = reader["status"].ToString()
                    });
                }
                return riwayat;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan riwayat pengguna: " + ex.Message);
            }
        }


    }
}


