namespace DVDL_app
{
    partial class frmDetainLicense
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
            plButtom = new Panel();
            llblShowLicensesInfos = new LinkLabel();
            btnDetain = new Button();
            llblShowLicensesHistory = new LinkLabel();
            gpDetainInfos = new GroupBox();
            tbxFees = new ReaLTaiizor.Controls.AloneTextBox();
            lblLicenseID = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            lblDetainDate = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblCreatedBy = new Label();
            pictureBox9 = new PictureBox();
            lblAppDate7 = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            lblDetainID = new Label();
            label5 = new Label();
            lblFormHeader = new ReaLTaiizor.Controls.BigLabel();
            usFindShowLocalDrivingLicense1 = new usFindShowLocalDrivingLicense();
            errorProvider1 = new ErrorProvider(components);
            plButtom.SuspendLayout();
            gpDetainInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // plButtom
            // 
            plButtom.Controls.Add(llblShowLicensesInfos);
            plButtom.Controls.Add(btnDetain);
            plButtom.Controls.Add(llblShowLicensesHistory);
            plButtom.Dock = DockStyle.Bottom;
            plButtom.Location = new Point(0, 798);
            plButtom.Name = "plButtom";
            plButtom.Size = new Size(1115, 81);
            plButtom.TabIndex = 14;
            // 
            // llblShowLicensesInfos
            // 
            llblShowLicensesInfos.AutoSize = true;
            llblShowLicensesInfos.Enabled = false;
            llblShowLicensesInfos.Font = new Font("Sitka Small", 12F);
            llblShowLicensesInfos.Location = new Point(301, 19);
            llblShowLicensesInfos.Name = "llblShowLicensesInfos";
            llblShowLicensesInfos.Size = new Size(205, 29);
            llblShowLicensesInfos.TabIndex = 5;
            llblShowLicensesInfos.TabStop = true;
            llblShowLicensesInfos.Text = "Show License Infos";
            llblShowLicensesInfos.LinkClicked += llblShowLicensesInfos_LinkClicked;
            // 
            // btnDetain
            // 
            btnDetain.Enabled = false;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.Image = Properties.Resources.btnDetainLicense;
            btnDetain.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetain.Location = new Point(895, 12);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(196, 45);
            btnDetain.TabIndex = 4;
            btnDetain.Text = "Detain license";
            btnDetain.TextAlign = ContentAlignment.MiddleRight;
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // llblShowLicensesHistory
            // 
            llblShowLicensesHistory.AutoSize = true;
            llblShowLicensesHistory.Enabled = false;
            llblShowLicensesHistory.Font = new Font("Sitka Small", 12F);
            llblShowLicensesHistory.Location = new Point(32, 19);
            llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            llblShowLicensesHistory.Size = new Size(239, 29);
            llblShowLicensesHistory.TabIndex = 3;
            llblShowLicensesHistory.TabStop = true;
            llblShowLicensesHistory.Text = "Show Licenses History";
            llblShowLicensesHistory.LinkClicked += llblShowLicensesHistory_LinkClicked;
            // 
            // gpDetainInfos
            // 
            gpDetainInfos.Controls.Add(tbxFees);
            gpDetainInfos.Controls.Add(lblLicenseID);
            gpDetainInfos.Controls.Add(pictureBox4);
            gpDetainInfos.Controls.Add(label8);
            gpDetainInfos.Controls.Add(lblDetainDate);
            gpDetainInfos.Controls.Add(pictureBox1);
            gpDetainInfos.Controls.Add(label2);
            gpDetainInfos.Controls.Add(lblCreatedBy);
            gpDetainInfos.Controls.Add(pictureBox9);
            gpDetainInfos.Controls.Add(lblAppDate7);
            gpDetainInfos.Controls.Add(pictureBox5);
            gpDetainInfos.Controls.Add(label9);
            gpDetainInfos.Controls.Add(lblDetainID);
            gpDetainInfos.Controls.Add(label5);
            gpDetainInfos.Font = new Font("Sitka Banner", 13.7999992F);
            gpDetainInfos.Location = new Point(9, 578);
            gpDetainInfos.Name = "gpDetainInfos";
            gpDetainInfos.Size = new Size(1095, 168);
            gpDetainInfos.TabIndex = 13;
            gpDetainInfos.TabStop = false;
            gpDetainInfos.Text = "Detain Info";
            // 
            // tbxFees
            // 
            tbxFees.BackColor = Color.Transparent;
            tbxFees.EnabledCalc = true;
            tbxFees.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxFees.ForeColor = Color.Black;
            tbxFees.Location = new Point(282, 121);
            tbxFees.MaxLength = 32767;
            tbxFees.MultiLine = false;
            tbxFees.Name = "tbxFees";
            tbxFees.ReadOnly = false;
            tbxFees.Size = new Size(160, 36);
            tbxFees.TabIndex = 95;
            tbxFees.TextAlign = HorizontalAlignment.Left;
            tbxFees.UseSystemPasswordChar = false;
            tbxFees.Validating += tbxFees_Validating;
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Century", 13.8F);
            lblLicenseID.Location = new Point(839, 35);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(58, 28);
            lblLicenseID.TabIndex = 94;
            lblLicenseID.Text = "[???]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.drivingID;
            pictureBox4.Location = new Point(784, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 93;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 12F);
            label8.Location = new Point(637, 35);
            label8.Name = "label8";
            label8.Size = new Size(130, 29);
            label8.TabIndex = 92;
            label8.Text = "License ID :";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(282, 80);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(58, 28);
            lblDetainDate.TabIndex = 88;
            lblDetainDate.Text = "[???]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.appdate;
            pictureBox1.Location = new Point(237, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 77);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 86;
            label2.Text = "Detain Date  : ";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(840, 82);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(58, 28);
            lblCreatedBy.TabIndex = 85;
            lblCreatedBy.Text = "[???]";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.admin;
            pictureBox9.Location = new Point(785, 82);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(39, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 84;
            pictureBox9.TabStop = false;
            // 
            // lblAppDate7
            // 
            lblAppDate7.AutoSize = true;
            lblAppDate7.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppDate7.Location = new Point(630, 81);
            lblAppDate7.Name = "lblAppDate7";
            lblAppDate7.Size = new Size(137, 29);
            lblAppDate7.TabIndex = 83;
            lblAppDate7.Text = "Created By :";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.fees;
            pictureBox5.Location = new Point(237, 124);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 69;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(96, 121);
            label9.Name = "label9";
            label9.Size = new Size(119, 29);
            label9.TabIndex = 68;
            label9.Text = "Fine Fees :";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(282, 42);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(58, 28);
            lblDetainID.TabIndex = 64;
            lblDetainID.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 41);
            label5.Name = "label5";
            label5.Size = new Size(128, 29);
            label5.TabIndex = 63;
            label5.Text = "Detain ID : ";
            // 
            // lblFormHeader
            // 
            lblFormHeader.AutoSize = true;
            lblFormHeader.BackColor = Color.Transparent;
            lblFormHeader.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormHeader.ForeColor = Color.FromArgb(64, 64, 64);
            lblFormHeader.Location = new Point(433, 20);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new Size(266, 50);
            lblFormHeader.TabIndex = 12;
            lblFormHeader.Text = "Detain License";
            // 
            // usFindShowLocalDrivingLicense1
            // 
            usFindShowLocalDrivingLicense1.Location = new Point(10, 88);
            usFindShowLocalDrivingLicense1.Name = "usFindShowLocalDrivingLicense1";
            usFindShowLocalDrivingLicense1.Size = new Size(1094, 470);
            usFindShowLocalDrivingLicense1.TabIndex = 11;
            usFindShowLocalDrivingLicense1.Load += usFindShowLocalDrivingLicense1_Load;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1115, 879);
            Controls.Add(plButtom);
            Controls.Add(gpDetainInfos);
            Controls.Add(lblFormHeader);
            Controls.Add(usFindShowLocalDrivingLicense1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDetainLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detain License";
            Load += frmDetainLicense_Load;
            plButtom.ResumeLayout(false);
            plButtom.PerformLayout();
            gpDetainInfos.ResumeLayout(false);
            gpDetainInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plButtom;
        private LinkLabel llblShowLicensesInfos;
        private Button btnDetain;
        private LinkLabel llblShowLicensesHistory;
        private GroupBox gpDetainInfos;
        private Label lblLicenseID;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label6;
        private Label lblDetainDate;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblCreatedBy;
        private PictureBox pictureBox9;
        private Label lblAppDate7;
        private Label lblAppFees;
        private PictureBox pictureBox5;
        private Label label9;
        private Label lblDetainID;
        private Label label5;
        private ReaLTaiizor.Controls.BigLabel lblFormHeader;
        private usFindShowLocalDrivingLicense usFindShowLocalDrivingLicense1;
        private ReaLTaiizor.Controls.AloneTextBox tbxFees;
        private ErrorProvider errorProvider1;
    }
}