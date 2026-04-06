namespace DVDL_app
{
    partial class usUserLoginInfos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblUserid = new Label();
            lblusername = new Label();
            label3 = new Label();
            lblisactive = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "User ID: ";
            // 
            // lblUserid
            // 
            lblUserid.AutoSize = true;
            lblUserid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserid.Location = new Point(267, 31);
            lblUserid.Name = "lblUserid";
            lblUserid.Size = new Size(60, 28);
            lblUserid.TabIndex = 1;
            lblUserid.Text = "None";
            // 
            // label2
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(548, 31);
            lblusername.Name = "label2";
            lblusername.Size = new Size(60, 28);
            lblusername.TabIndex = 3;
            lblusername.Text = "None";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 31);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 2;
            label3.Text = "UserName: ";
            // 
            // label4
            // 
            lblisactive.AutoSize = true;
            lblisactive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblisactive.Location = new Point(852, 31);
            lblisactive.Name = "label4";
            lblisactive.Size = new Size(60, 28);
            lblisactive.TabIndex = 5;
            lblisactive.Text = "None";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(756, 31);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "is Active: ";
            // 
            // usUserLoginInfos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblisactive);
            Controls.Add(label5);
            Controls.Add(lblusername);
            Controls.Add(label3);
            Controls.Add(lblUserid);
            Controls.Add(label1);
            Name = "usUserLoginInfos";
            Size = new Size(1054, 90);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserid;
        private Label lblusername;
        private Label label3;
        private Label lblisactive;
        private Label label5;
    }
}
