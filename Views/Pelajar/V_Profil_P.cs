using JALOKA.Controllers;
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
                string nisn = V_Login_P.nisnLogin; // Ambil NISN dari login

                M_User user = userController.GetProfil(nisn);
                if (user != null)
                {
                    textBoxNisn.Text = user.nisn;
                    textBoxNama.Text = user.nama;
                    textBoxEmail.Text = user.email;
                    textBoxTelepon.Text = user.nomor_hp;
                    textBoxAlamat.Text = user.alamat;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
