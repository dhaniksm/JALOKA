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

namespace JALOKA.Views
{
    public partial class V_Pengembalian_P : Form
    {
        private readonly C_Pengembalian c_pengembalian = new C_Pengembalian();

        public V_Pengembalian_P()
        {
            InitializeComponent();
        }

        private void V_Pengembalian_P_Load(object sender, EventArgs e)
        {
            

            LoadPeminjaman();
        }

        private void LoadPeminjaman()
        {
            listViewPeminjaman.Items.Clear();
            var data = c_pengembalian.AmbilPeminjamanAktif();

            foreach (var item in data)
            {
                var row = new ListViewItem(item.id_peminjaman.ToString());
                row.SubItems.Add(item.judul_buku);
                row.SubItems.Add(item.tanggal_pinjam.ToShortDateString());
                row.Tag = item;
                listViewPeminjaman.Items.Add(row);
            }
        }

        private void buttonKembalikan_Click(object sender, EventArgs e)
        {
            if (listViewPeminjaman.SelectedItems.Count > 0)
            {
                var item = (M_Peminjaman)listViewPeminjaman.SelectedItems[0].Tag;
                c_pengembalian.ProsesPengembalian(item.id_peminjaman, item.id_buku);
                LoadPeminjaman();
            }
            else
            {
                H_Pesan.Peringatan("Silakan pilih buku yang akan dikembalikan.");
            }
        }

        private void listViewPeminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (Opsional) Kosongkan jika tidak digunakan
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
