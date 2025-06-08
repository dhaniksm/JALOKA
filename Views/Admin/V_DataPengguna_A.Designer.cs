namespace JALOKA.Views
{
    partial class V_DataPengguna_A
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DataPengguna_A));
            buttonPengembalian = new Button();
            buttonKeluar = new Button();
            buttonManajemenBuku = new Button();
            buttonDataPengguna = new Button();
            buttonRiwayatPeminjaman = new Button();
            buttonDashboard = new Button();
            cUserBindingSource = new BindingSource(components);
            buttonHapus = new Button();
            dataGridViewUsers = new DataGridView();
            textBoxID = new TextBox();
            pictureBoxRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cUserBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            SuspendLayout();
            // 
            // buttonPengembalian
            // 
            buttonPengembalian.BackColor = SystemColors.ControlLightLight;
            buttonPengembalian.Cursor = Cursors.Hand;
            buttonPengembalian.FlatAppearance.BorderSize = 0;
            buttonPengembalian.FlatStyle = FlatStyle.Flat;
            buttonPengembalian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPengembalian.Location = new Point(58, 421);
            buttonPengembalian.Name = "buttonPengembalian";
            buttonPengembalian.Size = new Size(187, 29);
            buttonPengembalian.TabIndex = 20;
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
            buttonKeluar.Location = new Point(69, 563);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(104, 34);
            buttonKeluar.TabIndex = 19;
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
            buttonManajemenBuku.Location = new Point(59, 187);
            buttonManajemenBuku.Name = "buttonManajemenBuku";
            buttonManajemenBuku.Size = new Size(187, 29);
            buttonManajemenBuku.TabIndex = 18;
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
            buttonDataPengguna.Location = new Point(58, 264);
            buttonDataPengguna.Name = "buttonDataPengguna";
            buttonDataPengguna.Size = new Size(187, 29);
            buttonDataPengguna.TabIndex = 17;
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
            buttonRiwayatPeminjaman.Location = new Point(57, 344);
            buttonRiwayatPeminjaman.Name = "buttonRiwayatPeminjaman";
            buttonRiwayatPeminjaman.Size = new Size(187, 29);
            buttonRiwayatPeminjaman.TabIndex = 16;
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
            buttonDashboard.Location = new Point(59, 116);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(187, 29);
            buttonDashboard.TabIndex = 15;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // cUserBindingSource
            // 
            cUserBindingSource.DataSource = typeof(Controllers.C_User);
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.Cursor = Cursors.Hand;
            buttonHapus.FlatAppearance.BorderColor = Color.Black;
            buttonHapus.FlatAppearance.BorderSize = 5;
            buttonHapus.FlatStyle = FlatStyle.Popup;
            buttonHapus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHapus.Location = new Point(1018, 612);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(102, 38);
            buttonHapus.TabIndex = 22;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.LightGray;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.DataSource = cUserBindingSource;
            dataGridViewUsers.Location = new Point(263, 85);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(921, 512);
            dataGridViewUsers.TabIndex = 24;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.LightGray;
            textBoxID.Location = new Point(328, 612);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 27);
            textBoxID.TabIndex = 0;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.BackColor = Color.Transparent;
            pictureBoxRefresh.BackgroundImage = (Image)resources.GetObject("pictureBoxRefresh.BackgroundImage");
            pictureBoxRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRefresh.Location = new Point(1084, 12);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(55, 47);
            pictureBoxRefresh.TabIndex = 25;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // V_DataPengguna_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxRefresh);
            Controls.Add(textBoxID);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonHapus);
            Controls.Add(buttonPengembalian);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonManajemenBuku);
            Controls.Add(buttonDataPengguna);
            Controls.Add(buttonRiwayatPeminjaman);
            Controls.Add(buttonDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_DataPengguna_A";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Datapengguna";
            Load += V_DataPengguna_A_Load;
            ((System.ComponentModel.ISupportInitialize)cUserBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPengembalian;
        private Button buttonKeluar;
        private Button buttonManajemenBuku;
        private Button buttonDataPengguna;
        private Button buttonRiwayatPeminjaman;
        private Button buttonDashboard;
        private BindingSource cUserBindingSource;
        private Button buttonHapus;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxID;
        private PictureBox pictureBoxRefresh;
    }
}