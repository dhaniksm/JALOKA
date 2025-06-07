namespace JALOKA.Views.Pelajar
{
    partial class V_DetailBuku_P
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
            labelJudul = new Label();
            labelPenulis = new Label();
            labelTahunTerbit = new Label();
            pictureBoxCover = new PictureBox();
            buttonPinjam = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.BackColor = SystemColors.ControlLightLight;
            labelJudul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudul.Location = new Point(507, 54);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(400, 25);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Judul";
            labelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPenulis
            // 
            labelPenulis.BackColor = SystemColors.ControlLightLight;
            labelPenulis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPenulis.Location = new Point(507, 106);
            labelPenulis.Name = "labelPenulis";
            labelPenulis.Size = new Size(400, 25);
            labelPenulis.TabIndex = 1;
            labelPenulis.Text = "Penulis";
            labelPenulis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTahunTerbit
            // 
            labelTahunTerbit.BackColor = SystemColors.ControlLightLight;
            labelTahunTerbit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTahunTerbit.Location = new Point(507, 155);
            labelTahunTerbit.Name = "labelTahunTerbit";
            labelTahunTerbit.Size = new Size(400, 25);
            labelTahunTerbit.TabIndex = 2;
            labelTahunTerbit.Text = "Tahun Terbit";
            labelTahunTerbit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(268, 54);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(213, 275);
            pictureBoxCover.TabIndex = 3;
            pictureBoxCover.TabStop = false;
            // 
            // buttonPinjam
            // 
            buttonPinjam.BackColor = SystemColors.ControlLightLight;
            buttonPinjam.Cursor = Cursors.Hand;
            buttonPinjam.FlatAppearance.BorderColor = Color.White;
            buttonPinjam.FlatAppearance.BorderSize = 0;
            buttonPinjam.FlatStyle = FlatStyle.Flat;
            buttonPinjam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPinjam.ForeColor = SystemColors.Desktop;
            buttonPinjam.Location = new Point(667, 550);
            buttonPinjam.Name = "buttonPinjam";
            buttonPinjam.Size = new Size(100, 30);
            buttonPinjam.TabIndex = 4;
            buttonPinjam.Text = "Pinjam";
            buttonPinjam.UseVisualStyleBackColor = false;
            // 
            // V_DetailBuku_P
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1182, 628);
            Controls.Add(buttonPinjam);
            Controls.Add(pictureBoxCover);
            Controls.Add(labelTahunTerbit);
            Controls.Add(labelPenulis);
            Controls.Add(labelJudul);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_DetailBuku_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DetailBuku_P";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelJudul;
        private Label labelPenulis;
        private Label labelTahunTerbit;
        private PictureBox pictureBoxCover;
        private Button buttonPinjam;
    }
}