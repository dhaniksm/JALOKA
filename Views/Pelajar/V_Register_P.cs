using JALOKA.Controllers;
using JALOKA.Models;
using JALOKA.Views;
using JALOKA.Helpers;

namespace JALOKA.Views
{
    public partial class V_Register_P : Form
    {
        private readonly C_User c_user = new C_User();

        public V_Register_P()
        {
            InitializeComponent();
        }

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            new V_Login_P().Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxIDPelajar.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxNoTelp.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                H_Pesan.Peringatan("Semua field wajib diisi.");
                return;
            }

            
            if (!textBoxEmail.Text.Contains("@"))
            {
                H_Pesan.Peringatan("Format email tidak valid.");
                return;
            }

            
            if (!long.TryParse(textBoxNoTelp.Text, out _))
            {
                H_Pesan.Peringatan("Nomor HP hanya boleh berisi angka.");
                return;
            }

            
            var user = new M_User
            {
                nisn = textBoxIDPelajar.Text,
                password = textBoxPassword.Text,
                nama = textBoxNama.Text,
                email = textBoxEmail.Text,
                nomor_hp = textBoxNoTelp.Text,
                alamat = textBoxAlamat.Text
            };

            
            bool success = c_user.Register(user);
            if (success)
            {
                H_Pesan.Sukses("Registrasi berhasil!");
                this.Close();
                new V_Login_P().Show();
            }
            else
            {
                H_Pesan.Gagal("Registrasi gagal. Silakan coba lagi.");
            }
        }
    }
}
