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
            flowLayoutPanelKonfirmasi = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelKonfirmasi
            // 
            flowLayoutPanelKonfirmasi.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelKonfirmasi.Location = new Point(283, 108);
            flowLayoutPanelKonfirmasi.Name = "flowLayoutPanelKonfirmasi";
            flowLayoutPanelKonfirmasi.Size = new Size(887, 499);
            flowLayoutPanelKonfirmasi.TabIndex = 0;
            // 
            // V_Peminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(flowLayoutPanelKonfirmasi);
            Name = "V_Peminjaman";
            Text = "V_Peminjaman";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelKonfirmasi;
    }
}