﻿using System;
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
        public V_Pengembalian_P()
        {
            InitializeComponent();
        }

        private void V_Pengembalian_Pelajar_Load(object sender, EventArgs e)
        {
            
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
            V_Peminjaman_Pe peminjaman = new V_Peminjaman_Pe();
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
            this.Hide();
            V_Login login = new V_Login();
            login.Show();
        }
    }
}
