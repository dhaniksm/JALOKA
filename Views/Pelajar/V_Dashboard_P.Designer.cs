namespace JALOKA.Views
{
    partial class V_Dashboard_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Dashboard_P));
            buttonDashboard = new Button();
            buttonKeluar = new Button();
            buttonKatalogBuku = new Button();
            buttonPeminjaman = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonPengembalian = new Button();
            pictureBoxProfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            SuspendLayout();
            // 
            // buttonDasboard
            // 
            buttonDashboard.BackColor = SystemColors.ControlLightLight;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderColor = Color.White;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = SystemColors.Desktop;
            buttonDashboard.Location = new Point(65, 110);
            buttonDashboard.Name = "buttonDasboard";
            buttonDashboard.Size = new Size(182, 37);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = SystemColors.ControlLightLight;
            buttonKeluar.FlatAppearance.BorderSize = 2;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = SystemColors.ActiveCaptionText;
            buttonKeluar.Location = new Point(65, 547);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(110, 34);
            buttonKeluar.TabIndex = 2;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonKatalogBuku
            // 
            buttonKatalogBuku.BackColor = SystemColors.ControlLightLight;
            buttonKatalogBuku.Cursor = Cursors.Hand;
            buttonKatalogBuku.FlatAppearance.BorderColor = Color.White;
            buttonKatalogBuku.FlatAppearance.BorderSize = 0;
            buttonKatalogBuku.FlatStyle = FlatStyle.Flat;
            buttonKatalogBuku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKatalogBuku.ForeColor = SystemColors.Desktop;
            buttonKatalogBuku.Location = new Point(64, 177);
            buttonKatalogBuku.Name = "buttonKatalogBuku";
            buttonKatalogBuku.Size = new Size(182, 37);
            buttonKatalogBuku.TabIndex = 5;
            buttonKatalogBuku.Text = "Katalog Buku";
            buttonKatalogBuku.UseVisualStyleBackColor = false;
            buttonKatalogBuku.Click += buttonKatalogBuku_Click;
            // 
            // buttonPeminjaman
            // 
            buttonPeminjaman.BackColor = SystemColors.HighlightText;
            buttonPeminjaman.Cursor = Cursors.Hand;
            buttonPeminjaman.FlatAppearance.BorderColor = Color.White;
            buttonPeminjaman.FlatAppearance.BorderSize = 0;
            buttonPeminjaman.FlatStyle = FlatStyle.Flat;
            buttonPeminjaman.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPeminjaman.ForeColor = SystemColors.Desktop;
            buttonPeminjaman.Location = new Point(67, 247);
            buttonPeminjaman.Name = "buttonPeminjaman";
            buttonPeminjaman.Size = new Size(182, 35);
            buttonPeminjaman.TabIndex = 6;
            buttonPeminjaman.Text = "Peminjaman";
            buttonPeminjaman.UseVisualStyleBackColor = false;
            buttonPeminjaman.Click += buttonPeminjaman_Click;
            // 
            // buttonRiwayatPeminjaman
            // 
            buttonRiwayatPeminjaman.BackColor = SystemColors.HighlightText;
            buttonRiwayatPeminjaman.Cursor = Cursors.Hand;
            buttonRiwayatPeminjaman.FlatAppearance.BorderColor = Color.White;
            buttonRiwayatPeminjaman.FlatAppearance.BorderSize = 0;
            buttonRiwayatPeminjaman.FlatStyle = FlatStyle.Flat;
            buttonRiwayatPeminjaman.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRiwayatPeminjaman.ForeColor = SystemColors.Desktop;
            buttonRiwayatPeminjaman.Location = new Point(65, 386);
            buttonRiwayatPeminjaman.Name = "buttonRiwayatPeminjaman";
            buttonRiwayatPeminjaman.Size = new Size(182, 37);
            buttonRiwayatPeminjaman.TabIndex = 7;
            buttonRiwayatPeminjaman.Text = "Riwayat Peminjaman";
            buttonRiwayatPeminjaman.UseVisualStyleBackColor = false;
            buttonRiwayatPeminjaman.Click += buttonRiwayatPeminjaman_Click;
            // 
            // buttonPengembalian
            // 
            buttonPengembalian.BackColor = SystemColors.HighlightText;
            buttonPengembalian.Cursor = Cursors.Hand;
            buttonPengembalian.FlatAppearance.BorderColor = Color.White;
            buttonPengembalian.FlatAppearance.BorderSize = 0;
            buttonPengembalian.FlatStyle = FlatStyle.Flat;
            buttonPengembalian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPengembalian.ForeColor = SystemColors.Desktop;
            buttonPengembalian.Location = new Point(68, 313);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Size = new Size(182, 37);
            buttonPengembalian.TabIndex = 8;
            buttonPengembalian.Text = "Pengembalian";
            buttonPengembalian.UseVisualStyleBackColor = false;
            buttonPengembalian.Click += buttonPengembalian_Click;
            // 
<<<<<<< HEAD
            // pictureBoxProfil
            // 
            pictureBoxProfil.BackColor = Color.Transparent;
            pictureBoxProfil.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfil.Cursor = Cursors.Hand;
            pictureBoxProfil.Location = new Point(22, 11);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new Size(57, 54);
            pictureBoxProfil.TabIndex = 28;
            pictureBoxProfil.TabStop = false;
            pictureBoxProfil.Click += pictureBoxProfil_Click;
            // 
=======
>>>>>>> Dhani
            // V_Dashboard_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxProfil);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonPeminjaman);
            Controls.Add(buttonKatalogBuku);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Dashboard_P";
            StartPosition = FormStartPosition.CenterScreen;
<<<<<<< HEAD
            Text = "KatalogBuku";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
=======
            Text = "V_Dashboard_P";
>>>>>>> Dhani
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDashboard;
        private Button buttonKeluar;
        private Button buttonKatalogBuku;
        private Button buttonPeminjaman;
        private Button buttonRiwayatPeminjaman;
        private Button buttonPengembalian;
        private PictureBox pictureBoxProfil;
    }
}