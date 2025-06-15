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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JALOKA.Views
{
    public partial class V_Pengembalian_A : Form
    {
        private readonly C_Pengembalian c_pengembalian = new C_Pengembalian();

        public V_Pengembalian_A()
        {
            InitializeComponent();
            LoadPeminjaman();
        }

        private void LoadPeminjaman()
        {
            listView1.Items.Clear();
            var data = c_pengembalian.AmbilPeminjamanAktif();

            foreach (var item in data)
            {
                var row = new ListViewItem(item.id_peminjaman.ToString());
                row.SubItems.Add(item.judul);
                row.SubItems.Add(item.tanggal_pinjam.ToShortDateString());
                row.Tag = item;
                listView1.Items.Add(row);
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

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = (M_Peminjaman)listView1.SelectedItems[0].Tag;
                c_pengembalian.ProsesPengembalian(item.id_peminjaman, item.id_buku);
                LoadPeminjaman(); // refresh list
            }
            else
            {
                H_Pesan.Peringatan("Silakan pilih buku yang akan dikembalikan.");
            }
        }
    }
}
