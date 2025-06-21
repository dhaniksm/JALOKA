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
    public partial class V_Peminjaman_A : Form
    {
        C_Peminjaman c_peminjaman = new C_Peminjaman();

        public V_Peminjaman_A()
        {
            InitializeComponent();
            TampilkanDaftar();
        }
        private void TampilkanDaftar()
        {
            try
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
                        Text = $"User: {item.IdUser}\nBuku: {item.JudulBuku}\nTanggal: {item.TanggalPinjam:dd MMM yyyy}",
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
                        Tag = item.IdPeminjaman,
                    };
                    btnKonfirmasi.Click += BtnKonfirmasi_Click;

                    Button btnTolak = new Button
                    {
                        Text = "Tolak",
                        Width = 100,
                        Height = 30,
                        Top = 50,
                        Left = 400,
                        Tag = item.IdPeminjaman
                    };
                    btnTolak.Click += BtnTolak_Click;

                    flowLayoutPanelKonfirmasi.Controls.Add(panel);
                    panel.Controls.Add(labelInfo);
                    panel.Controls.Add(btnKonfirmasi);
                    panel.Controls.Add(btnTolak);
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal menampilkan daftar peminjaman: " + ex.Message);
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_A dashboard = new V_Dashboard_A();
            dashboard.Show();
        }

        private void buttonManajemenBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_ManajemenBuku_A manajemenBuku = new V_ManajemenBuku_A();
            manajemenBuku.Show();
        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DataPengguna_A dataPengguna = new V_DataPengguna_A();
            dataPengguna.Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Peminjaman_A peminjaman = new V_Peminjaman_A();
            peminjaman.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_A riwayat = new V_RiwayatPeminjaman_A();
            riwayat.Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_A pengembalian = new V_Pengembalian_A();
            pengembalian.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {

        }
    }
}
