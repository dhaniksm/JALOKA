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

namespace JALOKA.Views
{
    public partial class V_RiwayatPeminjaman_P : Form
    {
        public V_RiwayatPeminjaman_P()
        {
            InitializeComponent();
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
            this.Hide();
            V_Pengembalian_P pengembalian = new V_Pengembalian_P();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_P riwayatPeminjaman = new V_RiwayatPeminjaman_P();
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
            v_Profil_P.Show();
        }

        private void V_RiwayatPeminjaman_P_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            C_Riwayat riwayat = new C_Riwayat();
            try
            {
                var data = riwayat.TampilkanRiwayatPengguna(H_Sesi.IdUser);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns.Contains("nama"))
                {
                    dataGridView1.Columns["nama"].Visible = false;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat: " + ex.Message);
            }
        }


    }
}
