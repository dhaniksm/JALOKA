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
        public V_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dasboard katalogBuku = new V_Dasboard();
            katalogBuku.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            V_register v_Register = new V_register();
            v_Register.Show();

        }
    }
}
