using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BUSINESS;
namespace DVDL_app
{
    public partial class frmMainScreen : Form
    {

        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void loginUserInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfos frmuserinfos = new frmUserInfos(clsGlobal.CurrentUser.UserID);
            frmuserinfos.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frmchangepass = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            frmchangepass.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersList manageusers = new FrmUsersList();
            manageusers.StartPosition = FormStartPosition.CenterScreen;
            manageusers.ShowDialog();
        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageAppTypes apptypes = new frmManageAppTypes();
            apptypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes managetesttype = new frmManageTestTypes();
            managetesttype.ShowDialog();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLocalDrivingLicenseApp addLDLapp = new frmAddLocalDrivingLicenseApp();
            addLDLapp.ShowDialog();
        }

        private void localDriingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmPeople = new FrmManagePeople();
            frmPeople.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frmManage = new frmManageDrivers();
            frmManage.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicenseApp IssueInterLicense = new frmIssueInternationalLicenseApp();
            IssueInterLicense.ShowDialog();
        }

        private void internationalDrivingLicenseApplicatonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicensesApplications manageIntLicenses = new frmManageInternationalLicensesApplications();
            manageIntLicenses.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replacedForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementLostDamagedLicense frm = new frmReplacementLostDamagedLicense();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense();
            ReleaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses DetainedLicenses = new frmManageDetainedLicenses();
            DetainedLicenses.ShowDialog();
        }
    }
}
