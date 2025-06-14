namespace JALOKA.Views
{
    partial class V_TampilanAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TampilanAwal));
            buttonLoginUser = new Button();
            buttonLoginAdmin = new Button();
            buttonLoginKurikulum = new Button();
            SuspendLayout();
            // 
            // buttonLoginUser
            // 
            buttonLoginUser.BackColor = Color.Transparent;
            buttonLoginUser.Cursor = Cursors.Hand;
            buttonLoginUser.FlatAppearance.BorderSize = 0;
            buttonLoginUser.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLoginUser.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLoginUser.FlatStyle = FlatStyle.Flat;
            buttonLoginUser.Location = new Point(34, 504);
            buttonLoginUser.Name = "buttonLoginUser";
            buttonLoginUser.Size = new Size(312, 37);
            buttonLoginUser.TabIndex = 0;
            buttonLoginUser.UseVisualStyleBackColor = false;
            buttonLoginUser.Click += buttonLoginUser_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.BackColor = Color.Transparent;
            buttonLoginAdmin.Cursor = Cursors.Hand;
            buttonLoginAdmin.FlatAppearance.BorderSize = 0;
            buttonLoginAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLoginAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLoginAdmin.FlatStyle = FlatStyle.Flat;
            buttonLoginAdmin.Location = new Point(669, 31);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(210, 39);
            buttonLoginAdmin.TabIndex = 1;
            buttonLoginAdmin.UseVisualStyleBackColor = false;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // buttonLoginKurikulum
            // 
            buttonLoginKurikulum.BackColor = Color.Transparent;
            buttonLoginKurikulum.Cursor = Cursors.Hand;
            buttonLoginKurikulum.FlatAppearance.BorderSize = 0;
            buttonLoginKurikulum.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLoginKurikulum.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLoginKurikulum.FlatStyle = FlatStyle.Flat;
            buttonLoginKurikulum.Location = new Point(922, 31);
            buttonLoginKurikulum.Name = "buttonLoginKurikulum";
            buttonLoginKurikulum.Size = new Size(210, 39);
            buttonLoginKurikulum.TabIndex = 2;
            buttonLoginKurikulum.UseVisualStyleBackColor = false;
            buttonLoginKurikulum.Click += buttonLoginKurikulum_Click;
            // 
            // V_TampilanAwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 675);
            Controls.Add(buttonLoginKurikulum);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(buttonLoginUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_TampilanAwal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_TampilanAwal";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoginUser;
        private Button buttonLoginAdmin;
        private Button buttonLoginKurikulum;
    }
}