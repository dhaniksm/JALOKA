using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace JALOKA.Controllers
{
    public class C_Peminjaman
    {
        private M_Buku buku = new M_Buku();
        public List<M_Buku> AmbilKeranjang()
        {
            var keranjang = new List<M_Buku>();

            try
            {
                using (var db = new D_Connector())
                {
                    using var cmd = new NpgsqlCommand("SELECT b.id_buku, b.judul, b.penulis, b.penerbit, b.tahun_terbit, b.sinopsis, b.cover FROM keranjang k JOIN buku b ON k.id_buku = b.id_buku WHERE k.id_user = @id_user", db.Connection);
                    cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);

                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        keranjang.Add(new M_Buku
                        {
                            id_buku = reader.GetInt32(0),
                            judul = reader.GetString(1),
                            penulis = reader.GetString(2),
                            penerbit = reader.GetString(3),
                            tahun_terbit = reader.GetInt32(4),
                            sinopsis = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            cover = reader["cover"] as byte[]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengambil keranjang: " + ex.Message);
            }

            return keranjang;
        }

        public static void TambahKeKeranjang(int id_buku)
        {
            try
            {
                using var db = new D_Connector();
                using (var cek = new NpgsqlCommand("SELECT 1 FROM keranjang WHERE id_user = @id_user AND id_buku = @id_buku", db.Connection))
                {
                    cek.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                    cek.Parameters.AddWithValue("@id_buku", id_buku);

                    if (cek.ExecuteScalar() != null)
                        throw new Exception("Buku ini sudah ada di keranjang.");
                }

                using (var hitung = new NpgsqlCommand("SELECT COUNT(*) FROM keranjang WHERE id_user = @id_user", db.Connection))
                {
                    hitung.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                    int total = Convert.ToInt32(hitung.ExecuteScalar());
                    if (total >= 3)
                        throw new Exception("Maksimal peminjaman adalah 3 buku.");
                }

                using var insert = new NpgsqlCommand("INSERT INTO keranjang (id_user, id_buku) VALUES (@id_user, @id_buku)", db.Connection);
                insert.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                insert.Parameters.AddWithValue("@id_buku", id_buku);
                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan ke keranjang: " + ex.Message);
            }
        }

        public void HapusDariKeranjang(int id_buku)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("DELETE FROM keranjang WHERE id_user = @id_user AND id_buku = @id_buku", db.Connection);
                cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                cmd.Parameters.AddWithValue("@id_buku", id_buku);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus buku dari keranjang: " + ex.Message);
            }
        }

        public void KosongkanKeranjang()
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("DELETE FROM keranjang WHERE id_user = @id_user", db.Connection);
                cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengosongkan keranjang: " + ex.Message);
            }
        }

        public void AjukanPeminjaman(int id_buku)
        {
            try
            {
                var keranjang = AmbilKeranjang();
                using var db = new D_Connector();

                foreach (var buku in keranjang)
                {
                    using var cmd = new NpgsqlCommand("INSERT INTO peminjaman (id_user, id_buku, tanggal_pinjam, tanggal_kembali, status) " + "VALUES (@id_user, @id_buku, @tanggal_pinjam, @tanggal_kembali, 'menunggu')", db.Connection);

                    cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                    cmd.Parameters.AddWithValue("@id_buku", buku.id_buku);
                    cmd.Parameters.AddWithValue("@tanggal_pinjam", DateTime.Now);
                    cmd.Parameters.AddWithValue("@tanggal_kembali", DateTime.Now.AddDays(7));
                    cmd.ExecuteNonQuery();
                }

                KosongkanKeranjang();
                H_Pesan.Sukses("Peminjaman diajukan, menunggu konfirmasi pustakawan.");
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengajukan peminjaman: " + ex.Message);
            }
        }

        public void ProsesPeminjaman()
        {
            try
            { 
                if (!ValidasiMaksimalPeminjaman()) return;
                if (!ValidasiStokBuku()) return;

                AjukanPeminjaman(buku.id_buku);
                KurangiStok();

                foreach (var buku in AmbilKeranjang())
                {
                    HapusDariKeranjang(buku.id_buku);
                }

                H_Pesan.Sukses("Peminjaman berhasil dilakukan.");
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Terjadi kesalahan: " + ex.Message);
            }
        }

        private bool ValidasiMaksimalPeminjaman()
        {
            int jumlahAktif = JumlahPeminjamanAktif();
            if (jumlahAktif >= 3)
            {
                H_Pesan.Peringatan("Anda hanya dapat memiliki maksimal 3 buku aktif.");
                return false;
            }
            return true;
        }

        private bool ValidasiStokBuku()
        {
            List<M_Buku> keranjang = AmbilKeranjang();
            foreach (var buku in keranjang)
            {
                int stok = AmbilStok(buku.id_buku);
                if (stok < 0)
                {
                    H_Pesan.Peringatan($"Stok buku \"{buku.judul}\" tidak mencukupi.");
                    return false;
                }
            }
            return true;
        }

        private void KurangiStok()
        {
            var keranjang = AmbilKeranjang();
            using (var db = new D_Connector())
            {
                foreach (var item in keranjang)
                {
                    using var cmd = new NpgsqlCommand("UPDATE buku SET stok = stok - 1 WHERE id_buku = @id_buku", db.Connection);
                    cmd.Parameters.AddWithValue("@id_buku", item.id_buku);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int AmbilStok(int id_buku)
        {
            using (var db = new D_Connector())
            {
                using var cmd = new NpgsqlCommand("SELECT stok FROM buku WHERE id_buku = @id_buku", db.Connection);
                cmd.Parameters.AddWithValue("@id_buku", id_buku);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int JumlahPeminjamanAktif()
        {
            using (var db = new D_Connector())
            {
                using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM peminjaman WHERE nisn = @nisn AND status = 'aktif'", db.Connection);

                cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public List<M_Peminjaman> MenungguKonfirmasi()
        {
            var daftar = new List<M_Peminjaman>();

            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand("SELECT p.id_buku, b.judul, b.penulis, b.penerbit, b.tahun_terbit, b.cover " +
                                              "FROM peminjaman p JOIN buku b ON p.id_buku = b.id_buku " +
                                              "WHERE p.nisn = @nisn AND p.status = 'menunggu'", db.Connection);
            cmd.Parameters.AddWithValue("@id_user", H_Sesi.nisn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                daftar.Add(new M_Peminjaman
                {
                    buku = new M_Buku
                    {
                        id_buku = reader.GetInt32(0),
                        judul = reader.GetString(1),
                        penulis = reader.GetString(2),
                        penerbit = reader.GetString(3),
                        tahun_terbit = reader.GetInt32(4),
                        cover = reader["cover"] as byte[]
                    }
                });
            }

            return daftar;
        }

        public void KonfirmasiPeminjaman(int id)
        {
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand("UPDATE peminjaman SET status = 'dipinjam', tanggal_kembali = CURRENT_DATE + INTERVAL '7 days' WHERE id_peminjaman = @id", db.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void TolakPeminjaman(int id)
        {
            using var db = new D_Connector();
            using var cmd = new NpgsqlCommand("DELETE FROM peminjaman WHERE id_peminjaman = @id", db.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
