using JALOKA.Controllers;
using JALOKA.Models;
using JALOKA.Views;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JALOKA.Views
{
    public partial class V_Register_P : Form
    {
        private C_User c_user = new C_User();
        public V_Register_P()
        {
            InitializeComponent();
        }

<<<<<<< HEAD:Views/Pelajar/V_Register_P.cs
        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Login_P login = new V_Login_P();
            login.Show();

        }

=======
>>>>>>> Dhani:Views/V_Register.cs
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBoxNoTelp.Text, out _))
            {
                MessageBox.Show("Nomor HP hanya boleh berisi angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            M_User user = new M_User
            {
<<<<<<< HEAD:Views/Pelajar/V_Register_P.cs
                nisn = textBoxIDPelajar.Text,
=======
                id_user = textBoxIDPelajar.Text,
>>>>>>> Dhani:Views/V_Register.cs
                password = textBoxPassword.Text,
                nama = textBoxNama.Text,
                email = textBoxEmail.Text,
                nomor_hp = textBoxNoTelp.Text,
                alamat = textBoxAlamat.Text
            };
<<<<<<< HEAD:Views/Pelajar/V_Register_P.cs
=======

>>>>>>> Dhani:Views/V_Register.cs
            try
            {
                if (c_user.Register(user))
                {
                    MessageBox.Show("Registrasi berhasil!");
                    this.Close();
<<<<<<< HEAD:Views/Pelajar/V_Register_P.cs
                    V_Login_P Login = new V_Login_P();
                    Login.Show();
=======
                    V_Login login = new V_Login();
                    login.Show();
>>>>>>> Dhani:Views/V_Register.cs
                }
                else
                {
                    MessageBox.Show("Registrasi gagal.");
                }
<<<<<<< HEAD:Views/Pelajar/V_Register_P.cs
                MessageBox.Show("Registrasi berhasil!");
                this.Close();
                V_Login_P login = new V_Login_P();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registrasi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> Dhani:Views/V_Register.cs
            }
        }
    }
}


