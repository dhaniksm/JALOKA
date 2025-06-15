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
        private C_Admin c_admin = new C_Admin();

        public V_Login_A()
        {
            InitializeComponent();
            TabelAdmin();
        }

        private void TabelAdmin()
        {
            try
            {
                using (var db = new D_Connector())
                {
                    D_Tabel.CekTabel(db.Connection, "admin");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memeriksa tabel admin: " + ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var admin = new M_Admin
            {
                id_pustakawan = textBoxIDPustakawan.Text,
                password = textBoxPassword.Text
            };

            bool success = c_admin.Login(admin);
            if (success)
            {
                MessageBox.Show("Berhasil Login!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                V_Dashboard_A dashboard = new V_Dashboard_A();
                dashboard.Show();
            }

            
        }

        private void textBoxIDPustakawan_TextChanged(object sender, EventArgs e)
        {

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
