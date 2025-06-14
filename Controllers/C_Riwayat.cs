using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace JALOKA.Controllers
{
    class C_Riwayat
    {
        private readonly D_Connector db = new D_Connector();

        public List<M_Riwayat> ShowRiwayat()
        {
            var riwayat = new List<M_Riwayat>();
            try
            {
                using var cmd = new NpgsqlCommand(@"
                    SELECT 
                        p.pinjam_id AS id_peminjaman, 
                        p.buku_id, 
                        b.judul AS judul_buku, 
                        p.id_user, 
                        u.nama AS nama_user, 
                        p.tanggal_peminjaman, 
                        p.tanggal_pengembalian 
                    FROM M_Peminjaman p 
                    JOIN users u ON p.id_user = u.id_user 
                    JOIN m_buku b ON p.buku_id = b.buku_id 
                    ORDER BY p.tanggal_peminjaman DESC;", db.Connection);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    riwayat.Add(new M_Riwayat
                    {
                        judul = reader["judul_buku"].ToString(),
                        nama = reader["nama_user"].ToString(),
                        tanggal_peminjaman = Convert.ToDateTime(reader["tanggal_peminjaman"]),
                        tanggal_pengembalian = Convert.ToDateTime(reader["tanggal_pengembalian"]),
                        pinjam_id = Convert.ToInt32(reader["id_peminjaman"])
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan riwayat: " + ex.Message);
            }

            return riwayat;
        }

    }
}
