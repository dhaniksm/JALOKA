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
using JALOKA.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JALOKA.Views
{
    public partial class V_DataPengguna_K : Form
    {
        private readonly C_User userController = new C_User();

        public V_DataPengguna_K()
        {
            InitializeComponent();
        }

        private void V_DataPengguna_K_Load(object sender, EventArgs e)
        {
            TampilkanDataPengguna();
            dataGridViewDataUser.ClearSelection();
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

        private void dataGridViewDatauser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewDataUser.Rows[e.RowIndex];
                textBoxIDPelajar.Text = row.Cells["nisn"].Value.ToString();
                textBoxNama.Text = row.Cells["nama"].Value.ToString();
                textBoxEmail.Text = row.Cells["email"].Value.ToString();
                textBoxNoHP.Text = row.Cells["nomor_hp"].Value.ToString();
                textBoxAlamat.Text = row.Cells["alamat"].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxNoHP.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                H_Pesan.Peringatan("Semua kolom wajib diisi.");
                return;
            }

            if (!textBoxEmail.Text.Contains("@"))
            {
                H_Pesan.Peringatan("Format email tidak valid.");
                return;
            }

            if (!long.TryParse(textBoxNoHP.Text, out _))
            {
                H_Pesan.Peringatan("Nomor HP hanya boleh berisi angka.");
                return;
            }

            var pengguna = new M_Pengguna
            {
                Nisn = textBoxIDPelajar.Text,
                Nama = textBoxNama.Text,
                Email = textBoxEmail.Text,
                NomorHp = textBoxNoHP.Text,
                Alamat = textBoxAlamat.Text
            };

            bool berhasil = userController.EditPengguna(pengguna);
            if (berhasil)
            {
                H_Pesan.Sukses("Data berhasil diperbarui.");
                TampilkanDataPengguna();
            }
            else
            {
                H_Pesan.Gagal("Gagal memperbarui data.");
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDPelajar.Text))
            {
                H_Pesan.Peringatan("Silakan pilih data pengguna terlebih dahulu.");
                return;
            }

            if (H_Pesan.Konfirmasi("Apakah Anda yakin ingin menghapus data ini?"))
            {
                bool berhasil = userController.HapusPengguna(textBoxIDPelajar.Text);
                if (berhasil)
                {
                    H_Pesan.Sukses("Data berhasil dihapus.");
                    TampilkanDataPengguna();
                    BersihkanForm();
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new V_Dashboard_K().Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            new V_TampilanAwal().Show();
        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {
            
        }

        private void BersihkanForm()
        {
            textBoxIDPelajar.Clear();
            textBoxNama.Clear();
            textBoxEmail.Clear();
            textBoxNoHP.Clear();
            textBoxAlamat.Clear();
        }
    }
}
