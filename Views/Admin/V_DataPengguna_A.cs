using JALOKA.Controllers;
using JALOKA.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JALOKA.Views.Admin;

namespace JALOKA.Views
{
    public partial class V_DataPengguna_A : Form
    {
        private readonly C_User userController = new C_User();

        public V_DataPengguna_A()
        {
            InitializeComponent();
        }

        private void V_DataPengguna_A_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridViewUsers.ClearSelection();
        }

        private void LoadData()
        {
            try
            {
                var data = userController.DaftarPengguna();

                dataGridViewUsers.AutoGenerateColumns = true;
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = data;

                if (dataGridViewUsers.Columns.Count == 0)
                {
                    MessageBox.Show("Kolom masih kosong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[index];
                textBoxID.Text = row.Cells["nisn"].Value.ToString();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Silakan pilih pengguna terlebih dahulu.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = userController.DeleteUser(textBoxID.Text);
                if (success)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    LoadData();
                    textBoxID.Clear();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }
        }



        // Navigasi antar form
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
            this.Refresh();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_A pengembalian = new V_Pengembalian_A();
            pengembalian.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_A riwayatPeminjaman = new V_RiwayatPeminjaman_A();
            riwayatPeminjaman.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login_A login = new V_Login_A();
            login.Show();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        
    }
}
