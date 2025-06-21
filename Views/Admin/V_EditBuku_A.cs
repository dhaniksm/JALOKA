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
    public partial class V_EditBuku_A : Form
    {
        private readonly int idBuku;
        private byte[] cover;

        public V_EditBuku_A(int id)
        {
            InitializeComponent();
            idBuku = id;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var buku = new C_Buku().AmbilDetailBuku(idBuku);
                if (buku == null)
                {
                    H_Pesan.Peringatan("Data buku tidak ditemukan.");
                    this.Close();
                    return;
                }

                textBoxJudul.Text = buku.Judul;
                textBoxPenulis.Text = buku.Penulis;
                textBoxPenerbit.Text = buku.Penerbit;
                textBoxTahunTerbit.Text = buku.TahunTerbit.ToString();
                textBoxSinopsis.Text = buku.Sinopsis;
                cover = buku.Cover;

                if (cover != null)
                {
                    pictureBoxCover.Image = H_Konversi.ByteArrayToImage(cover);
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat data buku: " + ex.Message);
                this.Close();
            }
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCover.Image = Image.FromFile(dialog.FileName);
                cover = H_Konversi.ImageToByteArray(pictureBoxCover.Image);
            }
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                var buku = new M_Buku
                {
                    IdBuku = idBuku,
                    Judul = textBoxJudul.Text,
                    Penulis = textBoxPenulis.Text,
                    Penerbit = textBoxPenerbit.Text,
                    TahunTerbit = int.TryParse(textBoxTahunTerbit.Text, out var tahun) ? tahun : 0,
                    Sinopsis = textBoxSinopsis.Text,
                    Cover = cover
                };

                new C_Buku().EditBuku(buku);
                H_Pesan.Sukses("Buku berhasil diperbarui.");
                this.Close();
                V_DetailBuku_A detail = new V_DetailBuku_A(idBuku);
                detail.Show();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal mengedit buku: " + ex.Message);
            }
        }
    }
}
