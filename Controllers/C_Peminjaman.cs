using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Peminjaman
    {
        private readonly Connector db = new Connector();

        public void TabelPeminjaman()
        {
            Tabel.CekTabel(db.Connection, "peminjaman");
        }

        public List<M_Peminjaman> DaftarPeminjaman()
        {
            var list = new List<M_Peminjaman>();
            using var cmd = new NpgsqlCommand("SELECT * FROM peminjaman ORDER BY pinjam_id DESC", db.Connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new M_Peminjaman
                {
                    id_peminjaman = reader.GetInt32(0),
                    id_buku = reader.GetInt32(1),
                    tanggal_peminjaman = reader.GetDateTime(3),
                    tanggal_pengembalian = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    id_pelajar = reader.GetString(2)
                });
            }
            return list;
        }

        public bool TambahPeminjaman(M_Peminjaman pinjam)
        {
            var query = "INSERT INTO peminjaman (buku_id, tanggal_peminjaman, id_pelajar) VALUES (@buku_id, @tanggal_peminjaman, @id_pelajar)";
            using var cmd = new NpgsqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("buku_id", pinjam.id_buku);
            cmd.Parameters.AddWithValue("tanggal_peminjaman", pinjam.tanggal_peminjaman);
            cmd.Parameters.AddWithValue("id_pelajar", pinjam.id_pelajar);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteLoan(int id_peminjaman)
        {
            var cmd = new NpgsqlCommand("DELETE FROM peminjaman WHERE pinjam_id = @pinjam_id", db.Connection);
            cmd.Parameters.AddWithValue("id_peminjaman", id_peminjaman);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
