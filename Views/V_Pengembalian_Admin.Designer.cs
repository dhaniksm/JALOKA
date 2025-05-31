namespace JALOKA.Views
{
    partial class V_Pengembalian_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Pengembalian_Admin));
            buttonPengembalian = new Button();
            buttonKeluar = new Button();
            buttonManajemenBuku = new Button();
            buttonDataPengguna = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonDashboard = new Button();
            SuspendLayout();
            // 
            // buttonPengembalian
            // 
            buttonPengembalian.BackColor = SystemColors.ControlLightLight;
            buttonPengembalian.Cursor = Cursors.Hand;
            buttonPengembalian.FlatAppearance.BorderSize = 0;
            buttonPengembalian.FlatStyle = FlatStyle.Flat;
            buttonPengembalian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPengembalian.Location = new Point(59, 419);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Size = new Size(187, 29);
            buttonPengembalian.TabIndex = 26;
            buttonPengembalian.Text = "Pengembalian";
            buttonPengembalian.UseVisualStyleBackColor = false;
            buttonPengembalian.Click += buttonPengembalian_Click;
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = SystemColors.ControlLightLight;
            buttonKeluar.Cursor = Cursors.Hand;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.Location = new Point(69, 564);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(104, 34);
            buttonKeluar.TabIndex = 25;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonManajemenBuku
            // 
            buttonManajemenBuku.BackColor = SystemColors.ControlLightLight;
            buttonManajemenBuku.Cursor = Cursors.Hand;
            buttonManajemenBuku.FlatAppearance.BorderSize = 0;
            buttonManajemenBuku.FlatStyle = FlatStyle.Flat;
            buttonManajemenBuku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManajemenBuku.Location = new Point(58, 186);
            buttonManajemenBuku.Name = "buttonManajemenBuku";
            buttonManajemenBuku.Size = new Size(187, 29);
            buttonManajemenBuku.TabIndex = 24;
            buttonManajemenBuku.Text = "Manajemen Buku";
            buttonManajemenBuku.UseVisualStyleBackColor = false;
            buttonManajemenBuku.Click += buttonManajemenBuku_Click;
            // 
            // buttonDataPengguna
            // 
            buttonDataPengguna.BackColor = SystemColors.ControlLightLight;
            buttonDataPengguna.Cursor = Cursors.Hand;
            buttonDataPengguna.FlatAppearance.BorderSize = 0;
            buttonDataPengguna.FlatStyle = FlatStyle.Flat;
            buttonDataPengguna.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDataPengguna.Location = new Point(58, 263);
            buttonDataPengguna.Name = "buttonDataPengguna";
            buttonDataPengguna.Size = new Size(187, 29);
            buttonDataPengguna.TabIndex = 23;
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
            buttonRiwayatPeminjaman.Location = new Point(58, 343);
            buttonRiwayatPeminjaman.Name = "buttonRiwayatPeminjaman";
            buttonRiwayatPeminjaman.Size = new Size(187, 29);
            buttonRiwayatPeminjaman.TabIndex = 22;
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
            buttonDashboard.Location = new Point(58, 115);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(187, 29);
            buttonDashboard.TabIndex = 21;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // V_PengembalianAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonManajemenBuku);
            Controls.Add(buttonDataPengguna);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_PengembalianAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_PengembalianAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPengembalian;
        private Button buttonKeluar;
        private Button buttonManajemenBuku;
        private Button buttonDataPengguna;
        private Button buttonRiwayatPeminjaman;
        private Button buttonDashboard;
    }
}