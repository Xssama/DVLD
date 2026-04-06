namespace DVDL_app
{
    partial class frmUserInfos
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
            gbPersonInfos = new GroupBox();
            gbLoginInfos = new GroupBox();
            SuspendLayout();
            // 
            // gbPersonInfos
            // 
            gbPersonInfos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPersonInfos.Location = new Point(37, 54);
            gbPersonInfos.Name = "gbPersonInfos";
            gbPersonInfos.Size = new Size(1054, 444);
            gbPersonInfos.TabIndex = 0;
            gbPersonInfos.TabStop = false;
            gbPersonInfos.Text = "Person Information";
            // 
            // gbLoginInfos
            // 
            gbLoginInfos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbLoginInfos.Location = new Point(37, 530);
            gbLoginInfos.Name = "gbLoginInfos";
            gbLoginInfos.Size = new Size(1054, 132);
            gbLoginInfos.TabIndex = 1;
            gbLoginInfos.TabStop = false;
            gbLoginInfos.Text = "Login information";
            // 
            // frmUserInfos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 701);
            Controls.Add(gbLoginInfos);
            Controls.Add(gbPersonInfos);
            Name = "frmUserInfos";
            Text = "frmUserInfos";
            Load += frmUserInfos_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPersonInfos;
        private GroupBox gbLoginInfos;
    }
}