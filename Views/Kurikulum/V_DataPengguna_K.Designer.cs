namespace JALOKA.Views
{
    partial class V_DataPengguna_K
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DataPengguna_K));
            buttonKeluar = new Button();
            buttonDataPengguna = new Button();
            buttonDashboard = new Button();
            dataGridViewDataUser = new DataGridView();
            cUserBindingSource = new BindingSource(components);
            cPeminjamanBindingSource = new BindingSource(components);
            buttonEdit = new Button();
            buttonHapus = new Button();
            textBoxIDPelajar = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            labelAlamat = new Label();
            textBoxNoHP = new TextBox();
            textBoxAlamat = new TextBox();
            labelEmail = new Label();
            labelNoHP = new Label();
            textBoxEmail = new TextBox();
            textBoxNama = new TextBox();
            labelNama = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cUserBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cPeminjamanBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = SystemColors.ControlLightLight;
            buttonKeluar.Cursor = Cursors.Hand;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.Location = new Point(70, 569);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(104, 34);
            buttonKeluar.TabIndex = 30;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonDataPengguna
            // 
            buttonDataPengguna.BackColor = SystemColors.ControlLightLight;
            buttonDataPengguna.Cursor = Cursors.Hand;
            buttonDataPengguna.FlatAppearance.BorderSize = 0;
            buttonDataPengguna.FlatStyle = FlatStyle.Flat;
            buttonDataPengguna.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDataPengguna.Location = new Point(62, 229);
            buttonDataPengguna.Name = "buttonDataPengguna";
            buttonDataPengguna.Size = new Size(187, 29);
            buttonDataPengguna.TabIndex = 29;
            buttonDataPengguna.Text = "Data Pengguna";
            buttonDataPengguna.UseVisualStyleBackColor = false;
            buttonDataPengguna.Click += buttonDataPengguna_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = SystemColors.ControlLightLight;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.Location = new Point(62, 145);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(187, 29);
            buttonDashboard.TabIndex = 28;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // dataGridViewDataUser
            // 
            dataGridViewDataUser.AllowUserToAddRows = false;
            dataGridViewDataUser.AutoGenerateColumns = false;
            dataGridViewDataUser.BackgroundColor = Color.Silver;
            dataGridViewDataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataUser.DataSource = cUserBindingSource;
            dataGridViewDataUser.Location = new Point(254, 76);
            dataGridViewDataUser.Name = "dataGridViewDataUser";
            dataGridViewDataUser.RowHeadersWidth = 51;
            dataGridViewDataUser.Size = new Size(941, 366);
            dataGridViewDataUser.TabIndex = 31;
            dataGridViewDataUser.CellClick += dataGridViewDatauser_CellClick;
            // 
            // cUserBindingSource
            // 
            cUserBindingSource.DataSource = typeof(Controllers.C_User);
            // 
            // cPeminjamanBindingSource
            // 
            cPeminjamanBindingSource.DataSource = typeof(Controllers.C_Peminjaman);
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(285, 612);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(127, 36);
            buttonEdit.TabIndex = 32;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Transparent;
            buttonHapus.Cursor = Cursors.Hand;
            buttonHapus.FlatAppearance.BorderSize = 0;
            buttonHapus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonHapus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(442, 612);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(127, 36);
            buttonHapus.TabIndex = 33;
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // textBoxIDPelajar
            // 
            textBoxIDPelajar.BackColor = Color.LightGray;
            textBoxIDPelajar.Location = new Point(111, 43);
            textBoxIDPelajar.Name = "textBoxIDPelajar";
            textBoxIDPelajar.ReadOnly = true;
            textBoxIDPelajar.Size = new Size(168, 27);
            textBoxIDPelajar.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 35;
            label1.Text = "ID Pelajar :\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAlamat);
            panel1.Controls.Add(textBoxNoHP);
            panel1.Controls.Add(textBoxAlamat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(textBoxIDPelajar);
            panel1.Controls.Add(labelNoHP);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxNama);
            panel1.Controls.Add(labelNama);
            panel1.Location = new Point(254, 465);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 123);
            panel1.TabIndex = 36;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(667, 75);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(64, 20);
            labelAlamat.TabIndex = 43;
            labelAlamat.Text = "Alamat :\r\n";
            // 
            // textBoxNoHP
            // 
            textBoxNoHP.BackColor = Color.LightGray;
            textBoxNoHP.Location = new Point(747, 19);
            textBoxNoHP.Name = "textBoxNoHP";
            textBoxNoHP.Size = new Size(168, 27);
            textBoxNoHP.TabIndex = 42;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.BackColor = Color.LightGray;
            textBoxAlamat.Location = new Point(747, 72);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(168, 27);
            textBoxAlamat.TabIndex = 41;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(333, 75);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 20);
            labelEmail.TabIndex = 40;
            labelEmail.Text = "Email :\r\n";
            // 
            // labelNoHP
            // 
            labelNoHP.AutoSize = true;
            labelNoHP.Location = new Point(672, 22);
            labelNoHP.Name = "labelNoHP";
            labelNoHP.Size = new Size(59, 20);
            labelNoHP.TabIndex = 39;
            labelNoHP.Text = "No HP :\r\n";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.LightGray;
            textBoxEmail.Location = new Point(421, 75);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(168, 27);
            textBoxEmail.TabIndex = 38;
            // 
            // textBoxNama
            // 
            textBoxNama.BackColor = Color.LightGray;
            textBoxNama.Location = new Point(421, 19);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(168, 27);
            textBoxNama.TabIndex = 37;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(333, 22);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(56, 20);
            labelNama.TabIndex = 37;
            labelNama.Text = "Nama :\r\n";
            // 
            // V_DataPengguna_K
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonHapus);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridViewDataUser);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonDataPengguna);
            Controls.Add(buttonDashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_DataPengguna_K";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DataPengguna_K";
            Load += V_DataPengguna_K_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)cUserBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cPeminjamanBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonDataPengguna;
        private Button buttonDashboard;
        private DataGridView dataGridViewDataUser;
        private BindingSource cUserBindingSource;
        private BindingSource cPeminjamanBindingSource;
        private Button buttonEdit;
        private Button buttonHapus;
        private TextBox textBoxIDPelajar;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxNama;
        private Label labelNama;
        private Label labelEmail;
        private Label labelNoHP;
        private TextBox textBoxEmail;
        private Label labelAlamat;
        private TextBox textBoxNoHP;
        private TextBox textBoxAlamat;
    }
}