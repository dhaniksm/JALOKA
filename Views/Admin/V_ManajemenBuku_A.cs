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
    public partial class V_ManajemenBuku_A : Form
    {
        public V_ManajemenBuku_A()
        {
            InitializeComponent();
        }

        private void V_ManajemenBuku_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_A dashboard = new V_Dashboard_A();
            dashboard.Show();
        }

        private void buttonManajemenBuku_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DataPengguna_A dataPengguna = new V_DataPengguna_A();
            dataPengguna.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_A riwayatPeminjaman = new V_RiwayatPeminjaman_A();
            riwayatPeminjaman.Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_A pengembalian = new V_Pengembalian_A();
            pengembalian.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login login = new V_Login();
            login.Show();
        }
    }
}
