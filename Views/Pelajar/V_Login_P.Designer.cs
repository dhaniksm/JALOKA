namespace JALOKA.Views
{
    partial class V_Login_P
    {
        /// <summary>
        /// Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login_P));
            buttonRegistrasi = new Button();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxNisn = new TextBox();
            checkBoxPassword = new CheckBox();
            pictureBoxKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).BeginInit();
            SuspendLayout();
            // 
            // buttonRegistrasi
            // 
            buttonRegistrasi.BackColor = Color.Transparent;
            buttonRegistrasi.Cursor = Cursors.Hand;
            buttonRegistrasi.FlatAppearance.BorderSize = 0;
            buttonRegistrasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegistrasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegistrasi.FlatStyle = FlatStyle.Flat;
            buttonRegistrasi.ForeColor = Color.Transparent;
            buttonRegistrasi.Location = new Point(650, 546);
            buttonRegistrasi.Name = "buttonRegistrasi";
            buttonRegistrasi.Size = new Size(118, 29);
            buttonRegistrasi.TabIndex = 4;
            buttonRegistrasi.UseVisualStyleBackColor = false;
            buttonRegistrasi.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(492, 460);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(214, 40);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(440, 308);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(320, 20);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxNisn
            // 

            textBoxNisn.BorderStyle = BorderStyle.None;
            textBoxNisn.Location = new Point(442, 197);
            textBoxNisn.Name = "textBoxIDPelajar";
            textBoxNisn.Size = new Size(320, 20);
            textBoxNisn.TabIndex = 3;
            textBoxNisn.BorderStyle = BorderStyle.None;
            textBoxNisn.Location = new Point(442, 197);
            textBoxNisn.Name = "textBoxNisn";
            textBoxNisn.Size = new Size(320, 20);
            textBoxNisn.TabIndex = 3;
           

            // 
            // checkBoxPassword
            // 
            checkBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxPassword.Location = new Point(627, 367);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(132, 25);
            checkBoxPassword.TabIndex = 5;
            checkBoxPassword.Text = "Show Password\r\n";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // pictureBoxKembali
            // 
            pictureBoxKembali.BackColor = Color.Transparent;
            pictureBoxKembali.BackgroundImage = (Image)resources.GetObject("pictureBoxKembali.BackgroundImage");
            pictureBoxKembali.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxKembali.Cursor = Cursors.Hand;
            pictureBoxKembali.Location = new Point(360, 77);
            pictureBoxKembali.Margin = new Padding(0);
            pictureBoxKembali.Name = "pictureBoxKembali";
            pictureBoxKembali.Size = new Size(62, 51);
            pictureBoxKembali.TabIndex = 11;
            pictureBoxKembali.TabStop = false;
            pictureBoxKembali.Click += pictureBoxKembali_Click;
            // 
            // V_Login_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxKembali);
            Controls.Add(checkBoxPassword);
            Controls.Add(buttonRegistrasi);
            Controls.Add(textBoxNisn);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Login_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxNisn;
        private Button buttonRegistrasi;
        private CheckBox checkBoxPassword;
        private PictureBox pictureBoxKembali;
    }
}