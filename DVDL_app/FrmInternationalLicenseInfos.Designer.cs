namespace DVDL_app
{
    partial class FrmInternationalLicenseInfos
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
            pictureBox1 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            plLicenseInfosContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.InterLicense;
            pictureBox1.Location = new Point(406, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(243, 154);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(656, 57);
            bigLabel1.TabIndex = 4;
            bigLabel1.Text = "Driver International License Infos";
            // 
            // plLicenseInfosContainer
            // 
            plLicenseInfosContainer.BorderStyle = BorderStyle.FixedSingle;
            plLicenseInfosContainer.Location = new Point(9, 230);
            plLicenseInfosContainer.Name = "plLicenseInfosContainer";
            plLicenseInfosContainer.Size = new Size(1086, 312);
            plLicenseInfosContainer.TabIndex = 3;
            // 
            // FrmInternationalLicenseInfos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1103, 604);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(plLicenseInfosContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmInternationalLicenseInfos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "International License Informations";
            Load += FrmInternationalLicenseInfos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel plLicenseInfosContainer;
    }
}