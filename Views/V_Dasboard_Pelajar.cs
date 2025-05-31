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
    public partial class V_Dasboard_Pelajar : Form
    {
        public V_Dasboard_Pelajar()
        {
            InitializeComponent();
        }



        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

       
        private void buttonKatalogBuku_Click(object sender, EventArgs e)
        {

        }
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login v_Login = new V_Login();
            v_Login.Show();

        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {

        }

       
    }
}
