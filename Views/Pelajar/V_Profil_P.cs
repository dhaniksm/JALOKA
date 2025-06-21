using JALOKA.Controllers;
using JALOKA.Helpers;
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

namespace JALOKA.Views
{
    public partial class V_Profil_P : Form
    {
        public V_Profil_P()
        {
            InitializeComponent();
        }

        private void V_Profil_P_Load(object sender, EventArgs e)
        {
            {
                C_User userController = new C_User();
                string nisn = V_Login_P.nisnLogin;

                M_Pengguna user = userController.AmbilProfil(nisn);
                if (user != null)
                {
                    textBoxNisn.Text = user.Nisn;
                    textBoxNama.Text = user.Nama;
                    textBoxEmail.Text = user.Email;
                    textBoxTelepon.Text = user.NomorHp;
                    textBoxAlamat.Text = user.Alamat;
                }
                else
                {
                    H_Pesan.Gagal("Gagal memuat profil");
                }
            }
        }

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Dashboard_P dashboard = new V_Dashboard_P();
            dashboard.Show();
        }
    }
}
