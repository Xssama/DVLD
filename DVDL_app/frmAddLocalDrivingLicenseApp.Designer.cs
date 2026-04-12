namespace DVDL_app
{
    partial class frmAddLocalDrivingLicenseApp
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
            biglblAppID = new ReaLTaiizor.Controls.BigLabel();
            tabControl1 = new TabControl();
            tpPersonInfos = new TabPage();
            button1 = new Button();
            usFindPerson1 = new usFindPerson();
            tpAppInfos = new TabPage();
            lblCreatedBy = new Label();
            cbLicenseClasse = new ComboBox();
            lblFees = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            lblAppDate = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            lblAppID = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tpPersonInfos.SuspendLayout();
            tpAppInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // biglblAppID
            // 
            biglblAppID.AutoSize = true;
            biglblAppID.BackColor = Color.Transparent;
            biglblAppID.Font = new Font("Segoe UI", 25F);
            biglblAppID.ForeColor = Color.FromArgb(80, 80, 80);
            biglblAppID.Location = new Point(195, 9);
            biglblAppID.Name = "biglblAppID";
            biglblAppID.Size = new Size(729, 57);
            biglblAppID.TabIndex = 0;
            biglblAppID.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tpPersonInfos);
            tabControl1.Controls.Add(tpAppInfos);
            tabControl1.Location = new Point(12, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1135, 700);
            tabControl1.TabIndex = 1;
            // 
            // tpPersonInfos
            // 
            tpPersonInfos.Controls.Add(button1);
            tpPersonInfos.Controls.Add(usFindPerson1);
            tpPersonInfos.Location = new Point(4, 37);
            tpPersonInfos.Name = "tpPersonInfos";
            tpPersonInfos.Padding = new Padding(3);
            tpPersonInfos.Size = new Size(1127, 659);
            tpPersonInfos.TabIndex = 0;
            tpPersonInfos.Text = "Person Infos";
            tpPersonInfos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.nextarrow;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(956, 603);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 3;
            button1.Text = "Next";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usFindPerson1
            // 
            usFindPerson1.Location = new Point(3, 3);
            usFindPerson1.Name = "usFindPerson1";
            usFindPerson1.Size = new Size(1121, 594);
            usFindPerson1.TabIndex = 0;
            usFindPerson1.Load += usFindPerson1_Load;
            // 
            // tpAppInfos
            // 
            tpAppInfos.Controls.Add(lblCreatedBy);
            tpAppInfos.Controls.Add(cbLicenseClasse);
            tpAppInfos.Controls.Add(lblFees);
            tpAppInfos.Controls.Add(pictureBox5);
            tpAppInfos.Controls.Add(label3);
            tpAppInfos.Controls.Add(lblAppDate);
            tpAppInfos.Controls.Add(pictureBox4);
            tpAppInfos.Controls.Add(label9);
            tpAppInfos.Controls.Add(pictureBox3);
            tpAppInfos.Controls.Add(label7);
            tpAppInfos.Controls.Add(pictureBox2);
            tpAppInfos.Controls.Add(label5);
            tpAppInfos.Controls.Add(lblAppID);
            tpAppInfos.Controls.Add(pictureBox1);
            tpAppInfos.Controls.Add(label2);
            tpAppInfos.Location = new Point(4, 37);
            tpAppInfos.Name = "tpAppInfos";
            tpAppInfos.Padding = new Padding(3);
            tpAppInfos.Size = new Size(1127, 659);
            tpAppInfos.TabIndex = 1;
            tpAppInfos.Text = "Application Infos";
            tpAppInfos.UseVisualStyleBackColor = true;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(572, 437);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(58, 28);
            lblCreatedBy.TabIndex = 36;
            lblCreatedBy.Text = "[???]";
            // 
            // cbLicenseClasse
            // 
            cbLicenseClasse.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLicenseClasse.FormattingEnabled = true;
            cbLicenseClasse.Location = new Point(572, 302);
            cbLicenseClasse.Name = "cbLicenseClasse";
            cbLicenseClasse.Size = new Size(290, 41);
            cbLicenseClasse.TabIndex = 35;
            cbLicenseClasse.SelectedIndexChanged += cbLicenseClasse_SelectedIndexChanged;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(572, 368);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(58, 28);
            lblFees.TabIndex = 34;
            lblFees.Text = "[???]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.fees;
            pictureBox5.Location = new Point(484, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 368);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 31;
            label3.Text = "License Fees : ";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppDate.Location = new Point(572, 232);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(58, 28);
            lblAppDate.TabIndex = 30;
            lblAppDate.Text = "[???]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.admin;
            pictureBox4.Location = new Point(484, 437);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(297, 440);
            label9.Name = "label9";
            label9.Size = new Size(164, 28);
            label9.TabIndex = 23;
            label9.Text = "Created By : ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.personidIcon;
            pictureBox3.Location = new Point(484, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(256, 302);
            label7.Name = "label7";
            label7.Size = new Size(205, 28);
            label7.TabIndex = 21;
            label7.Text = "License Classe : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.appdate;
            pictureBox2.Location = new Point(484, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, 232);
            label5.Name = "label5";
            label5.Size = new Size(229, 28);
            label5.TabIndex = 19;
            label5.Text = "Application Date : ";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppID.Location = new Point(572, 172);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(58, 28);
            lblAppID.TabIndex = 33;
            lblAppID.Text = "[???]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DLApp;
            pictureBox1.Location = new Point(484, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 172);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 16;
            label2.Text = "L.D.L Application : ";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.save_icon_32png;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(495, 796);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddLocalDrivingLicenseApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 868);
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Controls.Add(biglblAppID);
            Name = "frmAddLocalDrivingLicenseApp";
            Text = "Local Driving License Application";
            Load += frmAddLocalDrivingLicenseApp_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfos.ResumeLayout(false);
            tpAppInfos.ResumeLayout(false);
            tpAppInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel biglblAppID;
        private TabControl tabControl1;
        private TabPage tpPersonInfos;
        private usFindPerson usFindPerson1;
        private TabPage tpAppInfos;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label5;
        private Label lblAppID;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblAppDate;
        private PictureBox pictureBox5;
        private Label label3;
        private ComboBox cbLicenseClasse;
        private Label lblFees;
        private PictureBox pictureBox4;
        private Label lblCreatedBy;
        private Button button1;
        private Button btnSave;
    }
}