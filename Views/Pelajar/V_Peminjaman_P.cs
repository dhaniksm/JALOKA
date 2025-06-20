﻿using JALOKA.Controllers;
using JALOKA.Database;
using JALOKA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using JALOKA.Helpers;
using JALOKA.Views.Admin;

namespace JALOKA.Views
{
    public partial class V_Peminjaman_P : Form
    {
        C_Peminjaman controller = new C_Peminjaman();
        private List<M_Buku> keranjang;

        public V_Peminjaman_P()
        {
            InitializeComponent();
            MuatKeranjang();
            MuatMenunggu();
        }

        private void MuatKeranjang()
        {
            try
            {
                flowLayoutPanelKeranjang.Controls.Clear();
                keranjang = controller.AmbilKeranjang();

                if (keranjang.Count == 0)
                {
                    Label kosong = new Label()
                    {
                        Text = "Keranjang kosong.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12),
                        ForeColor = Color.Gray
                    };
                    flowLayoutPanelKeranjang.Controls.Add(kosong);
                    return;
                }

                foreach (var buku in keranjang)
                {
                    var panel = BuatPanelBuku(buku, "Ajukan", () =>
                    {
                        controller.AjukanPeminjaman(buku.IdBuku);
                        MuatKeranjang();
                        MuatMenunggu();
                    });
                    flowLayoutPanelKeranjang.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat keranjang: " + ex.Message);
            }
        }

        private void MuatMenunggu()
        {
            try
            {
                flowLayoutPanelMenunggu.Controls.Clear();
                var menunggu = controller.MenungguKonfirmasi();

                foreach (var peminjaman in menunggu)
                {
                    var panel = BuatPanelBuku(peminjaman.Buku, "Menunggu", null, true);
                    flowLayoutPanelMenunggu.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal memuat peminjaman menunggu: " + ex.Message);
            }
        }

        private Panel BuatPanelBuku(M_Buku buku, string tombolText, Action onClick, bool disabled = false)
        {
            Panel panel = new Panel
            {
                Width = 500,
                Height = 120,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox cover = new PictureBox
            {
                Width = 80,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = buku.Cover != null ? H_Konversi.ByteArrayToImage(buku.Cover) : null,
                Left = 10,
                Top = 10
            };
            panel.Controls.Add(cover);

            Label lblJudul = new Label
            {
                Text = buku.Judul,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(100, 10)
            };
            panel.Controls.Add(lblJudul);

            Label lblPenulis = new Label
            {
                Text = $"Penulis: {buku.Penulis}",
                AutoSize = true,
                Location = new Point(100, 35)
            };
            panel.Controls.Add(lblPenulis);

            Label lblPenerbit = new Label
            {
                Text = $"Penerbit: {buku.Penerbit}",
                AutoSize = true,
                Location = new Point(100, 55)
            };
            panel.Controls.Add(lblPenerbit);

            Label lblTahun = new Label
            {
                Text = $"Tahun: {buku.TahunTerbit}",
                AutoSize = true,
                Location = new Point(100, 75)
            };
            panel.Controls.Add(lblTahun);

            Button btnHapus = new Button
            {
                Text = "Hapus",
                Width = 60,
                Height = 25,
                Location = new Point(420, 80),
                BackColor = Color.Tomato
            };
            btnHapus.Click += (s, e) =>
            {
                controller.HapusDariKeranjang(buku.IdBuku);
                MuatKeranjang();
            };

            panel.Controls.Add(btnHapus);

            return panel;
        }

        private void buttonDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_P dashboard = new V_Dashboard_P();
            dashboard.Show();
        }

        private void buttonKatalogBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_KatalogBuku_P katalogbuku = new V_KatalogBuku_P();
            katalogbuku.Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
            V_RiwayatPeminjaman_P riwayatPeminjaman = new V_RiwayatPeminjaman_P();
            riwayatPeminjaman.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login_P login = new V_Login_P();
            login.Show();
        }

        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            controller.ProsesPeminjaman();
            MuatKeranjang();
            MuatMenunggu();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
