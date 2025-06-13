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
    public partial class V_Login_P : Form
    {
        private C_User c_user = new C_User();
        public static string nisnLogin; 

        public V_Login_P()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = new M_User
            {
                nisn = textBoxNisn.Text,
                password = textBoxPassword.Text
            };

            try
            {
                bool success = c_user.Login(user);
                if (success)
                {
                    nisnLogin = textBoxNisn.Text;
                    MessageBox.Show("Berhasil Login!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    V_Dashboard_P dashboard = new V_Dashboard_P();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("ID atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();
        }
    }

}
