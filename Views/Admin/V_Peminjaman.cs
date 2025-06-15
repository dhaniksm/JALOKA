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
    public partial class V_Peminjaman : Form
    {
        private C_Peminjaman c_peminjaman = new C_Peminjaman();
        public V_Peminjaman()
        {
            InitializeComponent();
            TampilkanDaftar();
        }
        private void TampilkanDaftar()
        {
            flowLayoutPanelKonfirmasi.Controls.Clear();
            var daftar = c_peminjaman.MenungguKonfirmasi();

            foreach (var item in daftar)
            {
                Panel panel = new Panel
                {
                    Width = 600,
                    Height = 120,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label labelInfo = new Label
                {
                    Text = $"User: {item.nama_peminjam}\nBuku: {item.judul_buku}\nTanggal: {item.tanggal_pinjam:dd MMM yyyy}",
                    AutoSize = true,
                    Left = 10,
                    Top = 10
                };

                Button btnKonfirmasi = new Button
                {
                    Text = "Konfirmasi",
                    Width = 100,
                    Height = 30,
                    Top = 10,
                    Left = 400,
                    Tag = item.id_peminjaman
                };
                btnKonfirmasi.Click += BtnKonfirmasi_Click;

                Button btnTolak = new Button
                {
                    Text = "Tolak",
                    Width = 100,
                    Height = 30,
                    Top = 50,
                    Left = 400,
                    Tag = item.id_peminjaman
                };
                btnTolak.Click += BtnTolak_Click;

                panel.Controls.Add(labelInfo);
                panel.Controls.Add(btnKonfirmasi);
                panel.Controls.Add(btnTolak);
                flowLayoutPanelKonfirmasi.Controls.Add(panel);
            }
        }

        private void BtnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                c_peminjaman.KonfirmasiPeminjaman(id);
                H_Pesan.Sukses("Peminjaman dikonfirmasi.");
                TampilkanDaftar();
            }
        }

        private void BtnTolak_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                c_peminjaman.TolakPeminjaman(id);
                H_Pesan.Sukses("Peminjaman ditolak.");
                TampilkanDaftar();
            }
        }
    }
}
