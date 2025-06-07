using JALOKA.Controllers;
using JALOKA.Database;
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
using Npgsql;

namespace JALOKA.Views
{
    public partial class V_Peminjaman_P : Form
    {
        private C_Keranjang keranjang;
        public V_Peminjaman_P(NpgsqlConnection db)
        {
            InitializeComponent();
            keranjang = new C_Keranjang(db);
            TampilkanKeranjang();
        }

        private void TampilkanKeranjang()
        {
            dataGridViewKeranjang.Rows.Clear();
            List<M_Buku> daftar = keranjang.AmbilKeranjang();

            foreach (var buku in daftar)
                dataGridViewKeranjang.Rows.Add(buku.id_buku, buku.judul, buku.penulis, buku.tahun_terbit);
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
            this.Refresh();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_P pengembalian = new V_Pengembalian_P();
            pengembalian.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Peminjaman_P riwayatPeminjaman = new V_Peminjaman_P();
            riwayatPeminjaman.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login login = new V_Login();
            login.Show();
        }
    }
}
