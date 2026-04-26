namespace DVDL_app
{
    partial class frmReleaseDetainedLicense
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
            plButtom = new Panel();
            llblShowLicensesInfos = new LinkLabel();
            btnRelease = new Button();
            llblShowLicensesHistory = new LinkLabel();
            gpDetainInfos = new GroupBox();
            lblAppID = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            lblTotalFees = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            lblAppFees = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblFineFees = new Label();
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
            plButtom.SuspendLayout();
            gpDetainInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // plButtom
            // 
            plButtom.Controls.Add(llblShowLicensesInfos);
            plButtom.Controls.Add(btnRelease);
            plButtom.Controls.Add(llblShowLicensesHistory);
            plButtom.Dock = DockStyle.Bottom;
            plButtom.Location = new Point(0, 809);
            plButtom.Name = "plButtom";
            plButtom.Size = new Size(1152, 81);
            plButtom.TabIndex = 18;
            // 
            // llblShowLicensesInfos
            // 
            llblShowLicensesInfos.AutoSize = true;
            llblShowLicensesInfos.Enabled = false;
            llblShowLicensesInfos.Font = new Font("Sitka Small", 12F);
            llblShowLicensesInfos.Location = new Point(301, 21);
            llblShowLicensesInfos.Name = "llblShowLicensesInfos";
            llblShowLicensesInfos.Size = new Size(205, 29);
            llblShowLicensesInfos.TabIndex = 5;
            llblShowLicensesInfos.TabStop = true;
            llblShowLicensesInfos.Text = "Show License Infos";
            llblShowLicensesInfos.LinkClicked += llblShowLicensesInfos_LinkClicked;
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.Image = Properties.Resources.ReleaseLicense;
            btnRelease.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelease.Location = new Point(895, 12);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(196, 45);
            btnRelease.TabIndex = 4;
            btnRelease.Text = "Release license";
            btnRelease.TextAlign = ContentAlignment.MiddleRight;
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
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
            gpDetainInfos.Controls.Add(lblAppID);
            gpDetainInfos.Controls.Add(pictureBox6);
            gpDetainInfos.Controls.Add(label6);
            gpDetainInfos.Controls.Add(lblTotalFees);
            gpDetainInfos.Controls.Add(pictureBox3);
            gpDetainInfos.Controls.Add(label7);
            gpDetainInfos.Controls.Add(lblAppFees);
            gpDetainInfos.Controls.Add(pictureBox2);
            gpDetainInfos.Controls.Add(label4);
            gpDetainInfos.Controls.Add(lblFineFees);
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
            gpDetainInfos.Location = new Point(9, 568);
            gpDetainInfos.Name = "gpDetainInfos";
            gpDetainInfos.Size = new Size(1095, 195);
            gpDetainInfos.TabIndex = 17;
            gpDetainInfos.TabStop = false;
            gpDetainInfos.Text = "Detain Info";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppID.Location = new Point(841, 150);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(58, 28);
            lblAppID.TabIndex = 104;
            lblAppID.Text = "[???]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.fees;
            pictureBox6.Location = new Point(785, 150);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 103;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(595, 147);
            label6.Name = "label6";
            label6.Size = new Size(172, 29);
            label6.TabIndex = 102;
            label6.Text = "Application ID :";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(282, 147);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(58, 28);
            lblTotalFees.TabIndex = 101;
            lblTotalFees.Text = "[???]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fees;
            pictureBox3.Location = new Point(226, 147);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 100;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 144);
            label7.Name = "label7";
            label7.Size = new Size(127, 29);
            label7.TabIndex = 99;
            label7.Text = "Total Fees :";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFees.Location = new Point(282, 115);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(58, 28);
            lblAppFees.TabIndex = 98;
            lblAppFees.Text = "[???]";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fees;
            pictureBox2.Location = new Point(226, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 112);
            label4.Name = "label4";
            label4.Size = new Size(192, 29);
            label4.TabIndex = 96;
            label4.Text = "Application Fees :";
            // 
            // lblFineFees
            // 
            lblFineFees.AutoSize = true;
            lblFineFees.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFineFees.Location = new Point(840, 113);
            lblFineFees.Name = "lblFineFees";
            lblFineFees.Size = new Size(58, 28);
            lblFineFees.TabIndex = 95;
            lblFineFees.Text = "[???]";
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
            pictureBox4.Image = Properties.Resources.IssueRemplacement;
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
            pictureBox1.Location = new Point(226, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 26);
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
            lblCreatedBy.Location = new Point(840, 77);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(58, 28);
            lblCreatedBy.TabIndex = 85;
            lblCreatedBy.Text = "[???]";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.admin;
            pictureBox9.Location = new Point(785, 77);
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
            lblAppDate7.Location = new Point(630, 76);
            lblAppDate7.Name = "lblAppDate7";
            lblAppDate7.Size = new Size(137, 29);
            lblAppDate7.TabIndex = 83;
            lblAppDate7.Text = "Created By :";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.fees;
            pictureBox5.Location = new Point(784, 113);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 69;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(648, 110);
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
            lblFormHeader.Location = new Point(346, 9);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new Size(445, 50);
            lblFormHeader.TabIndex = 16;
            lblFormHeader.Text = "Release Detained License";
            // 
            // usFindShowLocalDrivingLicense1
            // 
            usFindShowLocalDrivingLicense1.Location = new Point(10, 78);
            usFindShowLocalDrivingLicense1.Name = "usFindShowLocalDrivingLicense1";
            usFindShowLocalDrivingLicense1.Size = new Size(1094, 470);
            usFindShowLocalDrivingLicense1.TabIndex = 15;
            usFindShowLocalDrivingLicense1.Load += usFindShowLocalDrivingLicense1_Load;
            // 
            // frmReleaseDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1152, 890);
            Controls.Add(plButtom);
            Controls.Add(gpDetainInfos);
            Controls.Add(lblFormHeader);
            Controls.Add(usFindShowLocalDrivingLicense1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReleaseDetainedLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release Detained License";
            Load += frmReleaseDetainedLicense_Load;
            plButtom.ResumeLayout(false);
            plButtom.PerformLayout();
            gpDetainInfos.ResumeLayout(false);
            gpDetainInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plButtom;
        private LinkLabel llblShowLicensesInfos;
        private Button btnRelease;
        private LinkLabel llblShowLicensesHistory;
        private GroupBox gpDetainInfos;
        private Label lblLicenseID;
        private PictureBox pictureBox4;
        private Label label8;
        private Label lblDetainDate;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblCreatedBy;
        private PictureBox pictureBox9;
        private Label lblAppDate7;
        private PictureBox pictureBox5;
        private Label label9;
        private Label lblDetainID;
        private Label label5;
        private ReaLTaiizor.Controls.BigLabel lblFormHeader;
        private usFindShowLocalDrivingLicense usFindShowLocalDrivingLicense1;
        private Label lblFineFees;
        private Label lblTotalFees;
        private PictureBox pictureBox3;
        private Label label7;
        private Label lblAppFees;
        private PictureBox pictureBox2;
        private Label label4;
        private Label lblAppID;
        private PictureBox pictureBox6;
        private Label label6;
    }
}