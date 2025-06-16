namespace JALOKA.Views.Admin
{
    partial class V_Peminjaman_A
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
            dataGridViewPeminjaman = new DataGridView();
            cPeminjamanBindingSource = new BindingSource(components);
            textBoxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeminjaman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cPeminjamanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPeminjaman
            // 
            dataGridViewPeminjaman.AllowUserToAddRows = false;
            dataGridViewPeminjaman.AutoGenerateColumns = false;
            dataGridViewPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeminjaman.DataSource = cPeminjamanBindingSource;
            dataGridViewPeminjaman.Location = new Point(220, 104);
            dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            dataGridViewPeminjaman.RowHeadersWidth = 51;
            dataGridViewPeminjaman.Size = new Size(950, 512);
            dataGridViewPeminjaman.TabIndex = 0;
            dataGridViewPeminjaman.CellContentClick += dataGridViewPeminjaman_CellContentClick;
            // 
            // cPeminjamanBindingSource
            // 
            cPeminjamanBindingSource.DataSource = typeof(Controllers.C_Peminjaman);
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(1034, 170);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 1;
            // 
            // V_Peminjaman_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(textBoxID);
            Controls.Add(dataGridViewPeminjaman);
            Name = "V_Peminjaman_A";
            Text = "V_Peminjaman";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeminjaman).EndInit();
            ((System.ComponentModel.ISupportInitialize)cPeminjamanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPeminjaman;
        private BindingSource cPeminjamanBindingSource;
        private TextBox textBoxID;
    }
}