using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmDetainLicense : Form
    {
        private usFindShowLocalDrivingLicense _FindShowLicense;
        clsLicense _License = new clsLicense();
        clsDetainedLicense _DetainedLicense = new clsDetainedLicense();
        public frmDetainLicense(int LicenseID = -1)
        {
            InitializeComponent();
            if (LicenseID != -1 && clsLicense.IsExists(LicenseID))
            {
                _License = clsLicense.Find(LicenseID);
                btnDetain.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
            }
        }

        private void tbxFees_Validating(object sender, CancelEventArgs e)
        {
            if (tbxFees.Text.IsNullOrEmpty() || !float.TryParse(tbxFees.Text, out _))
            {
                errorProvider1.SetError(tbxFees, "The Input in not valid, Try to enter Valid Amount");
            }
            else
            {
                errorProvider1.SetError(tbxFees, "");
            }
        }

        private void GetLicenseIDBackFromFindLicenseControl(object sender, int LicenseID)
        {
            if (clsLicense.isLicenseDetained(LicenseID))
            {
                MessageBox.Show("The License is Already Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                lblLicenseID.Text = "[???]";
                return;
            }
            _License = clsLicense.Find(LicenseID);
            if (_License != null && _License.LicenseID != -1)
            {
                btnDetain.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                lblLicenseID.Text = _License.LicenseID.ToString();
            }
            else
            {
                btnDetain.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                lblLicenseID.Text = "[???]";
            }
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _FindShowLicense = new usFindShowLocalDrivingLicense(_License.LicenseID);
            _FindShowLicense.Dock = DockStyle.Fill;
            _FindShowLicense.LicenseIDBack += GetLicenseIDBackFromFindLicenseControl;
            plFindShowLicense.Controls.Add(_FindShowLicense);

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbxFees) != "" || tbxFees.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please Enter the Fine Fees with the Right Data First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxFees.Focus();
                return;
            }
            
            _DetainedLicense.LicenseID = _License.LicenseID;
            _DetainedLicense.IsReleased = false;
            _DetainedLicense.FineFees = float.Parse(tbxFees.Text);
            _DetainedLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_DetainedLicense.Save())
            {
                lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                MessageBox.Show("The License is Detained Successfully.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetain.Enabled = false;
                _FindShowLicense.gpFilter.Enabled = false;
                llblShowLicensesInfos.Enabled = true;
            }
            else
            {
                MessageBox.Show("The License Detained Failled!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory PersonLicenseHistory = new frmPersonLicenseHistory(clsDriver.Find(_License.DriverID).PersonID);
            PersonLicenseHistory.ShowDialog();
        }

        private void llblShowLicensesInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfos LicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID(_DetainedLicense.LicenseID);
            LicenseInfos.ShowDialog();
        }
    }
}
