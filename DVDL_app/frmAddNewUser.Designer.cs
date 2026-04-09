namespace DVDL_app
{
    partial class frmAddNewUser
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
            tabControl1 = new TabControl();
            tpPersonalInfo = new TabPage();
            button1 = new Button();
            gpPersonalInfos = new GroupBox();
            gbFilter = new GroupBox();
            btnAddPerson = new ReaLTaiizor.Controls.Button();
            btnSearch = new ReaLTaiizor.Controls.Button();
            tbxfilterby = new TextBox();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            tpLoginPage = new TabPage();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            htActive = new ReaLTaiizor.Controls.HopeToggle();
            tbxConfirmPass = new ReaLTaiizor.Controls.AloneTextBox();
            tbxPassword = new ReaLTaiizor.Controls.AloneTextBox();
            tbxUserName = new ReaLTaiizor.Controls.AloneTextBox();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            lblUserid = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            tabControl1.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            gbFilter.SuspendLayout();
            tpLoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonalInfo);
            tabControl1.Controls.Add(tpLoginPage);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 123);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1116, 732);
            tabControl1.TabIndex = 1;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(button1);
            tpPersonalInfo.Controls.Add(gpPersonalInfos);
            tpPersonalInfo.Controls.Add(gbFilter);
            tpPersonalInfo.Location = new Point(4, 37);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(1108, 691);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.nextarrow;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(958, 626);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gpPersonalInfos
            // 
            gpPersonalInfos.Location = new Point(9, 141);
            gpPersonalInfos.Name = "gpPersonalInfos";
            gpPersonalInfos.Size = new Size(1084, 468);
            gpPersonalInfos.TabIndex = 1;
            gpPersonalInfos.TabStop = false;
            gpPersonalInfos.Text = "Personal Infos";
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddPerson);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(tbxfilterby);
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(cbFilterBy);
            gbFilter.Location = new Point(16, 18);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1076, 104);
            gbFilter.TabIndex = 0;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.Transparent;
            btnAddPerson.BackgroundImageLayout = ImageLayout.None;
            btnAddPerson.BorderColor = Color.Transparent;
            btnAddPerson.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAddPerson.EnteredColor = Color.Transparent;
            btnAddPerson.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddPerson.Image = Properties.Resources.user_16382065;
            btnAddPerson.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddPerson.InactiveColor = Color.Transparent;
            btnAddPerson.Location = new Point(856, 33);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.PressedBorderColor = Color.Transparent;
            btnAddPerson.PressedColor = Color.FromArgb(165, 37, 37);
            btnAddPerson.Size = new Size(54, 58);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.TextAlignment = StringAlignment.Center;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.BorderColor = Color.Transparent;
            btnSearch.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSearch.EnteredColor = Color.Transparent;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearch.Image = Properties.Resources.searchuser;
            btnSearch.ImageAlign = ContentAlignment.MiddleCenter;
            btnSearch.InactiveColor = Color.Transparent;
            btnSearch.Location = new Point(775, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedBorderColor = Color.Transparent;
            btnSearch.PressedColor = Color.FromArgb(165, 37, 37);
            btnSearch.Size = new Size(54, 58);
            btnSearch.TabIndex = 3;
            btnSearch.TextAlignment = StringAlignment.Center;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxfilterby
            // 
            tbxfilterby.BorderStyle = BorderStyle.FixedSingle;
            tbxfilterby.Location = new Point(445, 40);
            tbxfilterby.Name = "tbxfilterby";
            tbxfilterby.Size = new Size(272, 34);
            tbxfilterby.TabIndex = 2;
            tbxfilterby.Validating += tbxfilterby_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 1;
            label1.Text = "Find By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FlatStyle = FlatStyle.System;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "PersonID", "NationalNo" });
            cbFilterBy.Location = new Point(120, 39);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(289, 36);
            cbFilterBy.TabIndex = 0;
            // 
            // tpLoginPage
            // 
            tpLoginPage.Controls.Add(bigLabel2);
            tpLoginPage.Controls.Add(htActive);
            tpLoginPage.Controls.Add(tbxConfirmPass);
            tpLoginPage.Controls.Add(tbxPassword);
            tpLoginPage.Controls.Add(tbxUserName);
            tpLoginPage.Controls.Add(pictureBox4);
            tpLoginPage.Controls.Add(label9);
            tpLoginPage.Controls.Add(pictureBox3);
            tpLoginPage.Controls.Add(label7);
            tpLoginPage.Controls.Add(pictureBox2);
            tpLoginPage.Controls.Add(label5);
            tpLoginPage.Controls.Add(lblUserid);
            tpLoginPage.Controls.Add(pictureBox1);
            tpLoginPage.Controls.Add(label2);
            tpLoginPage.Location = new Point(4, 37);
            tpLoginPage.Name = "tpLoginPage";
            tpLoginPage.Padding = new Padding(3);
            tpLoginPage.Size = new Size(1108, 691);
            tpLoginPage.TabIndex = 1;
            tpLoginPage.Text = "Login Info";
            tpLoginPage.UseVisualStyleBackColor = true;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(434, 365);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(87, 31);
            bigLabel2.TabIndex = 15;
            bigLabel2.Text = "Active?";
            // 
            // htActive
            // 
            htActive.AutoSize = true;
            htActive.BaseColor = Color.Transparent;
            htActive.BaseColorA = Color.FromArgb(220, 223, 230);
            htActive.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            htActive.Checked = true;
            htActive.CheckState = CheckState.Checked;
            htActive.ForeColor = Color.Transparent;
            htActive.HeadColorA = Color.FromArgb(220, 223, 230);
            htActive.HeadColorB = Color.White;
            htActive.HeadColorC = Color.FromArgb(64, 158, 255);
            htActive.HeadColorD = Color.FromArgb(64, 158, 255);
            htActive.Location = new Point(362, 372);
            htActive.Name = "htActive";
            htActive.Size = new Size(48, 20);
            htActive.TabIndex = 14;
            htActive.UseVisualStyleBackColor = true;
            // 
            // tbxConfirmPass
            // 
            tbxConfirmPass.BackColor = Color.Transparent;
            tbxConfirmPass.EnabledCalc = true;
            tbxConfirmPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxConfirmPass.ForeColor = Color.FromArgb(64, 0, 0);
            tbxConfirmPass.Location = new Point(399, 296);
            tbxConfirmPass.MaxLength = 32767;
            tbxConfirmPass.MultiLine = false;
            tbxConfirmPass.Name = "tbxConfirmPass";
            tbxConfirmPass.ReadOnly = false;
            tbxConfirmPass.Size = new Size(224, 45);
            tbxConfirmPass.TabIndex = 13;
            tbxConfirmPass.TextAlign = HorizontalAlignment.Left;
            tbxConfirmPass.UseSystemPasswordChar = false;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.Transparent;
            tbxPassword.EnabledCalc = true;
            tbxPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.ForeColor = Color.FromArgb(64, 0, 0);
            tbxPassword.Location = new Point(399, 228);
            tbxPassword.MaxLength = 32767;
            tbxPassword.MultiLine = false;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.ReadOnly = false;
            tbxPassword.Size = new Size(224, 45);
            tbxPassword.TabIndex = 12;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.UseSystemPasswordChar = false;
            // 
            // tbxUserName
            // 
            tbxUserName.BackColor = Color.Transparent;
            tbxUserName.EnabledCalc = true;
            tbxUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserName.ForeColor = Color.FromArgb(64, 0, 0);
            tbxUserName.Location = new Point(399, 163);
            tbxUserName.MaxLength = 32767;
            tbxUserName.MultiLine = false;
            tbxUserName.Name = "tbxUserName";
            tbxUserName.ReadOnly = false;
            tbxUserName.Size = new Size(224, 45);
            tbxUserName.TabIndex = 11;
            tbxUserName.TextAlign = HorizontalAlignment.Left;
            tbxUserName.UseSystemPasswordChar = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.personidIcon;
            pictureBox4.Location = new Point(339, 310);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(87, 310);
            label9.Name = "label9";
            label9.Size = new Size(246, 28);
            label9.TabIndex = 9;
            label9.Text = "Confirm Password : ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.personidIcon;
            pictureBox3.Location = new Point(339, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 242);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 6;
            label7.Text = "Password : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.username_32;
            pictureBox2.Location = new Point(339, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(169, 172);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 3;
            label5.Text = "User Name : ";
            // 
            // lblUserid
            // 
            lblUserid.AutoSize = true;
            lblUserid.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserid.Location = new Point(399, 112);
            lblUserid.Name = "lblUserid";
            lblUserid.Size = new Size(58, 28);
            lblUserid.TabIndex = 2;
            lblUserid.Text = "[???]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.personidIcon;
            pictureBox1.Location = new Point(339, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 112);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 0;
            label2.Text = "User ID : ";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Firebrick;
            bigLabel1.Location = new Point(402, 33);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(299, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Add New User";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.save_icon_32png;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(500, 865);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddNewUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 927);
            Controls.Add(btnSave);
            Controls.Add(bigLabel1);
            Controls.Add(tabControl1);
            Name = "frmAddNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewUser";
            Load += frmAddNewUser_Load;
            tabControl1.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            tpLoginPage.ResumeLayout(false);
            tpLoginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tpPersonalInfo;
        private TabPage tpLoginPage;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private GroupBox gbFilter;
        private TextBox tbxfilterby;
        private Label label1;
        private ComboBox cbFilterBy;
        private ReaLTaiizor.Controls.Button btnSearch;
        private ReaLTaiizor.Controls.Button btnAddPerson;
        private GroupBox gpPersonalInfos;
        private ErrorProvider errorProvider1;
        private Label lblUserid;
        private PictureBox pictureBox1;
        private Label label2;
        private ReaLTaiizor.Controls.AloneTextBox tbxUserName;
        private PictureBox pictureBox4;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label5;
        private ReaLTaiizor.Controls.AloneTextBox tbxConfirmPass;
        private ReaLTaiizor.Controls.AloneTextBox tbxPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.HopeToggle htActive;
        private Button button1;
        private Button btnSave;
    }
}