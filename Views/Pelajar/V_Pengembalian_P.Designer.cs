namespace JALOKA.Views
{
    partial class V_Pengembalian_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Pengembalian_P));
            buttonPengembalian = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonPeminjaman = new Button();
            buttonKatalogBuku = new Button();
            buttonKeluar = new Button();
            buttonDasboard = new Button();
            pictureBoxProfil = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listViewPeminjaman = new ListView();
            ID_Peminjaman = new ColumnHeader();
            Judul_Buku = new ColumnHeader();
            Tanggal_pinjam = new ColumnHeader();
            buttonKembalikan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            buttonPengembalian.Location = new Point(69, 313);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Size = new Size(182, 37);
            buttonPengembalian.TabIndex = 14;
            buttonPengembalian.Text = "Pengembalian";
            buttonPengembalian.UseVisualStyleBackColor = false;
            buttonPengembalian.Click += buttonPengembalian_Click;
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
            buttonRiwayatPeminjaman.Location = new Point(66, 386);
            buttonRiwayatPeminjaman.Name = "buttonRiwayatPeminjaman";
            buttonRiwayatPeminjaman.Size = new Size(182, 37);
            buttonRiwayatPeminjaman.TabIndex = 13;
            buttonRiwayatPeminjaman.Text = "Riwayat Peminjaman";
            buttonRiwayatPeminjaman.UseVisualStyleBackColor = false;
            buttonRiwayatPeminjaman.Click += buttonRiwayatPeminjaman_Click;
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
            buttonPeminjaman.Location = new Point(68, 247);
            buttonPeminjaman.Name = "buttonPeminjaman";
            buttonPeminjaman.Size = new Size(182, 35);
            buttonPeminjaman.TabIndex = 12;
            buttonPeminjaman.Text = "Peminjaman";
            buttonPeminjaman.UseVisualStyleBackColor = false;
            buttonPeminjaman.Click += buttonPeminjaman_Click;
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
            buttonKatalogBuku.Location = new Point(65, 177);
            buttonKatalogBuku.Name = "buttonKatalogBuku";
            buttonKatalogBuku.Size = new Size(182, 37);
            buttonKatalogBuku.TabIndex = 11;
            buttonKatalogBuku.Text = "Katalog Buku";
            buttonKatalogBuku.UseVisualStyleBackColor = false;
            buttonKatalogBuku.Click += buttonKatalogBuku_Click;
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = SystemColors.ControlLightLight;
            buttonKeluar.FlatAppearance.BorderSize = 2;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = SystemColors.ActiveCaptionText;
            buttonKeluar.Location = new Point(66, 546);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(110, 34);
            buttonKeluar.TabIndex = 10;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonDasboard
            // 
            buttonDasboard.BackColor = SystemColors.ControlLightLight;
            buttonDasboard.Cursor = Cursors.Hand;
            buttonDasboard.FlatAppearance.BorderColor = Color.White;
            buttonDasboard.FlatAppearance.BorderSize = 0;
            buttonDasboard.FlatStyle = FlatStyle.Flat;
            buttonDasboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDasboard.ForeColor = SystemColors.Desktop;
            buttonDasboard.Location = new Point(66, 110);
            buttonDasboard.Name = "buttonDasboard";
            buttonDasboard.Size = new Size(182, 37);
            buttonDasboard.TabIndex = 9;
            buttonDasboard.Text = "Dasboard";
            buttonDasboard.UseVisualStyleBackColor = false;
            buttonDasboard.Click += buttonDasboard_Click;
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.BackColor = Color.Transparent;
            pictureBoxProfil.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfil.Cursor = Cursors.Hand;
            pictureBoxProfil.Location = new Point(21, 8);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new Size(57, 54);
            pictureBoxProfil.TabIndex = 29;
            pictureBoxProfil.TabStop = false;
            pictureBoxProfil.Click += pictureBoxProfil_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(listViewPeminjaman);
            flowLayoutPanel1.Controls.Add(buttonKembalikan);
            flowLayoutPanel1.Location = new Point(259, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(929, 580);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // listViewPeminjaman
            // 
            listViewPeminjaman.Columns.AddRange(new ColumnHeader[] { ID_Peminjaman, Judul_Buku, Tanggal_pinjam });
            listViewPeminjaman.Location = new Point(3, 3);
            listViewPeminjaman.Name = "listViewPeminjaman";
            listViewPeminjaman.Size = new Size(707, 501);
            listViewPeminjaman.TabIndex = 0;
            listViewPeminjaman.UseCompatibleStateImageBehavior = false;
            listViewPeminjaman.View = View.Details;
            listViewPeminjaman.SelectedIndexChanged += listViewPeminjaman_SelectedIndexChanged;
            // 
            // ID_Peminjaman
            // 
            ID_Peminjaman.Text = "ID Peminjaman";
            ID_Peminjaman.Width = 120;
            // 
            // Judul_Buku
            // 
            Judul_Buku.Text = "Judul Buku";
            Judul_Buku.TextAlign = HorizontalAlignment.Center;
            Judul_Buku.Width = 250;
            // 
            // Tanggal_pinjam
            // 
            Tanggal_pinjam.Text = "Tanggal Pinjam";
            Tanggal_pinjam.TextAlign = HorizontalAlignment.Center;
            Tanggal_pinjam.Width = 150;
            // 
            // buttonKembalikan
            // 
            buttonKembalikan.Location = new Point(716, 3);
            buttonKembalikan.Name = "buttonKembalikan";
            buttonKembalikan.Size = new Size(124, 29);
            buttonKembalikan.TabIndex = 1;
            buttonKembalikan.Text = "Kembalikan";
            buttonKembalikan.UseVisualStyleBackColor = true;
            buttonKembalikan.Click += buttonKembalikan_Click;
            // 
            // V_Pengembalian_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBoxProfil);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonPeminjaman);
            Controls.Add(buttonKatalogBuku);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonDasboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Pengembalian_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Pengembalian";
            Load += V_Pengembalian_P_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);


        }

        #endregion

        private Button buttonPengembalian;
        private Button buttonRiwayatPeminjaman;
        private Button buttonPeminjaman;
        private Button buttonKatalogBuku;
        private Button buttonKeluar;
        private Button buttonDasboard;
        private PictureBox pictureBoxProfil;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView listViewPeminjaman;
        private ColumnHeader ID_Peminjaman;
        private ColumnHeader Judul_Buku;
        private ColumnHeader Tanggal_pinjam;
        private Button buttonKembalikan;
    }
}