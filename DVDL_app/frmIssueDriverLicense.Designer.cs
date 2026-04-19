namespace DVDL_app
{
    partial class frmIssueDriverLicense
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
            plLDLBasicInfos = new Panel();
            tbxNotes = new ReaLTaiizor.Controls.AloneTextBox();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // plLDLBasicInfos
            // 
            plLDLBasicInfos.Location = new Point(20, 36);
            plLDLBasicInfos.Name = "plLDLBasicInfos";
            plLDLBasicInfos.Size = new Size(1029, 472);
            plLDLBasicInfos.TabIndex = 0;
            // 
            // tbxNotes
            // 
            tbxNotes.BackColor = Color.Transparent;
            tbxNotes.EnabledCalc = true;
            tbxNotes.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbxNotes.ForeColor = Color.FromArgb(64, 64, 64);
            tbxNotes.Location = new Point(188, 536);
            tbxNotes.MaxLength = 32767;
            tbxNotes.MultiLine = true;
            tbxNotes.Name = "tbxNotes";
            tbxNotes.ReadOnly = false;
            tbxNotes.Size = new Size(861, 117);
            tbxNotes.TabIndex = 89;
            tbxNotes.TextAlign = HorizontalAlignment.Left;
            tbxNotes.UseSystemPasswordChar = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Notes;
            pictureBox7.Location = new Point(140, 539);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(29, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 88;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 536);
            label8.Name = "label8";
            label8.Size = new Size(90, 29);
            label8.TabIndex = 87;
            label8.Text = "Notes : ";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.IssueDrivingLicense;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(471, 674);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 50);
            btnSave.TabIndex = 90;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmIssueDriverLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 736);
            Controls.Add(btnSave);
            Controls.Add(tbxNotes);
            Controls.Add(pictureBox7);
            Controls.Add(label8);
            Controls.Add(plLDLBasicInfos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmIssueDriverLicense";
            Text = "frmIssueDriverLicense";
            Load += frmIssueDriverLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plLDLBasicInfos;
        private ReaLTaiizor.Controls.AloneTextBox tbxNotes;
        private PictureBox pictureBox7;
        private Label label8;
        private Button btnSave;
    }
}