using JALOKA.Controllers;
using JALOKA.Helpers;
using JALOKA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JALOKA.Views.Admin
{
    public partial class V_DetailBuku_A : Form
    {
        private readonly int idBuku;
        private M_Buku? buku;
        private C_Buku c_buku = new C_Buku();
        public V_DetailBuku_A(int id_buku)
        {
            InitializeComponent();
            idBuku = id_buku;
            TampilkanDetailBuku();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                c_buku.HapusBuku(idBuku);
                H_Pesan.Sukses("Buku berhasil dihapus.");
                V_ManajemenBuku_A manajemenBuku = new V_ManajemenBuku_A();
                manajemenBuku.Refresh();
                this.Close();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus buku: " + ex.Message);
            }
        }
    }
}
