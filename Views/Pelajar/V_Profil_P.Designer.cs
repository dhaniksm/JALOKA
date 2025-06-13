namespace JALOKA.Views
{
    partial class V_Profil_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Profil_P));
            textBoxNama = new TextBox();
            textBoxNisn = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelepon = new TextBox();
            textBoxAlamat = new TextBox();
            pictureBoxKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).BeginInit();
            SuspendLayout();
            // 
            // textBoxNama
            // 
            textBoxNama.BackColor = Color.FromArgb(217, 217, 217);
            textBoxNama.BorderStyle = BorderStyle.None;
            textBoxNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNama.Location = new Point(423, 276);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(460, 20);
            textBoxNama.TabIndex = 0;
            // 
            // textBoxNisn
            // 
            textBoxNisn.BackColor = Color.FromArgb(217, 217, 217);
            textBoxNisn.BorderStyle = BorderStyle.None;
            textBoxNisn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNisn.Location = new Point(423, 353);
            textBoxNisn.Name = "textBoxNisn";
            textBoxNisn.ReadOnly = true;
            textBoxNisn.Size = new Size(460, 20);
            textBoxNisn.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(217, 217, 217);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(423, 432);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(460, 20);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.BackColor = Color.FromArgb(217, 217, 217);
            textBoxTelepon.BorderStyle = BorderStyle.None;
            textBoxTelepon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTelepon.Location = new Point(423, 510);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.ReadOnly = true;
            textBoxTelepon.Size = new Size(460, 20);
            textBoxTelepon.TabIndex = 3;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.BackColor = Color.FromArgb(217, 217, 217);
            textBoxAlamat.BorderStyle = BorderStyle.None;
            textBoxAlamat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAlamat.Location = new Point(423, 588);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.ReadOnly = true;
            textBoxAlamat.Size = new Size(460, 20);
            textBoxAlamat.TabIndex = 4;
            // 
            // pictureBoxKembali
            // 
            pictureBoxKembali.BackColor = Color.Transparent;
            pictureBoxKembali.BackgroundImage = (Image)resources.GetObject("pictureBoxKembali.BackgroundImage");
            pictureBoxKembali.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxKembali.Cursor = Cursors.Hand;
            pictureBoxKembali.Location = new Point(239, 151);
            pictureBoxKembali.Margin = new Padding(0);
            pictureBoxKembali.Name = "pictureBoxKembali";
            pictureBoxKembali.Size = new Size(62, 51);
            pictureBoxKembali.TabIndex = 12;
            pictureBoxKembali.TabStop = false;
            pictureBoxKembali.Click += pictureBoxKembali_Click;
            // 
            // V_Profil_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxKembali);
            Controls.Add(textBoxAlamat);
            Controls.Add(textBoxTelepon);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNisn);
            Controls.Add(textBoxNama);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Profil_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profil_P";
            Load += V_Profil_P_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNama;
        private TextBox textBoxNisn;
        private TextBox textBoxEmail;
        private TextBox textBoxTelepon;
        private TextBox textBoxAlamat;
        private PictureBox pictureBoxKembali;
    }
}