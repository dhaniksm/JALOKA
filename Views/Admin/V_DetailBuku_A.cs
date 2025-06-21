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
        C_Buku c_buku = new C_Buku();

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
                var buku = c_buku.AmbilDetailBuku(idBuku);
                labelJudul.Text = buku.Judul;
                labelPenulis.Text = buku.Penulis;
                labelPenerbit.Text = buku.Penerbit;
                labelTahunTerbit.Text = buku.TahunTerbit.ToString();
                labelSinopsis.Text = buku.Sinopsis;

                if (buku.Cover != null)
                {
                    pictureBoxCover.Image = H_Konversi.ByteArrayToImage(buku.Cover);
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
            this.Hide();
            V_EditBuku_A editBuku = new V_EditBuku_A(idBuku);
            editBuku.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                c_buku.HapusBuku(idBuku);
                H_Pesan.Sukses("Buku berhasil dihapus.");
                V_ManajemenBuku_A manajemen = new V_ManajemenBuku_A();
                manajemen.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menghapus buku: " + ex.Message);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
