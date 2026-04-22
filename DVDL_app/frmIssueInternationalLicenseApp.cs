using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmIssueInternationalLicenseApp : Form
    {
        clsApplicationType _ApplicationType = clsApplicationType.Find("New International License");
        clsLicense _LocalLicense = new clsLicense();
        clsApplication _Application = new clsApplication();
        clsInternationalLicense _InterLicense = new clsInternationalLicense();
        public frmIssueInternationalLicenseApp()
        {
            InitializeComponent();
        }

        private void usFindShowLocalDrivingLicense1_Load(object sender, EventArgs e)
        {
            usFindShowLocalDrivingLicense1.LicenseIDBack += GetLicenseIDBackFromControl;
        }

        private void RefreshApplicationinfosInForm()
        {

            lblAppDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblIssueDate.Text = _InterLicense.IssueDate.ToShortDateString();
            //lblLocalLicenseID.Text = _LocalLicense.LicenseID.ToString();
            lblFees.Text = _ApplicationType.Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblExpirationDate.Text = _InterLicense.IssueDate.AddYears(1).ToShortDateString();
        }
        private void GetLicenseIDBackFromControl(object sender, int LicenseID)
        {
            _LocalLicense = clsLicense.Find(LicenseID);
            if (_LocalLicense != null)
            {
                lblLocalLicenseID.Text = _LocalLicense.LicenseID.ToString();
                llblShowLicensesHistory.Enabled = true;
            }
            else
            {
                lblLocalLicenseID.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;

            }
        }

        private void frmIssueInternationalLicenseApp_Load(object sender, EventArgs e)
        {
            RefreshApplicationinfosInForm();
            llblShowLicensesHistory.Enabled = false;
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_LocalLicense.DriverID).PersonID);
            frm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_LocalLicense == null || _LocalLicense.LicenseID == -1 || _LocalLicense.IsActive == false || 
                _LocalLicense.ExpirationDate.CompareTo(DateTime.Now) < 0)
            { 
                MessageBox.Show("You Need to provide a valid/active local License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsLicense.isLicenseLinkedToInternationalLicense(_LocalLicense.LicenseID))
            {
                MessageBox.Show("The local License is already linked to an International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Application.ApplicantPersonID = clsDriver.Find(_LocalLicense.DriverID).PersonID;
            _Application.ApplicationTypeID = _ApplicationType.ID;
            _Application.ApplicationStatus = 0;
            _Application.PaidFees = Convert.ToDecimal(_ApplicationType.Fees);
            _Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Application.Save())
            {
                lblIAppID.Text = _Application.ApplicationID.ToString();
                _InterLicense.IssuedUsingLocalLicenseID = _LocalLicense.LicenseID;
                _InterLicense.ApplicationID = _Application.ApplicationID;
                _InterLicense.DriverID = _LocalLicense.DriverID;
                _InterLicense.IssueDate = DateTime.Now;
                _InterLicense.ExpirationDate = DateTime.Now.AddYears(1);
                _InterLicense.IsActive = true;
                _InterLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (_InterLicense.Save())
                {
                    lblInterLicenseID.Text = _InterLicense.InternationalLicenseID.ToString();
                    MessageBox.Show("The International License is issued successfully!");
                    btnIssue.Enabled = false;
                    usFindShowLocalDrivingLicense1.gpFilter.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The International license Failled to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsApplication.DeleteApplication(_Application.ApplicationID);
                }
            }
            else
            {
                MessageBox.Show("The application Failled to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
