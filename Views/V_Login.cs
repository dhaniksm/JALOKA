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
<<<<<<< HEAD
                    this.Close();
                    V_Dasboard katalogBuku = new V_Dasboard();
                    katalogBuku.Show();
=======
                    this.Hide();
                    V_Dashboard_P v_dashboard_pelajar = new V_Dashboard_P();
                    v_dashboard_pelajar.Show();
>>>>>>> 20ae724b9c3a4bf61af12325ed6e67df98dedf64
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
<<<<<<< HEAD

            this.Hide();
            V_Register register = new V_Register();
            register.Show();

=======
            this.Hide();
            V_Register register = new V_Register();
            register.Show();

>>>>>>> 20ae724b9c3a4bf61af12325ed6e67df98dedf64
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
