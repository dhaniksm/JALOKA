using JALOKA.Controllers;
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
        private C_User C_User = new C_User();
        public V_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (C_User.Login(textBoxIDPelajar.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Login Berhasil!");
                this.Hide();
                V_Dasboard_Pelajar katalogBuku = new V_Dasboard_Pelajar();
                katalogBuku.Show();
            }
            else
            {
                MessageBox.Show("Login gagal, periksa kembali.");
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
