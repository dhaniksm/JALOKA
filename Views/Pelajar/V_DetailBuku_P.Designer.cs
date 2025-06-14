namespace JALOKA.Views
{
    partial class V_DetailBuku_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailBuku_P));
            labelJudul = new Label();
            labelPenulis = new Label();
            labelTahunTerbit = new Label();
            pictureBoxCover = new PictureBox();
            buttonPinjam = new Button();
            labelPenerbit = new Label();
            labelSinopsis = new Label();
            buttonKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.BackColor = SystemColors.ControlLightLight;
            labelJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudul.Location = new Point(44, 572);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(400, 30);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Judul";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPenulis
            // 
            labelPenulis.BackColor = SystemColors.ControlLightLight;
            labelPenulis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenulis.Location = new Point(584, 156);
            labelPenulis.Name = "labelPenulis";
            labelPenulis.Size = new Size(380, 25);
            labelPenulis.TabIndex = 1;
            labelPenulis.Text = "Penulis";
            labelPenulis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTahunTerbit
            // 
            labelTahunTerbit.BackColor = SystemColors.ControlLightLight;
            labelTahunTerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTahunTerbit.Location = new Point(584, 309);
            labelTahunTerbit.Name = "labelTahunTerbit";
            labelTahunTerbit.Size = new Size(380, 25);
            labelTahunTerbit.TabIndex = 2;
            labelTahunTerbit.Text = "Tahun Terbit";
            labelTahunTerbit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(97, 168);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(300, 390);
            pictureBoxCover.TabIndex = 3;
            pictureBoxCover.TabStop = false;
            // 
            // buttonPinjam
            // 
            buttonPinjam.BackColor = SystemColors.ControlLightLight;
            buttonPinjam.Cursor = Cursors.Hand;
            buttonPinjam.FlatAppearance.BorderColor = Color.White;
            buttonPinjam.FlatAppearance.BorderSize = 0;
            buttonPinjam.FlatStyle = FlatStyle.Flat;
            buttonPinjam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPinjam.ForeColor = SystemColors.Desktop;
            buttonPinjam.Location = new Point(1088, 599);
            buttonPinjam.Name = "buttonPinjam";
            buttonPinjam.Size = new Size(100, 30);
            buttonPinjam.TabIndex = 4;
            buttonPinjam.Text = "Pinjam";
            buttonPinjam.UseVisualStyleBackColor = false;
            buttonPinjam.Click += buttonPinjam_Click;
            // 
            // labelPenerbit
            // 
            labelPenerbit.BackColor = SystemColors.ControlLightLight;
            labelPenerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenerbit.Location = new Point(584, 228);
            labelPenerbit.Name = "labelPenerbit";
            labelPenerbit.Size = new Size(380, 25);
            labelPenerbit.TabIndex = 5;
            labelPenerbit.Text = "Penerbit";
            labelPenerbit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSinopsis
            // 
            labelSinopsis.BackColor = SystemColors.ControlLightLight;
            labelSinopsis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinopsis.Location = new Point(575, 418);
            labelSinopsis.Name = "labelSinopsis";
            labelSinopsis.Size = new Size(420, 200);
            labelSinopsis.TabIndex = 6;
            labelSinopsis.Text = "Sinopsis";
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
            buttonKembali.Location = new Point(27, 99);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(138, 39);
            buttonKembali.TabIndex = 7;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // V_DetailBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonKembali);
            Controls.Add(labelSinopsis);
            Controls.Add(labelPenerbit);
            Controls.Add(buttonPinjam);
            Controls.Add(pictureBoxCover);
            Controls.Add(labelTahunTerbit);
            Controls.Add(labelPenulis);
            Controls.Add(labelJudul);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_DetailBuku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DetailBuku";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelJudul;
        private Label labelPenulis;
        private Label labelTahunTerbit;
        private PictureBox pictureBoxCover;
        private Button buttonPinjam;
        private Label labelPenerbit;
        private Label labelSinopsis;
        private Button buttonKembali;
    }
}