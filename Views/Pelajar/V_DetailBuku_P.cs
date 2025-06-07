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
using JALOKA.Models;

namespace JALOKA.Views.Pelajar
{
    public partial class V_DetailBuku_P : Form
    {
        private M_Buku buku;
        public V_DetailBuku_P(M_Buku buku)
        {
            InitializeComponent();
        }

        private void TampilkanDetail()
        {
            labelJudul.Text = buku.judul;
            labelPenulis.Text = "Penulis: " + buku.penulis;
            labelTahunTerbit.Text = "Tahun Terbit: " + buku.tahun_terbit;

            if (!string.IsNullOrEmpty(buku.cover_path) && File.Exists(buku.cover_path))
            {
                pictureBoxCover.Image = Image.FromFile(buku.cover_path);
                pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            C_Keranjang.TambahBuku(buku);
            MessageBox.Show("Buku berhasil ditambahkan ke keranjang.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
