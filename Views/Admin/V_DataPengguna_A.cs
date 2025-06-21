using JALOKA.Controllers;
using JALOKA.Models;
using System;
using System.Windows.Forms;
using JALOKA.Views.Admin;
using JALOKA.Helpers;

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

                if (dataGridViewUsers.Columns.Contains("password"))
                    dataGridViewUsers.Columns["password"].Visible = false;

                dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewUsers.Columns.Count == 0)
                    H_Pesan.Peringatan("Kolom masih kosong.");
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat data: " + ex.Message);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewUsers.Columns.Contains("nisn"))
            {
                var row = dataGridViewUsers.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["nisn"].Value.ToString();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                H_Pesan.Peringatan("Silakan pilih pengguna terlebih dahulu.");
                return;
            }

            if (H_Pesan.Konfirmasi("Yakin ingin menghapus data ini?"))
            {
                bool success = userController.HapusPengguna(textBoxID.Text);
                if (success)
                {
                    H_Pesan.Sukses("Data berhasil dihapus.");
                    LoadData();
                    textBoxID.Clear();
                }
                else
                {
                    H_Pesan.Gagal("Gagal menghapus data.");
                }
            }
            else
            {
                H_Pesan.Peringatan("Penghapusan dibatalkan.");
            }

        }


        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {

        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new V_Dashboard_A().Show();
        }

        private void buttonManajemenBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            new V_ManajemenBuku_A().Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            new V_Pengembalian_A().Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            new V_RiwayatPeminjaman_A().Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            new V_TampilanAwal().Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {

        }
    }
}
