﻿namespace JALOKA.Views
{
    partial class V_RiwayatPeminjaman_A
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatPeminjaman_A));
            buttonKeluar = new Button();
            button8 = new Button();
            buttonDataPengguna = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonDashboard = new Button();
            buttonPengembalian = new Button();
            SuspendLayout();
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = SystemColors.ControlLightLight;
            buttonKeluar.Cursor = Cursors.Hand;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.Location = new Point(69, 566);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(104, 34);
            buttonKeluar.TabIndex = 13;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(58, 188);
            button8.Name = "button8";
            button8.Size = new Size(187, 29);
            button8.TabIndex = 12;
            button8.Text = "Manajemen Buku";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonManajemenBuku_Click;
            // 
            // buttonDataPengguna
            // 
            buttonDataPengguna.BackColor = SystemColors.ControlLightLight;
            buttonDataPengguna.Cursor = Cursors.Hand;
            buttonDataPengguna.FlatAppearance.BorderSize = 0;
            buttonDataPengguna.FlatStyle = FlatStyle.Flat;
            buttonDataPengguna.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDataPengguna.Location = new Point(58, 265);
            buttonDataPengguna.Name = "buttonDataPengguna";
            buttonDataPengguna.Size = new Size(187, 29);
            buttonDataPengguna.TabIndex = 11;
            buttonDataPengguna.Text = "Data Pengguna";
            buttonDataPengguna.UseVisualStyleBackColor = false;
            buttonDataPengguna.Click += buttonDataPengguna_Click;
            // 
            // buttonRiwayatPeminjaman
            // 
            buttonRiwayatPeminjaman.BackColor = SystemColors.ControlLightLight;
            buttonRiwayatPeminjaman.Cursor = Cursors.Hand;
            buttonRiwayatPeminjaman.FlatAppearance.BorderSize = 0;
            buttonRiwayatPeminjaman.FlatStyle = FlatStyle.Flat;
            buttonRiwayatPeminjaman.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRiwayatPeminjaman.Location = new Point(58, 345);
            buttonRiwayatPeminjaman.Name = "buttonRiwayatPeminjaman";
            buttonRiwayatPeminjaman.Size = new Size(187, 29);
            buttonRiwayatPeminjaman.TabIndex = 10;
            buttonRiwayatPeminjaman.Text = "RIwayat Peminjaman";
            buttonRiwayatPeminjaman.UseVisualStyleBackColor = false;
            buttonRiwayatPeminjaman.Click += buttonRiwayatPeminjaman_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = SystemColors.ControlLightLight;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.Location = new Point(58, 117);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(187, 29);
            buttonDashboard.TabIndex = 9;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonPengembalian
            // 
            buttonPengembalian.BackColor = SystemColors.ControlLightLight;
            buttonPengembalian.Cursor = Cursors.Hand;
            buttonPengembalian.FlatAppearance.BorderSize = 0;
            buttonPengembalian.FlatStyle = FlatStyle.Flat;
            buttonPengembalian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPengembalian.Location = new Point(59, 421);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Size = new Size(187, 29);
            buttonPengembalian.TabIndex = 14;
            buttonPengembalian.Text = "Pengembalian";
            buttonPengembalian.UseVisualStyleBackColor = false;
            buttonPengembalian.Click += buttonPengembalian_Click;
            // 
            // V_RiwayatPeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonKeluar);
            Controls.Add(button8);
            Controls.Add(buttonDataPengguna);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_RiwayatPeminjaman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_RiwayatPeminjaman";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKeluar;
        private Button button8;
        private Button buttonDataPengguna;
        private Button buttonRiwayatPeminjaman;
        private Button buttonDashboard;
        private Button buttonPengembalian;
    }
}