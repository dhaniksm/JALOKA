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

namespace JALOKA.Views
{
    public partial class V_Pengembalian_P : Form
    {
        C_Pengembalian c_pengembalian = new C_Pengembalian();

        public V_Pengembalian_P()
        {
            InitializeComponent();
            TampilkanPeminjaman();
        }

        private void TampilkanPeminjaman()
        {
            var daftar = c_pengembalian.PeminjamanBelumDikembalikan();
            flowLayoutPanelPengembalian.Controls.Clear();

            foreach (var item in daftar)
            {
                Panel panel = new Panel { Width = 500, Height = 120, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(10) };

                Label labelInfo = new Label
                {
                    Text = $"Judul: {item.judul_buku}\nPinjam: {item.tanggal_pinjam:dd MMM yyyy}\nKembali: {item.tanggal_kembali:dd MMM yyyy}",
                    AutoSize = true,
                    Top = 10,
                    Left = 10
                };

                Button btnKembalikan = new Button
                {
                    Text = "Ajukan Pengembalian",
                    Width = 150,
                    Top = 10,
                    Left = 300,
                    Tag = item.id_peminjaman
                };
                btnKembalikan.Click += (s, e) =>
                {
                    int id = (int)((Button)s).Tag;
                    c_pengembalian.AjukanPengembalian(id);
                    H_Pesan.Sukses("Permintaan pengembalian dikirim.");
                    TampilkanPeminjaman();
                };

                panel.Controls.Add(labelInfo);
                panel.Controls.Add(btnKembalikan);
                flowLayoutPanelPengembalian.Controls.Add(panel);
            }
        }

        private void buttonDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_P dashboard = new V_Dashboard_P();
            dashboard.Show();
        }

        private void buttonKatalogBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_KatalogBuku_P katalogbuku = new V_KatalogBuku_P();
            katalogbuku.Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Peminjaman_P peminjaman = new V_Peminjaman_P();
            peminjaman.Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_P riwayatPeminjaman = new V_RiwayatPeminjaman_P();
            riwayatPeminjaman.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();
        }

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Profil_P v_Profil_P = new V_Profil_P();
            v_Profil_P.ShowDialog();

        }
    }
}
