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
using JALOKA.Views.Pelajar;

namespace JALOKA.Views
{
    public partial class V_KatalogBuku_P : Form
    {
        private readonly C_Buku c_buku = new C_Buku ();
        public V_KatalogBuku_P()
        {
            InitializeComponent();
        }

        private void TampilkanBuku()
        {
            var daftarBuku = c_buku.DaftarBuku();
            flowLayoutPanelCover.Controls.Clear();

            foreach (var buku in daftarBuku)
            {
                var panel = new Panel { Width = 120, Height = 180, Margin = new Padding(10) };

                var cover = new PictureBox
                {
                    Width = 100,
                    Height = 120,
                    Image = File.Exists(buku.cover_path) ? Image.FromFile(buku.cover_path) : null,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = buku
                };
                cover.Click += Cover_Click;

                var label = new Label
                {
                    Text = buku.judul,
                    AutoSize = false,
                    Width = 100,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                panel.Controls.Add(cover);
                panel.Controls.Add(label);
                flowLayoutPanelCover.Controls.Add(panel);
            }
        }

        private void Cover_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is M_Buku buku)
            {
                var detail = new V_DetailBuku_P(buku);
                detail.ShowDialog();
            }
        }
    }
}
