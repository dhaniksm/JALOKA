namespace JALOKA.Views
{
    partial class V_Peminjaman_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Peminjaman_P));
            buttonPengembalian = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonPeminjaman = new Button();
            buttonKatalogBuku = new Button();
            buttonKeluar = new Button();
            buttonDasboard = new Button();
            dataGridViewKeranjang = new DataGridView();
            id_buku = new DataGridViewTextBoxColumn();
            judul = new DataGridViewTextBoxColumn();
            penulis = new DataGridViewTextBoxColumn();
            tahun_terbit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).BeginInit();
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
            buttonPengembalian.TabIndex = 20;
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
            buttonRiwayatPeminjaman.TabIndex = 19;
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
            buttonPeminjaman.TabIndex = 18;
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
            buttonKatalogBuku.TabIndex = 17;
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
            buttonKeluar.TabIndex = 16;
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
            buttonDasboard.TabIndex = 15;
            buttonDasboard.Text = "Dasboard";
            buttonDasboard.UseVisualStyleBackColor = false;
            buttonDasboard.Click += buttonDasboard_Click;
            // 
            // dataGridViewKeranjang
            // 
            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKeranjang.Columns.AddRange(new DataGridViewColumn[] { id_buku, judul, penulis, tahun_terbit });
            dataGridViewKeranjang.Location = new Point(253, 78);
            dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            dataGridViewKeranjang.ReadOnly = true;
            dataGridViewKeranjang.RowHeadersWidth = 51;
            dataGridViewKeranjang.Size = new Size(553, 188);
            dataGridViewKeranjang.TabIndex = 21;
            // 
            // id_buku
            // 
            id_buku.HeaderText = "ID Buku";
            id_buku.MinimumWidth = 6;
            id_buku.Name = "id_buku";
            id_buku.ReadOnly = true;
            id_buku.Width = 125;
            // 
            // judul
            // 
            judul.HeaderText = "Judul";
            judul.MinimumWidth = 6;
            judul.Name = "judul";
            judul.ReadOnly = true;
            judul.Width = 125;
            // 
            // penulis
            // 
            penulis.HeaderText = "Penulis";
            penulis.MinimumWidth = 6;
            penulis.Name = "penulis";
            penulis.ReadOnly = true;
            penulis.Width = 125;
            // 
            // tahun_terbit
            // 
            tahun_terbit.HeaderText = "Tahun Terbit";
            tahun_terbit.MinimumWidth = 6;
            tahun_terbit.Name = "tahun_terbit";
            tahun_terbit.ReadOnly = true;
            tahun_terbit.Width = 125;
            // 
            // V_Peminjaman_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(dataGridViewKeranjang);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonPeminjaman);
            Controls.Add(buttonKatalogBuku);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonDasboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Peminjaman_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Peminjaman_Pelajar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPengembalian;
        private Button buttonRiwayatPeminjaman;
        private Button buttonPeminjaman;
        private Button buttonKatalogBuku;
        private Button buttonKeluar;
        private Button buttonDasboard;
        private DataGridView dataGridViewKeranjang;
        private DataGridViewTextBoxColumn id_buku;
        private DataGridViewTextBoxColumn judul;
        private DataGridViewTextBoxColumn penulis;
        private DataGridViewTextBoxColumn tahun_terbit;
    }
}