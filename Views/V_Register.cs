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
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registrasi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


