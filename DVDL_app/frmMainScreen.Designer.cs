namespace DVDL_app
{
    partial class frmMainScreen
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
            menuStrip1 = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            replacedForLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripSeparator();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDriingToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseApplicatonsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            applicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            detainToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseLicenseToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            UsersToolStripMenuItem = new ToolStripMenuItem();
            AccountSettingsToolStripMenuItem = new ToolStripMenuItem();
            loginUserInfosToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, UsersToolStripMenuItem, AccountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1858, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesToolStripMenuItem, toolStripMenuItem2, manageApplicationsToolStripMenuItem, toolStripMenuItem3, applicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem, detainToolStripMenuItem });
            applicationsToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationsToolStripMenuItem.Image = Properties.Resources.Applications1;
            applicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(173, 36);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesToolStripMenuItem
            // 
            drivingLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, toolStripMenuItem4, replacedForLostOrDamagedLicenseToolStripMenuItem, toolStripMenuItem6 });
            drivingLicensesToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drivingLicensesToolStripMenuItem.Image = Properties.Resources.licenseServices;
            drivingLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesToolStripMenuItem.Name = "drivingLicensesToolStripMenuItem";
            drivingLicensesToolStripMenuItem.Size = new Size(330, 38);
            drivingLicensesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = Properties.Resources.addNew;
            newDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(459, 38);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localToolStripMenuItem
            // 
            localToolStripMenuItem.Image = Properties.Resources.local;
            localToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localToolStripMenuItem.Name = "localToolStripMenuItem";
            localToolStripMenuItem.Size = new Size(284, 38);
            localToolStripMenuItem.Text = "Local License";
            localToolStripMenuItem.Click += localToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Image = Properties.Resources.international_2936692;
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(284, 38);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(459, 38);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving license";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(456, 6);
            // 
            // replacedForLostOrDamagedLicenseToolStripMenuItem
            // 
            replacedForLostOrDamagedLicenseToolStripMenuItem.Image = Properties.Resources.DamagedLicense;
            replacedForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replacedForLostOrDamagedLicenseToolStripMenuItem.Name = "replacedForLostOrDamagedLicenseToolStripMenuItem";
            replacedForLostOrDamagedLicenseToolStripMenuItem.Size = new Size(459, 38);
            replacedForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement  for Lost or Damaged License";
            replacedForLostOrDamagedLicenseToolStripMenuItem.Click += replacedForLostOrDamagedLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(456, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(327, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDriingToolStripMenuItem, internationalDrivingLicenseApplicatonsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageApplicationsToolStripMenuItem.Image = Properties.Resources.Applications;
            manageApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(330, 38);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDriingToolStripMenuItem
            // 
            localDriingToolStripMenuItem.Image = Properties.Resources.driving_license_3410372;
            localDriingToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDriingToolStripMenuItem.Name = "localDriingToolStripMenuItem";
            localDriingToolStripMenuItem.Size = new Size(453, 38);
            localDriingToolStripMenuItem.Text = "Local Driving License Applications";
            localDriingToolStripMenuItem.Click += localDriingToolStripMenuItem_Click;
            // 
            // internationalDrivingLicenseApplicatonsToolStripMenuItem
            // 
            internationalDrivingLicenseApplicatonsToolStripMenuItem.Image = Properties.Resources.international_2936692;
            internationalDrivingLicenseApplicatonsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalDrivingLicenseApplicatonsToolStripMenuItem.Name = "internationalDrivingLicenseApplicatonsToolStripMenuItem";
            internationalDrivingLicenseApplicatonsToolStripMenuItem.Size = new Size(453, 38);
            internationalDrivingLicenseApplicatonsToolStripMenuItem.Text = "International Driving License Applicatons";
            internationalDrivingLicenseApplicatonsToolStripMenuItem.Click += internationalDrivingLicenseApplicatonsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(327, 6);
            // 
            // applicationTypesToolStripMenuItem
            // 
            applicationTypesToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applicationTypesToolStripMenuItem.Image = Properties.Resources.manageapptypes;
            applicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicationTypesToolStripMenuItem.Name = "applicationTypesToolStripMenuItem";
            applicationTypesToolStripMenuItem.Size = new Size(330, 38);
            applicationTypesToolStripMenuItem.Text = "Manage Application Types";
            applicationTypesToolStripMenuItem.Click += applicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageTestTypesToolStripMenuItem.Image = Properties.Resources.edittype;
            manageTestTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(330, 38);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // detainToolStripMenuItem
            // 
            detainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicensesToolStripMenuItem, detainLicenseToolStripMenuItem, releaseLicenseToolStripMenuItem });
            detainToolStripMenuItem.Font = new Font("Andalus", 12F);
            detainToolStripMenuItem.Image = Properties.Resources.Detain;
            detainToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainToolStripMenuItem.Name = "detainToolStripMenuItem";
            detainToolStripMenuItem.Size = new Size(330, 38);
            detainToolStripMenuItem.Text = "Detain";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            manageDetainedLicensesToolStripMenuItem.Image = Properties.Resources.ManageDetainedLicenses;
            manageDetainedLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            manageDetainedLicensesToolStripMenuItem.Size = new Size(329, 38);
            manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = Properties.Resources.DetainLicense;
            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(329, 38);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseLicenseToolStripMenuItem
            // 
            releaseLicenseToolStripMenuItem.Image = Properties.Resources.ReleaseLicense;
            releaseLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            releaseLicenseToolStripMenuItem.Size = new Size(329, 38);
            releaseLicenseToolStripMenuItem.Text = "Release Detain License";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Image = Properties.Resources.people;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(120, 36);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            driversToolStripMenuItem.Image = Properties.Resources.drivers;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(128, 36);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // UsersToolStripMenuItem
            // 
            UsersToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersToolStripMenuItem.Image = Properties.Resources.ManageUsers32;
            UsersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            UsersToolStripMenuItem.Size = new Size(110, 36);
            UsersToolStripMenuItem.Text = "Users";
            UsersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
            // 
            // AccountSettingsToolStripMenuItem
            // 
            AccountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginUserInfosToolStripMenuItem, changePasswordToolStripMenuItem, toolStripMenuItem1, signOutToolStripMenuItem });
            AccountSettingsToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountSettingsToolStripMenuItem.Image = Properties.Resources.Accountsettingsicon;
            AccountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem";
            AccountSettingsToolStripMenuItem.Size = new Size(212, 36);
            AccountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // loginUserInfosToolStripMenuItem
            // 
            loginUserInfosToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUserInfosToolStripMenuItem.Image = Properties.Resources.userresume;
            loginUserInfosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loginUserInfosToolStripMenuItem.Name = "loginUserInfosToolStripMenuItem";
            loginUserInfosToolStripMenuItem.Size = new Size(267, 38);
            loginUserInfosToolStripMenuItem.Text = "Current User Infos";
            loginUserInfosToolStripMenuItem.Click += loginUserInfosToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePasswordToolStripMenuItem.Image = Properties.Resources.change_password;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(267, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(264, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutToolStripMenuItem.Image = Properties.Resources.log_out_7269889;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(267, 38);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1858, 973);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainScreen";
            Text = "Driving Licenses Management";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private ToolStripMenuItem AccountSettingsToolStripMenuItem;
        private ToolStripMenuItem loginUserInfosToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem applicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem localDriingToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseApplicatonsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem replacedForLostOrDamagedLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem detainToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}