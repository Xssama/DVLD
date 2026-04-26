using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmReleaseDetainedLicense : Form
    {
        clsApplicationType _AppTypeInfos = clsApplicationType.Find("Release Detained Driving Licsense");
        clsLicense _License = new clsLicense();
        clsDetainedLicense _DetainedLicense = new clsDetainedLicense();
        clsApplication _ReleaseApplication = new clsApplication();
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void usFindShowLocalDrivingLicense1_Load(object sender, EventArgs e)
        {
            usFindShowLocalDrivingLicense1.LicenseIDBack += GetLicenseIDBackFromFindLicenseControl;
        }
        private void GetLicenseIDBackFromFindLicenseControl(object sender, int LicenseID)
        {
            if (LicenseID == -1)
            {
                return;
            }
            if (!clsLicense.isLicenseDetained(LicenseID))
            {
                MessageBox.Show("The License is Not Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;

                lblDetainDate.Text = "[???]";
                lblFineFees.Text = "[???]";
                lblTotalFees.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;
                lblLicenseID.Text = "[???]";
                return;
            }
            _License = clsLicense.Find(LicenseID);
            if (_License != null && _License.LicenseID != -1)
            {
                _DetainedLicense = clsDetainedLicense.FindByLicenseID(_License.LicenseID);

                lblFineFees.Text = _DetainedLicense.FineFees.ToString();
                lblTotalFees.Text = (_AppTypeInfos.Fees + _DetainedLicense.FineFees).ToString();
                lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
                btnRelease.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                lblLicenseID.Text = _License.LicenseID.ToString();
            }
            else
            {
                lblDetainDate.Text = "[???]";
                lblFineFees.Text = "[???]";
                lblTotalFees.Text = "[???]";
                btnRelease.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                lblLicenseID.Text = "[???]";
            }
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            lblAppFees.Text = _AppTypeInfos.Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory PersonLicensesHistory = new frmPersonLicenseHistory(clsDriver.Find(_License.DriverID).PersonID);
            PersonLicensesHistory.ShowDialog();
        }

        private void llblShowLicensesInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfos LicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID(_License.LicenseID);
            LicenseInfos.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            _ReleaseApplication.ApplicationTypeID = _AppTypeInfos.ID;
            _ReleaseApplication.ApplicantPersonID = clsDriver.Find(_License.DriverID).PersonID;
            _ReleaseApplication.PaidFees = Convert.ToDecimal(_AppTypeInfos.Fees + _DetainedLicense.FineFees);
            _ReleaseApplication.ApplicationStatus = 3;
            _ReleaseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_ReleaseApplication.Save())
            {
                if (_DetainedLicense.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, _ReleaseApplication.ApplicationID))
                {
                    lblAppID.Text = _ReleaseApplication.ApplicationID.ToString();
                    lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                    MessageBox.Show("The License is Released Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRelease.Enabled = false;
                    usFindShowLocalDrivingLicense1.Enabled = false;
                    llblShowLicensesInfos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The License Failled to save!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The Application Failled to Save!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
