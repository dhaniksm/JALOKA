using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Riwayat
    {
        private readonly D_Connector db = new D_Connector();

        public List<M_Riwayat> ShowRiwayat()
        {
            var riwayat = new List<M_Riwayat>();

            try
            {
                using var cmd = new NpgsqlCommand(@" SELECT p.id_peminjaman, p.id_buku, b.judul, p.id_user, u.nama, p.tanggal_pinjam, p.tanggal_kembali FROM peminjaman p JOIN pengguna u ON p.id_user = u.id_user JOIN buku b ON p.id_buku = b.id_buku ORDER BY p.tanggal_pinjam DESC;", db.Connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    riwayat.Add(new M_Riwayat
                    {
                        id_peminjaman = Convert.ToInt32(reader["id_peminjaman"]),
                        judul = reader["judul"].ToString(),
                        nama = reader["nama"].ToString(),
                        tanggal_peminjaman = Convert.ToDateTime(reader["tanggal_pinjam"]),
                        tanggal_pengembalian = reader["tanggal_kembali"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["tanggal_kembali"]),
                        status = reader["status"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan riwayat: " + ex.Message);
            }

            return riwayat;
        }
        public List<M_Riwayat> ShowRiwayatUser(int id_user)
        {
            var riwayat = new List<M_Riwayat>();

            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand(@"SELECT p.id_peminjaman, b.judul, p.tanggal_pinjam, p.tanggal_kembali, p.status FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku WHERE p.id_user = @id_user ORDER BY p.tanggal_pinjam DESC", db.Connection);
            cmd.Parameters.AddWithValue("@id_user", id_user);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                riwayat.Add(new M_Riwayat
                {
                    id_peminjaman = Convert.ToInt32(reader["id_peminjaman"]),
                    judul = reader["judul"].ToString(),
                    tanggal_peminjaman = Convert.ToDateTime(reader["tanggal_pinjam"]),
                    tanggal_pengembalian = reader["tanggal_kembali"] is DBNull ? (DateTime?)null : Convert.ToDateTime(reader["tanggal_kembali"]),
                    status = reader["status"].ToString()
                });
            }

            return riwayat;
        }


    }
}


