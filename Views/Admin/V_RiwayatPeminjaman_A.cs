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
using JALOKA.Controllers;
using JALOKA.Views.Admin;

namespace JALOKA.Views
{
    public partial class V_RiwayatPeminjaman_A : Form
    {
        private readonly C_Riwayat riwayatController = new C_Riwayat();
        public V_RiwayatPeminjaman_A()
        {
            InitializeComponent();
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

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_A pengembalian = new V_Pengembalian_A();
            pengembalian.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal v_TampilanAwal = new V_TampilanAwal();
            v_TampilanAwal.Show();
        }

        private void LoadData()
        {
            try
            {
                var data = riwayatController.ShowRiwayat();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns.Contains("pinjam_id"))
                    dataGridView1.Columns["pinjam_id"].Visible = false;

                if (dataGridView1.Columns.Contains("buku_id"))
                    dataGridView1.Columns["buku_id"].Visible = false;

                if (dataGridView1.Columns.Contains("nisn"))
                    dataGridView1.Columns["nisn"].Visible = false;

                if (dataGridView1.Columns.Count == 0)
                {
                    MessageBox.Show("Kolom masih kosong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void V_RiwayatPeminjaman_A_Load_1(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {

        }
    }
}
