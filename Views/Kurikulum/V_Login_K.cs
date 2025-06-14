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
using JALOKA.Models;

namespace JALOKA.Views
{
    public partial class V_Login_K : Form
    {
        private C_Kurikulum c_kurikulum = new C_Kurikulum();
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

        private void textBoxIDKurikulum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var kurikulum = new M_Kurikulum
            {
                id_kurikulum = textBoxIDKurikulum.Text,
                password = textBoxPassword.Text
            };
            try
            {
                bool success = new C_Kurikulum().login(kurikulum);
                if (success)
                {
                    MessageBox.Show("Berhasil Login!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    V_Dashboard_K dashboard = new V_Dashboard_K();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("ID Kurikulum atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
