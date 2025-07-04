﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Database
{
    public static class D_Tabel
    {
        public static void CekTabel(NpgsqlConnection db, string tabel)
        {
            try
            {
                string query = $"SELECT 1 FROM {tabel} LIMIT 1";
                using var cmd = new NpgsqlCommand(query, db);
                cmd.ExecuteScalar();
            }
            catch (PostgresException ex)
            {
                if (ex.SqlState == "42P01")
                {
                    BuatTabel(db, tabel);
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
                "pengguna" => @"
                    CREATE TABLE pengguna (
                        id_user SERIAL PRIMARY KEY,
                        nisn VARCHAR(10) NOT NULL,
                        password VARCHAR(50) NOT NULL,
                        nama VARCHAR(100) NOT NULL,
                        email VARCHAR(100) NOT NULL UNIQUE,
                        nomor_hp VARCHAR(20) NOT NULL,
                        alamat TEXT NOT NULL
                    );",
                "buku" => @"
                    CREATE TABLE buku (
                        id_buku SERIAL PRIMARY KEY,
                        judul VARCHAR(100) NOT NULL,
                        penulis VARCHAR(100) NOT NULL,
                        penerbit VARCHAR(100) NOT NULL,
                        tahun_terbit INTEGER NOT NULL,
                        sinopsis TEXT NOT NULL,
                        cover BYTEA,
                        stok INTEGER NOT NULL DEFAULT 0
                    );",
                "peminjaman" => @"
                    CREATE TABLE peminjaman (
                        id_peminjaman SERIAL PRIMARY KEY,
                        id_user int NOT NULL,
                        id_buku INT NOT NULL,
                        tanggal_pinjam DATE NOT NULL,
                        tanggal_kembali DATE NOT NULL,
                        status VARCHAR(50) DEFAULT 'menunggu',
                        dikonfirmasi_oleh VARCHAR(50),
                        tanggal_dikembalikan DATE,
                        FOREIGN KEY (id_buku) REFERENCES buku(id_buku),
                        FOREIGN KEY (id_user) REFERENCES pengguna(id_user)
                    );",
                "keranjang" => @"
                    CREATE TABLE keranjang (
                        id_keranjang SERIAL PRIMARY KEY,
                        id_user INT NOT NULL,
                        id_buku INT NOT NULL,
                        jumlah INT DEFAULT 1,
                        FOREIGN KEY (id_user) REFERENCES pengguna(id_user),
                        FOREIGN KEY (id_buku) REFERENCES buku(id_buku)
                    );",
                _ => throw new Exception("Nama tabel tidak dikenali.")
            };

            using var cmd = new NpgsqlCommand(sql, db);
            cmd.ExecuteNonQuery();
        }
    }
}

