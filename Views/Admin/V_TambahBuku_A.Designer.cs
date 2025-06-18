namespace JALOKA.Views.Admin
{
    partial class V_TambahBuku_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TambahBuku_A));
            pictureBoxCover = new PictureBox();
            textBoxJudul = new TextBox();
            textBoxPenulis = new TextBox();
            textBoxPenerbit = new TextBox();
            textBoxTahunTerbit = new TextBox();
            textBoxSinopsis = new TextBox();
            buttonKembali = new Button();
            buttonKonfirmasi = new Button();
            buttonPilihGambar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.BackColor = SystemColors.ControlLightLight;
            pictureBoxCover.Location = new Point(94, 169);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(300, 387);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCover.TabIndex = 0;
            pictureBoxCover.TabStop = false;
            pictureBoxCover.Click += pictureBoxCover_Click;
            // 
            // textBoxJudul
            // 
            textBoxJudul.BorderStyle = BorderStyle.FixedSingle;
            textBoxJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxJudul.Location = new Point(94, 573);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.PlaceholderText = "Masukkan Judul";
            textBoxJudul.Size = new Size(300, 34);
            textBoxJudul.TabIndex = 1;
            textBoxJudul.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPenulis
            // 
            textBoxPenulis.BorderStyle = BorderStyle.None;
            textBoxPenulis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPenulis.Location = new Point(599, 159);
            textBoxPenulis.Name = "textBoxPenulis";
            textBoxPenulis.PlaceholderText = "Masukkan Penulis";
            textBoxPenulis.Size = new Size(300, 20);
            textBoxPenulis.TabIndex = 2;
            // 
            // textBoxPenerbit
            // 
            textBoxPenerbit.BorderStyle = BorderStyle.None;
            textBoxPenerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPenerbit.Location = new Point(599, 231);
            textBoxPenerbit.Name = "textBoxPenerbit";
            textBoxPenerbit.PlaceholderText = "Masukkan Penerbit";
            textBoxPenerbit.Size = new Size(300, 20);
            textBoxPenerbit.TabIndex = 3;
            // 
            // textBoxTahunTerbit
            // 
            textBoxTahunTerbit.BorderStyle = BorderStyle.None;
            textBoxTahunTerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTahunTerbit.Location = new Point(599, 310);
            textBoxTahunTerbit.Name = "textBoxTahunTerbit";
            textBoxTahunTerbit.PlaceholderText = "Masukkan Tahun Terbit";
            textBoxTahunTerbit.Size = new Size(300, 20);
            textBoxTahunTerbit.TabIndex = 4;
            // 
            // textBoxSinopsis
            // 
            textBoxSinopsis.BorderStyle = BorderStyle.None;
            textBoxSinopsis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSinopsis.Location = new Point(570, 413);
            textBoxSinopsis.Multiline = true;
            textBoxSinopsis.Name = "textBoxSinopsis";
            textBoxSinopsis.PlaceholderText = "Masukkan Sinopsis";
            textBoxSinopsis.Size = new Size(430, 210);
            textBoxSinopsis.TabIndex = 5;
            // 
            // buttonKembali
            // 
            buttonKembali.BackColor = SystemColors.ControlLightLight;
            buttonKembali.Cursor = Cursors.Hand;
            buttonKembali.FlatAppearance.BorderColor = Color.White;
            buttonKembali.FlatAppearance.BorderSize = 0;
            buttonKembali.FlatStyle = FlatStyle.Flat;
            buttonKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKembali.ForeColor = SystemColors.Desktop;
            buttonKembali.Location = new Point(26, 99);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(138, 39);
            buttonKembali.TabIndex = 8;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // buttonKonfirmasi
            // 
            buttonKonfirmasi.BackColor = SystemColors.ControlLightLight;
            buttonKonfirmasi.Cursor = Cursors.Hand;
            buttonKonfirmasi.FlatAppearance.BorderColor = Color.White;
            buttonKonfirmasi.FlatAppearance.BorderSize = 0;
            buttonKonfirmasi.FlatStyle = FlatStyle.Flat;
            buttonKonfirmasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKonfirmasi.ForeColor = SystemColors.Desktop;
            buttonKonfirmasi.Location = new Point(1088, 605);
            buttonKonfirmasi.Name = "buttonKonfirmasi";
            buttonKonfirmasi.Size = new Size(100, 30);
            buttonKonfirmasi.TabIndex = 9;
            buttonKonfirmasi.Text = "Konfirmasi";
            buttonKonfirmasi.UseVisualStyleBackColor = false;
            buttonKonfirmasi.Click += buttonKonfirmasi_Click;
            // 
            // buttonPilihGambar
            // 
            buttonPilihGambar.FlatStyle = FlatStyle.Popup;
            buttonPilihGambar.Location = new Point(195, 338);
            buttonPilihGambar.Name = "buttonPilihGambar";
            buttonPilihGambar.Size = new Size(106, 29);
            buttonPilihGambar.TabIndex = 10;
            buttonPilihGambar.Text = "Pilih Gambar";
            buttonPilihGambar.UseVisualStyleBackColor = true;
            buttonPilihGambar.Click += buttonPilihGambar_Click;
            // 
            // V_Tambah_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonPilihGambar);
            Controls.Add(buttonKonfirmasi);
            Controls.Add(buttonKembali);
            Controls.Add(textBoxSinopsis);
            Controls.Add(textBoxTahunTerbit);
            Controls.Add(textBoxPenerbit);
            Controls.Add(textBoxPenulis);
            Controls.Add(textBoxJudul);
            Controls.Add(pictureBoxCover);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Tambah_A";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_KatalogBuku_A";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCover;
        private TextBox textBoxJudul;
        private TextBox textBoxPenulis;
        private TextBox textBoxPenerbit;
        private TextBox textBoxTahunTerbit;
        private TextBox textBoxSinopsis;
        private Button buttonKembali;
        private Button buttonKonfirmasi;
        private Button buttonPilihGambar;
    }
}