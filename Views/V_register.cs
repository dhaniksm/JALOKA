using JALOKA.Controllers;
using JALOKA.Models;
using JALOKA.Views;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JALOKA.Views
{
    public partial class V_Register : Form
    {
        private C_User c_user = new C_User();
        public V_Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            M_User user = new M_User
            {
                id_pelajar = textBoxIDPelajar.Text,
                password = textBoxPassword.Text,
                nama = textBoxNama.Text,
                email = textBoxEmail.Text,
                nomor_hp = textBoxNoTelp.Text,
                alamat = textBoxAlamat.Text
            };

<<<<<<< HEAD
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

=======
            if (c_user.Register(user))
            {
                MessageBox.Show("Registrasi berhasil!");
                this.Close();
                V_Login login = new V_Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Registrasi gagal.");
            }
>>>>>>> 15a9b544aa66d8e53f926aecbb43868ee0da6167
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDPelajar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNoTelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


