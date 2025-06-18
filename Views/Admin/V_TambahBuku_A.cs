using JALOKA.Models;
using JALOKA.Controllers;
using JALOKA.Helpers;
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
    public partial class V_TambahBuku_A : Form
    {
        private C_Buku controller = new C_Buku();
        private byte[] cover = null;

        private OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            Title = "Pilih Cover Buku"
        };

        public V_TambahBuku_A()
        {
            InitializeComponent();
        }

        private void buttonPilihGambar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cover = H_Konversi.ImageFileToByteArray(openFileDialog.FileName);
                pictureBoxCover.Image = H_Konversi.ByteArrayToImage(cover);
            }
            buttonPilihGambar.Hide();
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cover = H_Konversi.ImageFileToByteArray(openFileDialog.FileName);
                pictureBoxCover.Image = H_Konversi.ByteArrayToImage(cover);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            V_ManajemenBuku_A manajemenBuku = new V_ManajemenBuku_A();
            manajemenBuku.Show();
            this.Close();
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxJudul.Text) || string.IsNullOrWhiteSpace(textBoxPenulis.Text) || string.IsNullOrWhiteSpace(textBoxPenerbit.Text) || string.IsNullOrWhiteSpace(textBoxTahunTerbit.Text) || string.IsNullOrEmpty(textBoxSinopsis.Text))
                {
                    H_Pesan.Gagal("Judul dan Penulis wajib diisi.");
                    return;
                }

                int tahun;
                if (!int.TryParse(textBoxTahunTerbit.Text, out tahun))
                {
                    H_Pesan.Gagal("Tahun tidak valid.");
                    return;
                }

                var buku = new M_Buku
                {
                    judul = textBoxJudul.Text,
                    penulis = textBoxPenulis.Text,
                    penerbit = textBoxPenerbit.Text,
                    tahun_terbit = tahun,
                    sinopsis = textBoxSinopsis.Text,
                    cover = cover
                };

                controller.TambahBuku(buku);
                H_Pesan.Sukses("Buku berhasil ditambahkan.");
                V_ManajemenBuku_A manajemenBuku = new V_ManajemenBuku_A();
                manajemenBuku.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menambahkan buku: " + ex.Message);
            }
        }
    }
}
