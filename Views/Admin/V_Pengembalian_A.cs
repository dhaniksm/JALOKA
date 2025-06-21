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
using JALOKA.Helpers;
using JALOKA.Models;
using JALOKA.Views.Admin;

namespace JALOKA.Views
{
    public partial class V_Pengembalian_A : Form
    {
        public V_Pengembalian_A()
        {
            InitializeComponent();
            TampilkanDaftarPengembalian();
        }

        private void TampilkanDaftarPengembalian()
        {
            C_Pengembalian c_pengembalian = new C_Pengembalian();
            var daftar = c_pengembalian.DaftarPengembalian();
            flowLayoutPanelKonfirmasi.Controls.Clear();

            foreach (var item in daftar)
            {
                Panel panel = new Panel { Width = 600, Height = 120, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(10) };

                Label info = new Label
                {
                    Text = $"User: {item.NamaUser}\nJudul: {item.JudulBuku}\nPinjam: {item.TanggalPinjam:dd MMM yyyy}\nKembali: {item.TanggalKembali:dd MMM yyyy}",
                    AutoSize = true,
                    Top = 10,
                    Left = 10
                };

                Button buttonKonfirmasi = new Button
                {
                    Text = "Konfirmasi",
                    Width = 100,
                    Top = 10,
                    Left = 400,
                    Tag = item.IdPeminjaman
                };

                buttonKonfirmasi.Click += (s, e) =>
                {
                    int id = (int)((Button)s).Tag;
                    c_pengembalian.KonfirmasiPengembalian(id);
                    H_Pesan.Sukses("Pengembalian dikonfirmasi.");
                    TampilkanDaftarPengembalian();
                };

                panel.Controls.Add(info);
                panel.Controls.Add(buttonKonfirmasi);
                flowLayoutPanelKonfirmasi.Controls.Add(panel);
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
            V_RiwayatPeminjaman_A riwayatPeminjaman = new V_RiwayatPeminjaman_A();
            riwayatPeminjaman.Show();
        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DataPengguna_A dataPengguna = new V_DataPengguna_A();
            dataPengguna.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_A riwayatPeminjaman = new V_RiwayatPeminjaman_A();
            riwayatPeminjaman.Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal v_TampilanAwal = new V_TampilanAwal();
            v_TampilanAwal.Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {

        }
    }
}
