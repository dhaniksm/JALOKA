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
    public partial class V_KatalogBuku_P : Form
    {
        public V_KatalogBuku_P()
        {
            InitializeComponent();
        }



        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Profil_P v_Profil_P = new V_Profil_P();
            v_Profil_P.ShowDialog();

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal tampilanAwal = new V_TampilanAwal();
            tampilanAwal.Show();
        }
    }
}
