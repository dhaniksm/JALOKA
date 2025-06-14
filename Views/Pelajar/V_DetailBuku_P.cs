using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JALOKA.Controllers;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;

namespace JALOKA.Views
{
    public partial class V_DetailBuku_P : Form
    {
        private readonly int idBuku;
        private M_Buku? buku;
        private readonly C_Buku c_buku;
        public V_DetailBuku_P(int id_buku)
        {
            InitializeComponent();
            TabelKeranjang();
            idBuku = id_buku;
            TampilkanDetailBuku();
        }

        private void TabelKeranjang()
        {
            try
            {
                using (var db = new D_Connector())
                {
                    D_Tabel.CekTabel(db.Connection, "keranjang");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memeriksa tabel keranjang: " + ex.Message);
            }
        }

        private void TampilkanDetailBuku()
        {
            try
            {
                buku = C_Buku.AmbilDetailBuku(idBuku);

                labelJudul.Text = buku.judul;
                labelPenulis.Text = buku.penulis;
                labelPenerbit.Text = buku.penerbit;
                labelTahunTerbit.Text = buku.tahun_terbit.ToString();
                labelSinopsis.Text = buku.sinopsis;

                if (buku.cover != null)
                {
                    pictureBoxCover.Image = H_Konversi.ByteArrayToImage(buku.cover);
                    pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Terjadi kesalahan saat memuat detail buku: " + ex.Message);
            }
        }

        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            try
            {
                C_Peminjaman.TambahKeKeranjang(idBuku);
                H_Pesan.Sukses("Buku berhasil ditambahkan ke keranjang.");
                this.Close();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal meminjam buku: " + ex.Message);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
