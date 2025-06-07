using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Database
{
    public static class Tabel
    {
        public static void CekTabel(NpgsqlConnection db, string namaTabel)
        {
            try
            {
                string query = $"SELECT 1 FROM {namaTabel} LIMIT 1";
                using var cmd = new NpgsqlCommand(query, db);
                cmd.ExecuteScalar();
            }
            catch (PostgresException ex)
            {
                if (ex.SqlState == "42P01")
                {
                    BuatTabel(db, namaTabel);
                }
                else
                {
                    throw;
                }
            }
        }

        private static void BuatTabel(NpgsqlConnection db, string namaTabel)
        {
            string sql = namaTabel switch
            {
                "buku" => @"
                    CREATE TABLE buku (
                        id_buku SERIAL PRIMARY KEY,
                        judul VARCHAR(100) NOT NULL,
                        penulis VARCHAR(100) TEXT NOT NULL,
                        tahun_terbit INTEGER NOT NULL,
                        stok INTEGER NOT NULL DEFAULT 0,
                        coverpath VARCHAR(100) DEFAULT NULL
                    );",
                "peminjaman" => @"
                    CREATE TABLE peminjaman (
                        id_peminjaman SERIAL PRIMARY KEY,
                        id_buku INTEGER NOT NULL REFERENCES buku(id_buku) ON DELETE CASCADE,
                        id_pelajar VARCHAR(10) NOT NULL REFERENCES user(id_pelajar) ON DELETE CASCADE,
                        tanggal_peminjaman DATE NOT NULL,
                        tanggal_pengembalian DATE NOT NULL
                    );",
                "user" => @"
                    CREATE TABLE user (
                        id_pelajar VARCHAR(10) NOT NULL UNIQUE,
                        nama_lengkap VARCHAR(100) NOT NULL,
                        sandi VARCHAR(100) NOT NULL
                    );",
                _ => throw new Exception("Nama tabel tidak dikenali.")
            };

            using var cmd = new NpgsqlCommand(sql, db);
            cmd.ExecuteNonQuery();
        }
    }
}

