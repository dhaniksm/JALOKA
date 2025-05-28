namespace JALOKA.Views
{
    partial class V_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            buttonRegistrasi = new Button();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxIDPelajar = new TextBox();
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
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(492, 442);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(214, 40);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(440, 346);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(320, 20);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxIDPelajar
            // 
            textBoxIDPelajar.BorderStyle = BorderStyle.None;
            textBoxIDPelajar.Location = new Point(442, 219);
            textBoxIDPelajar.Name = "textBoxIDPelajar";
            textBoxIDPelajar.Size = new Size(320, 20);
            textBoxIDPelajar.TabIndex = 3;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonRegistrasi);
            Controls.Add(textBoxIDPelajar);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxIDPelajar;
        private Button buttonRegistrasi;
    }
}