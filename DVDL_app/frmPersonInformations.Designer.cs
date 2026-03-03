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
            plTop = new Panel();
            plBody = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            plBody.SuspendLayout();
            SuspendLayout();
            // 
            // plTop
            // 
            plTop.Dock = DockStyle.Top;
            plTop.Location = new Point(0, 0);
            plTop.Name = "plTop";
            plTop.Size = new Size(1193, 56);
            plTop.TabIndex = 0;
            // 
            // plBody
            // 
            plBody.Controls.Add(panel1);
            plBody.Controls.Add(label1);
            plBody.Dock = DockStyle.Fill;
            plBody.Location = new Point(0, 56);
            plBody.Name = "plBody";
            plBody.Size = new Size(1193, 571);
            plBody.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(512, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(214, 35);
            label1.TabIndex = 0;
            label1.Text = "Person Details";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 382);
            panel1.TabIndex = 1;
            // 
            // frmPersonInformations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 627);
            Controls.Add(plBody);
            Controls.Add(plTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPersonInformations";
            Text = "frmPersonInformations";
            Load += frmPersonInformations_Load;
            plBody.ResumeLayout(false);
            plBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plTop;
        private Panel plBody;
        private Label label1;
        private Panel panel1;
    }
}