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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JALOKA.Views.Admin
{
    public partial class V_Peminjaman_A : Form
    {
        private readonly C_Peminjaman c_peminjaman = new C_Peminjaman();

        public V_Peminjaman_A()
        {
            InitializeComponent();
            LoadPengembalian();
        }

        private void LoadPengembalian()
        {
            try
            {
                var data = c_peminjaman.DaftarPeminjamanBelumDikembalikan();
                dataGridViewPeminjaman.AutoGenerateColumns = true;
                dataGridViewPeminjaman.DataSource = null;
                dataGridViewPeminjaman.DataSource = data;

                dataGridViewPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewPeminjaman.Columns.Count == 0)
                    H_Pesan.Peringatan("Belum ada data peminjaman.");

            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat data peminjaman: " + ex.Message);
            }
        }

        private void dataGridViewPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewPeminjaman.Columns.Contains("id_peminjaman"))
            {
                var row = dataGridViewPeminjaman.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["id_peminjaman"].Value.ToString();
            }
        }

        private void dataGridViewPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
