namespace JALOKA.Views
{
    partial class V_Login_K
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login_K));
            pictureBoxKembali = new PictureBox();
            checkBoxPassword = new CheckBox();
            textBoxIDKurikulum = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxKembali
            // 
            pictureBoxKembali.BackColor = Color.Transparent;
            pictureBoxKembali.BackgroundImage = (Image)resources.GetObject("pictureBoxKembali.BackgroundImage");
            pictureBoxKembali.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxKembali.Cursor = Cursors.Hand;
            pictureBoxKembali.Location = new Point(359, 75);
            pictureBoxKembali.Margin = new Padding(0);
            pictureBoxKembali.Name = "pictureBoxKembali";
            pictureBoxKembali.Size = new Size(58, 51);
            pictureBoxKembali.TabIndex = 15;
            pictureBoxKembali.TabStop = false;
            pictureBoxKembali.Click += pictureBoxKembali_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxPassword.Location = new Point(627, 366);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(132, 25);
            checkBoxPassword.TabIndex = 14;
            checkBoxPassword.Text = "Show Password\r\n";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // textBoxIDKurikulum
            // 
            textBoxIDKurikulum.BorderStyle = BorderStyle.None;
            textBoxIDKurikulum.Location = new Point(442, 196);
            textBoxIDKurikulum.Name = "textBoxIDKurikulum";
            textBoxIDKurikulum.Size = new Size(320, 20);
            textBoxIDKurikulum.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(440, 307);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(320, 20);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(492, 485);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(214, 40);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // V_Login_K
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(pictureBoxKembali);
            Controls.Add(checkBoxPassword);
            Controls.Add(textBoxIDKurikulum);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Login_K";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Login_K";
            ((System.ComponentModel.ISupportInitialize)pictureBoxKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxKembali;
        private CheckBox checkBoxPassword;
        private TextBox textBoxIDKurikulum;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}