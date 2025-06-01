using JALOKA.Database;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JALOKA.Controllers
{
    public class C_Peminjaman
    {
        private readonly Connector _db = new Connector();

        public List<M_Peminjaman> DaftarPeminjaman()
        {
            var list = new List<M_Peminjaman>();
            using var cmd = new NpgsqlCommand("SELECT * FROM peminjamans ORDER BY pinjam_id DESC", _db.Connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new M_Peminjaman
                {
                    pinjam_id = reader.GetInt32(0),
                    buku_id = reader.GetInt32(1),
                    tanggal_peminjaman = reader.GetDateTime(3),
                    tanggal_pengembalian = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    id_pelajar = reader.GetString(2)
                });
            }
            return list;
        }

        public bool TambahPeminjaman(M_Peminjaman pinjam)
        {
            var query = "INSERT INTO peminjamans (buku_id, tanggal_peminjaman, id_pelajar) VALUES (@buku_id, @tanggal_peminjaman, @id_pelajar)";
            using var cmd = new NpgsqlCommand(query, _db.Connection);
            cmd.Parameters.AddWithValue("buku_id", pinjam.buku_id);
            cmd.Parameters.AddWithValue("tanggal_peminjaman", pinjam.tanggal_peminjaman);
            cmd.Parameters.AddWithValue("id_pelajar", pinjam.id_pelajar);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Pengembalian(int pinjam_id)
        {
            var query = "UPDATE peminjamans SET Pengembalian = CURRENT_DATE WHERE pinjam_id = @pinjam_id";
            using var cmd = new NpgsqlCommand(query, _db.Connection);
            cmd.Parameters.AddWithValue("pinjam_id", pinjam_id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteLoan(int pinjam_id)
        {
            var cmd = new NpgsqlCommand("DELETE FROM peminjamans WHERE pinjam_id = @pinjam_id", _db.Connection);
            cmd.Parameters.AddWithValue("pinjam_id", pinjam_id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
