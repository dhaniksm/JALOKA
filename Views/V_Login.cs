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
                V_Dasboard katalogBuku = new V_Dasboard();
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
    }
}
