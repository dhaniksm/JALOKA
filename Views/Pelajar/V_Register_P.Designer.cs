namespace JALOKA.Views
{
    partial class V_Register_P
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Register_P));
            buttonRegister = new Button();
            textBoxAlamat = new TextBox();
            textBoxNoTelp = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNama = new TextBox();
            textBoxIDPelajar = new TextBox();
            textBoxPassword = new TextBox();
            pictureBoxKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).BeginInit();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(498, 568);
            buttonRegister.Margin = new Padding(2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(191, 60);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.BorderStyle = BorderStyle.None;
            textBoxAlamat.Location = new Point(676, 465);
            textBoxAlamat.Margin = new Padding(2);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(300, 20);
            textBoxAlamat.TabIndex = 7;
            textBoxAlamat.TextChanged += textBoxAlamat_TextChanged;
            // 
            // textBoxNoTelp
            // 
            textBoxNoTelp.BorderStyle = BorderStyle.None;
            textBoxNoTelp.Location = new Point(675, 348);
            textBoxNoTelp.Margin = new Padding(2);
            textBoxNoTelp.Name = "textBoxNoTelp";
            textBoxNoTelp.Size = new Size(300, 20);
            textBoxNoTelp.TabIndex = 10;
            textBoxNoTelp.TextChanged += textBoxNoTelp_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Location = new Point(675, 229);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 20);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxNama
            // 
            textBoxNama.BorderStyle = BorderStyle.None;
            textBoxNama.Location = new Point(176, 468);
            textBoxNama.Margin = new Padding(2);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(300, 20);
            textBoxNama.TabIndex = 12;
            textBoxNama.TextChanged += textBoxNamaLengkap_TextChanged;
            // 
            // textBoxIDPelajar
            // 
            textBoxIDPelajar.BorderStyle = BorderStyle.None;
            textBoxIDPelajar.Location = new Point(176, 230);
            textBoxIDPelajar.Margin = new Padding(2);
            textBoxIDPelajar.Name = "textBoxIDPelajar";
            textBoxIDPelajar.Size = new Size(300, 20);
            textBoxIDPelajar.TabIndex = 13;
            textBoxIDPelajar.TextChanged += textBoxIDPelajar_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(177, 349);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(300, 20);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // pictureBoxKembali
            // 
            pictureBoxKembali.BackColor = Color.Transparent;
            pictureBoxKembali.BackgroundImage = (Image)resources.GetObject("pictureBoxKembali.BackgroundImage");
            pictureBoxKembali.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxKembali.Cursor = Cursors.Hand;
            pictureBoxKembali.Location = new Point(60, 43);
            pictureBoxKembali.Margin = new Padding(0);
            pictureBoxKembali.Name = "pictureBoxKembali";
            pictureBoxKembali.Size = new Size(66, 54);
            pictureBoxKembali.TabIndex = 15;
            pictureBoxKembali.TabStop = false;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxKembali);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxIDPelajar);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNoTelp);
            Controls.Add(textBoxAlamat);
            Controls.Add(buttonRegister);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "V_Register";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRegister;
        private TextBox textBoxAlamat;
        private TextBox textBoxNoTelp;
        private TextBox textBoxEmail;
        private TextBox textBoxNama;
        private TextBox textBoxIDPelajar;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxKembali;
    }
}
