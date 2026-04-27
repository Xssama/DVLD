namespace DVDL_app
{
    partial class frmShowLicenseInfos
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
            plDriverInfosContainer = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plDriverInfosContainer
            // 
            plDriverInfosContainer.BorderStyle = BorderStyle.FixedSingle;
            plDriverInfosContainer.Location = new Point(21, 230);
            plDriverInfosContainer.Name = "plDriverInfosContainer";
            plDriverInfosContainer.Size = new Size(1087, 412);
            plDriverInfosContainer.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(384, 154);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(386, 57);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Driver License Infos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseInfos;
            pictureBox1.Location = new Point(418, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmShowLicenseInfos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 679);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(plDriverInfosContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowLicenseInfos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowLicenseInfos";
            Load += frmShowLicenseInfos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plDriverInfosContainer;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
    }
}