using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using JALOKA.Controllers;
using JALOKA.Models;

namespace JALOKA.Views
{
    public partial class V_DataPengguna_K : Form
    {
        private readonly C_User userController = new C_User();

        public V_DataPengguna_K()
        {
            InitializeComponent();
        }
    }
}

        //private void V_DataPengguna_K_Load(object sender, EventArgs e)
//        {
//            TampilkanDataPengguna();
//            dataGridViewDataPengguna.ClearSelection();
//        }

//        private void TampilkanDataPengguna()
//        {
//            dataGridViewDataPengguna.AutoGenerateColumns = true;
//            dataGridViewDataPengguna.DataSource = null;
//            dataGridViewDataPengguna.DataSource = userController.DaftarPengguna();
//            dataGridViewDataPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

//            if (dataGridViewDataPengguna.Columns.Contains("password"))
//                dataGridViewDataPengguna.Columns["password"].Visible = false;
//        }

//        private void dataGridViewDataPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                var baris = dataGridViewDataPengguna.Rows[e.RowIndex];
//                textBoxIdPengguna.Text = baris.Cells["id_pelajar"].Value.ToString();
//                textBoxNama.Text = baris.Cells["nama"].Value.ToString();
//                textBoxEmail.Text = baris.Cells["email"].Value.ToString();
//                textBoxNomorHP.Text = baris.Cells["nomor_hp"].Value.ToString();
//                textBoxAlamat.Text = baris.Cells["alamat"].Value.ToString();
//            }
//        }

//        private void buttonEdit_Click(object sender, EventArgs e)
//        {
//            // Validasi input
//            if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
//                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
//                string.IsNullOrWhiteSpace(textBoxNomorHP.Text) ||
//                string.IsNullOrWhiteSpace(textBoxAlamat.Text))
//            {
//                MessageBox.Show("Semua kolom wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (!textBoxEmail.Text.Contains("@"))
//            {
//                MessageBox.Show("Format email tidak valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (!long.TryParse(textBoxNomorHP.Text, out _))
//            {
//                MessageBox.Show("Nomor HP hanya boleh berisi angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var pengguna = new M_User
//            {
//                id_pelajar = textBoxIdPengguna.Text,
//                nama = textBoxNama.Text,
//                email = textBoxEmail.Text,
//                nomor_hp = textBoxNomorHP.Text,
//                alamat = textBoxAlamat.Text
//            };

//            bool berhasil = userController.UpdateUser(pengguna);
//            MessageBox.Show(berhasil ? "Data berhasil diperbarui." : "Gagal memperbarui data.");
//            if (berhasil) TampilkanDataPengguna();
//        }

//        private void buttonHapus_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(textBoxIdPengguna.Text))
//            {
//                MessageBox.Show("Silakan pilih data pengguna yang akan dihapus.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                return;
//            }

//            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
//            if (konfirmasi == DialogResult.Yes)
//            {
//                bool berhasil = userController.DeleteUser(textBoxIdPengguna.Text);
//                MessageBox.Show(berhasil ? "Data berhasil dihapus." : "Gagal menghapus data.");
//                if (berhasil)
//                {
//                    TampilkanDataPengguna();
//                    BersihkanForm();
//                }
//            }
//        }

//        private void BersihkanForm()
//        {
//            textBoxIdPengguna.Clear();
//            textBoxNama.Clear();
//            textBoxEmail.Clear();
//            textBoxNomorHP.Clear();
//            textBoxAlamat.Clear();
//        }
//    }
//}

