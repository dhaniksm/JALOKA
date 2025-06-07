using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JALOKA.Database;
using JALOKA.Models;
using Npgsql;

namespace JALOKA.Controllers
{
    public class C_Keranjang
    {
        private List<M_Buku> keranjang = new List<M_Buku>();
        private readonly Connector db = new Connector();

        public C_Keranjang(NpgsqlConnection db)
        {
            db = db;
        }

        public List<M_Buku> AmbilKeranjang()
        {
            return new List<M_Buku>(keranjang);
        }

        public void TambahBuku( M_Buku buku)
        {
            if (!keranjang.Exists(b => b.id_buku == buku.id_buku))
                keranjang.Add(buku);
        }

        public void HapusBuku(int id_buku)
        {
            keranjang.RemoveAll(b => b.id_buku == id_buku);
        }

        public void KosongkanKeranjang()
        {
            keranjang.Clear();
        }

        public void SimpanPeminjaman()
        {
            try
            {
                foreach (var buku in keranjang)
                {
                    string query = @"INSERT INTO peminjaman (id_buku, tanggal_pinjam) VALUES (@id_buku, @tanggal_pinjam)";
                    using var cmd = new NpgsqlCommand(query, db.Connection);
                    cmd.Parameters.AddWithValue("@id_buku", buku.id_buku);
                    cmd.Parameters.AddWithValue("@tanggal_pinjam", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Peminjaman berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KosongkanKeranjang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan peminjaman: " + ex.Message);
            }
        }
    }
}
