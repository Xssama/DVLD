namespace DVDL_app
{
    partial class frmPersonInformations
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
            plBody = new Panel();
            gbPersonInfos = new GroupBox();
            label1 = new Label();
            plBody.SuspendLayout();
            SuspendLayout();
            // 
            // plBody
            // 
            plBody.Controls.Add(gbPersonInfos);
            plBody.Controls.Add(label1);
            plBody.Dock = DockStyle.Fill;
            plBody.Location = new Point(0, 0);
            plBody.Name = "plBody";
            plBody.Size = new Size(1140, 592);
            plBody.TabIndex = 1;
            // 
            // gbPersonInfos
            // 
            gbPersonInfos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPersonInfos.Location = new Point(23, 121);
            gbPersonInfos.Name = "gbPersonInfos";
            gbPersonInfos.Size = new Size(1090, 413);
            gbPersonInfos.TabIndex = 1;
            gbPersonInfos.TabStop = false;
            gbPersonInfos.Text = "Person Informations :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(474, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(214, 35);
            label1.TabIndex = 0;
            label1.Text = "Person Details";
            // 
            // frmPersonInformations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 592);
            Controls.Add(plBody);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPersonInformations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Details";
            Load += frmPersonInformations_Load;
            plBody.ResumeLayout(false);
            plBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel plBody;
        private Label label1;
        private GroupBox gbPersonInfos;
    }
}