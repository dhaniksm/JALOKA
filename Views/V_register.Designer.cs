namespace JALOKA
{
    partial class V_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_register));
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBoxUsername = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(645, 739);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(212, 57);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(498, 568);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(191, 60);
            button2.TabIndex = 3;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonRegister_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(676, 465);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 20);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBoxAlamat_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(675, 348);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 20);
            textBox7.TabIndex = 10;
            textBox7.TextChanged += textBoxNoTelp_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(675, 229);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 20);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(176, 468);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(300, 20);
            textBox8.TabIndex = 12;
            textBox8.TextChanged += textBoxNamaLengkap_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Location = new Point(176, 230);
            textBoxUsername.Margin = new Padding(2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(300, 20);
            textBoxUsername.TabIndex = 13;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(177, 349);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 20);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBoxPassword_TextChanged;
            // 
            // V_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(textBox2);
            Controls.Add(textBoxUsername);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "V_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBoxUsername;
        private TextBox textBox2;
    }
}
