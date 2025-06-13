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
using JALOKA.Views;

namespace JALOKA.Views
{
    public partial class V_KatalogBuku_P : Form
    {
        private C_Buku c_buku = new C_Buku();
        public V_KatalogBuku_P()
        {
            InitializeComponent();
            TabelBuku();
            TampilkanBuku();
        }

        public void TabelBuku()
        {
            try
            {
                using (var db = new D_Connector())
                {
                    D_Tabel.CekTabel(db.Connection, "buku");
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memeriksa tabel buku: " + ex.Message);
            }
        }

        private void TampilkanBuku()
        {
            try
            {
                flowLayoutPanelCover.Controls.Clear();
                var daftarBuku = c_buku.AmbilSemua();

                foreach (var buku in daftarBuku)
                {
                    Panel panel = new Panel
                    {
                        Height = 400,
                        Width = 400,
                        Margin = new Padding(10)
                    };

                    PictureBox cover = new PictureBox
                    {
                        Width = 120,
                        Height = 150,
                        Image = H_Konversi.ByteArrayToImage(buku.cover),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Top = 5,
                        Left = 10,
                        Cursor = Cursors.Hand,
                        Tag = buku
                    };
                    cover.Click += Cover_Click;

                    Label judul = new Label
                    {
                        Text = buku.judul,
                        Width = 100,
                        Height = 40,
                        Top = 160,
                        Left = 10,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    panel.Controls.Add(cover);
                    panel.Controls.Add(judul);
                    flowLayoutPanelCover.Controls.Add(panel);
                }

            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat buku: " + ex.Message);
            }
        }

        private void Cover_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is M_Buku buku)
            {
                var detail = new V_DetailBuku_P(buku.id_buku);
                detail.ShowDialog();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_P dashboard = new V_Dashboard_P();
            dashboard.Show();
        }

        private void buttonKatalogBuku_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Peminjaman_P peminjaman = new V_Peminjaman_P();
            peminjaman.Show();
        }

        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_P pengembalian = new V_Pengembalian_P();
            pengembalian.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_RiwayatPeminjaman_P riwayat = new V_RiwayatPeminjaman_P();
            riwayat.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Login login = new V_Login();
            login.Show();
        }
    }
}
