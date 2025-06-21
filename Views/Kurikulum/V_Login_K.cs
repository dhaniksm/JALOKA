using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JALOKA.Controllers;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;

namespace JALOKA.Views
{
    public partial class V_Login_K : Form
    {
        public V_Login_K()
        {
            InitializeComponent();
        }

        private void pictureBoxKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var kurikulum = new M_Kurikulum
            {
                IdKurikulum = textBoxIDKurikulum.Text,
                Password = textBoxPassword.Text
            };

            var controller = new C_Kurikulum();
            bool success = controller.Login(kurikulum.IdKurikulum, kurikulum.Password);

            if (success)
            {
                H_Pesan.Sukses("Login Berhasil");
                this.Close();
                V_Dashboard_K dashboard = new V_Dashboard_K();
                dashboard.Show();
            }
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
    }
}
