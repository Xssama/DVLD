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
        clsApplication _Appliation = new clsApplication();
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

            lblAppDate.Text = _Appliation.ApplicationDate.ToShortDateString();
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
                MessageBox.Show("You Need to provide a valid/active local License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsLicense.is)
            {
                
            }
        }
    }
}
