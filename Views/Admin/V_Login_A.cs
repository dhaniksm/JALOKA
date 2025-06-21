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
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;


namespace JALOKA.Views.Admin
{
    public partial class V_Login_A : Form
    {
        public V_Login_A()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            C_Admin c_admin = new C_Admin();
            M_Admin admin = new M_Admin
            {
                IdPustakawan = textBoxIDPustakawan.Text,
                Password = textBoxPassword.Text
            };

            try
            {
                c_admin.Login(admin.IdPustakawan, admin.Password);
                if (H_Sesi.LoggedA())
                {
                    H_Sesi.AturSesiA(H_Sesi.IdAdmin);
                    H_Pesan.Sukses($"Selamat Datang Admin");

                    this.Close();
                    V_Dashboard_A dashboard = new V_Dashboard_A();
                    dashboard.Show();
                }
                else
                {
                    H_Pesan.Gagal("Login Gagal");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Login Gagal: " + ex.Message);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();
        }
    }
}
