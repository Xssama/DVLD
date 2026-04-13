namespace DVDL_app
{
    partial class frmVisionTest
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
            plAppInfos = new Panel();
            SuspendLayout();
            // 
            // plAppInfos
            // 
            plAppInfos.Location = new Point(37, 61);
            plAppInfos.Name = "plAppInfos";
            plAppInfos.Size = new Size(1034, 590);
            plAppInfos.TabIndex = 0;
            // 
            // frmVisionTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 725);
            Controls.Add(plAppInfos);
            Name = "frmVisionTest";
            Text = "frmVisionTest";
            Load += frmVisionTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel plAppInfos;
    }
}