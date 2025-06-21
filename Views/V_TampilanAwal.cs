using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JALOKA.Views.Admin;
using JALOKA.Views;       
using JALOKA.Database;
using JALOKA.Helpers;


namespace JALOKA.Views
{
    public partial class V_TampilanAwal : Form
    {
        public V_TampilanAwal()
        {
            InitializeComponent();
            Tabel();
        }

        private void Tabel()
        {
            try
            {
                using (var db = new D_Connector())
                {
                    D_Tabel.CekTabel(db.Connection, "pengguna");
                    D_Tabel.CekTabel(db.Connection, "buku");
                    D_Tabel.CekTabel(db.Connection, "keranjang");
                    D_Tabel.CekTabel(db.Connection, "peminjaman");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memeriksa tabel " + ex.Message);
            }
        }

        private void buttonLoginUser_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            V_Login_P login = new V_Login_P();
            login.Show();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            V_Login_A loginAdmin = new V_Login_A();
            loginAdmin.Show();
        }

        private void buttonLoginKurikulum_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login_K loginKurikulum = new V_Login_K();
            loginKurikulum.Show();

        }
    }
}

