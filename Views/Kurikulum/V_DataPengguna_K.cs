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
using JALOKA.Models;
using JALOKA.Views.Admin;
using JALOKA.Views;



namespace JALOKA.Views
{
    public partial class V_DataPengguna_K : Form
    {
        private readonly C_User userController = new C_User();

        public V_DataPengguna_K()
        {
            InitializeComponent();
        }

        private void TampilkanDataPengguna()
        {
            dataGridViewDataUser.AutoGenerateColumns = true;
            dataGridViewDataUser.DataSource = null;
            dataGridViewDataUser.DataSource = userController.DaftarPengguna();
            dataGridViewDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewDataUser.Columns.Contains("password"))
                dataGridViewDataUser.Columns["password"].Visible = false;
        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_K dashboard = new V_Dashboard_K();
            dashboard.Show();

        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDPelajar.Text))
            {
                MessageBox.Show("Silakan pilih data pengguna yang akan dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                bool berhasil = userController.DeleteUser(textBoxIDPelajar.Text);
                MessageBox.Show(berhasil ? "Data berhasil dihapus." : "Gagal menghapus data.");
                if (berhasil)
                {
                    TampilkanDataPengguna();
                    BersihkanForm();
                }

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxNoHP.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                MessageBox.Show("Semua kolom wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBoxNoHP.Text, out _))
            {
                MessageBox.Show("Nomor HP hanya boleh berisi angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pengguna = new M_User
            {
                nisn = textBoxIDPelajar.Text,
                nama = textBoxNama.Text,
                email = textBoxEmail.Text,
                nomor_hp = textBoxNoHP.Text,
                alamat = textBoxAlamat.Text
            };

            bool berhasil = userController.UpdateUser(pengguna);
            MessageBox.Show(berhasil ? "Data berhasil diperbarui." : "Gagal memperbarui data.");
            if (berhasil) TampilkanDataPengguna();

        }

        private void dataGridViewDatauser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var baris = dataGridViewDataUser.Rows[e.RowIndex];
                textBoxIDPelajar.Text = baris.Cells["nisn"].Value.ToString();
                textBoxNama.Text = baris.Cells["nama"].Value.ToString();
                textBoxEmail.Text = baris.Cells["email"].Value.ToString();
                textBoxNoHP.Text = baris.Cells["nomor_hp"].Value.ToString();
                textBoxAlamat.Text = baris.Cells["alamat"].Value.ToString();
            }

        }
        private void BersihkanForm()
        {
            textBoxIDPelajar.Clear();
            textBoxNama.Clear();
            textBoxEmail.Clear();
            textBoxNoHP.Clear();
            textBoxAlamat.Clear();
        }

        private void V_DataPengguna_K_Load(object sender, EventArgs e)
        {
            TampilkanDataPengguna();
            dataGridViewDataUser.ClearSelection();

        }
    }
}

