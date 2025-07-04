﻿using JALOKA.Controllers;
using JALOKA.Database;
using JALOKA.Helpers;
using JALOKA.Models;
using JALOKA.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JALOKA.Views
{
    public partial class V_ManajemenBuku_A : Form
    {
        private C_Buku c_buku = new C_Buku();

        public V_ManajemenBuku_A()
        {
            InitializeComponent();
            MuatBuku();
        }

        private void MuatBuku()
        {
            try
            {
                flowLayoutPanelBuku.Controls.Clear();
                var daftarBuku = c_buku.AmbilSemua();

                foreach (var buku in daftarBuku)
                {
                    var panel = new Panel
                    {
                        Width = 200,
                        Height = 250,
                        Margin = new Padding(10)
                    };

                    PictureBox cover = new PictureBox
                    {
                        Width = 120,
                        Height = 150,
                        Image = H_Konversi.ByteArrayToImage(buku.Cover),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Top = 5,
                        Left = 10,
                        Cursor = Cursors.Hand,
                        Tag = buku
                    };
                    cover.Click += Cover_Click;

                    Label judul = new Label
                    {
                        Text = buku.Judul,
                        Width = 120,
                        Height = 40,
                        Top = 160,
                        Left = 10,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    panel.Controls.Add(cover);
                    panel.Controls.Add(judul);
                    flowLayoutPanelBuku.Controls.Add(panel);
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
                var detail = new V_DetailBuku_A(buku.IdBuku);
                detail.Show();
                this.Close();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Dashboard_A dashboard = new V_Dashboard_A();
            dashboard.Show();
        }

        private void buttonManajemenBuku_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonDataPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DataPengguna_A dataPengguna = new V_DataPengguna_A();
            dataPengguna.Show();
        }
        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Peminjaman_A peminjaman = new V_Peminjaman_A();
            peminjaman.Show();
        }
        private void buttonPengembalian_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Pengembalian_A pengembalian = new V_Pengembalian_A();
            pengembalian.Show();
        }

        private void buttonRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();

            V_RiwayatPeminjaman_A riwayat = new V_RiwayatPeminjaman_A();
            riwayat.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            V_TampilanAwal v_TampilanAwal = new V_TampilanAwal();
            v_TampilanAwal.Show();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            V_TambahBuku_A tambah = new V_TambahBuku_A();
            tambah.Show();
            this.Close();
        }

    }
}
