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
    public partial class V_Login : Form
    {
        private C_User c_user = new C_User();
        public V_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new M_User
            {
                id_pelajar = textBoxIDPelajar.Text,
                password = textBoxPassword.Text
            };

            try
            {
                bool success = c_user.Login(user);
                if (success)
                {
                    MessageBox.Show("Berhasil Login!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    V_Dasboard katalogBuku = new V_Dasboard();
                    katalogBuku.Show();
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
            V_Register v_register = new V_Register();
            v_register.Show();

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
    }

}
