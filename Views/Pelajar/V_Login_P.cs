using JALOKA.Controllers;
using JALOKA.Database;
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
    public partial class V_Login_P : Form
    {
        private C_User c_user = new C_User();
        public static string nisnLogin; 

        public V_Login_P()
        {
            InitializeComponent();
            TabelPengguna();
        }

        private void TabelPengguna()
        {
            try
            {
                using (var db = new D_Connector())
                {
                    D_Tabel.CekTabel(db.Connection, "pengguna");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memeriksa tabel pengguna " + ex.Message);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            M_User user = new M_User
            {
                nisn = textBoxNisn.Text,
                password = textBoxPassword.Text
            };

            bool success = c_user.Login(user);
            if (success)
            {
                nisnLogin = user.nisn; // Simpan ID untuk akses profil
                MessageBox.Show("Berhasil Login!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                V_Dashboard_P dashboard = new V_Dashboard_P();
                dashboard.Show();
            }

            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Register_P register = new V_Register_P();
            register.Show();
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

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }


        private void textBoxIDPelajar_TextChanged(object sender, EventArgs e)
        { 
        
        }


        

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();

        }
    }

}
