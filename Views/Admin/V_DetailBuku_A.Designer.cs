namespace JALOKA.Views.Admin
{
    partial class V_DetailBuku_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailBuku_A));
            buttonEdit = new Button();
            buttonHapus = new Button();
            pictureBoxCover = new PictureBox();
            labelJudul = new Label();
            labelPenulis = new Label();
            labelPenerbit = new Label();
            labelTahunTerbit = new Label();
            labelSinopsis = new Label();
            buttonKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ControlLightLight;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderColor = Color.White;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.ForeColor = SystemColors.Desktop;
            buttonEdit.Location = new Point(1088, 558);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 30);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = SystemColors.ControlLightLight;
            buttonHapus.Cursor = Cursors.Hand;
            buttonHapus.FlatAppearance.BorderColor = Color.White;
            buttonHapus.FlatAppearance.BorderSize = 0;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHapus.ForeColor = SystemColors.Desktop;
            buttonHapus.Location = new Point(1088, 604);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(100, 30);
            buttonHapus.TabIndex = 6;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(95, 166);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(300, 390);
            pictureBoxCover.TabIndex = 7;
            pictureBoxCover.TabStop = false;
            // 
            // labelJudul
            // 
            labelJudul.BackColor = SystemColors.ControlLightLight;
            labelJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudul.Location = new Point(36, 574);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(400, 30);
            labelJudul.TabIndex = 8;
            labelJudul.Text = "Judul";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPenulis
            // 
            labelPenulis.BackColor = SystemColors.ControlLightLight;
            labelPenulis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenulis.Location = new Point(585, 156);
            labelPenulis.Name = "labelPenulis";
            labelPenulis.Size = new Size(380, 25);
            labelPenulis.TabIndex = 9;
            labelPenulis.Text = "Penulis";
            labelPenulis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPenerbit
            // 
            labelPenerbit.BackColor = SystemColors.ControlLightLight;
            labelPenerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenerbit.Location = new Point(585, 228);
            labelPenerbit.Name = "labelPenerbit";
            labelPenerbit.Size = new Size(380, 25);
            labelPenerbit.TabIndex = 10;
            labelPenerbit.Text = "Penerbit";
            labelPenerbit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTahunTerbit
            // 
            labelTahunTerbit.BackColor = SystemColors.ControlLightLight;
            labelTahunTerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTahunTerbit.Location = new Point(585, 308);
            labelTahunTerbit.Name = "labelTahunTerbit";
            labelTahunTerbit.Size = new Size(380, 25);
            labelTahunTerbit.TabIndex = 11;
            labelTahunTerbit.Text = "Tahun Terbit";
            labelTahunTerbit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSinopsis
            // 
            labelSinopsis.BackColor = SystemColors.ControlLightLight;
            labelSinopsis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinopsis.Location = new Point(574, 419);
            labelSinopsis.Name = "labelSinopsis";
            labelSinopsis.Size = new Size(420, 200);
            labelSinopsis.TabIndex = 12;
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
            buttonKembali.Location = new Point(26, 98);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(138, 39);
            buttonKembali.TabIndex = 13;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // V_DetailBuku_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonKembali);
            Controls.Add(labelSinopsis);
            Controls.Add(labelTahunTerbit);
            Controls.Add(labelPenerbit);
            Controls.Add(labelPenulis);
            Controls.Add(labelJudul);
            Controls.Add(pictureBoxCover);
            Controls.Add(buttonHapus);
            Controls.Add(buttonEdit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_DetailBuku_A";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DetailBuku_A";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEdit;
        private Button buttonHapus;
        private PictureBox pictureBoxCover;
        private Label labelJudul;
        private Label labelPenulis;
        private Label labelPenerbit;
        private Label labelTahunTerbit;
        private Label labelSinopsis;
        private Button buttonKembali;
    }
}