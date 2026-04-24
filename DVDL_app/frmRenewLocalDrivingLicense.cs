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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        clsApplicationType _ApplicationType = clsApplicationType.Find("Renew Driving License Service");
        clsLicense _LocalLicense = new clsLicense();
        clsApplication _Application = new clsApplication();
        clsLicense _RenewedLicense = new clsLicense();
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }
        private void usFindShowLocalDrivingLicense1_Load(object sender, EventArgs e)
        {
            usFindShowLocalDrivingLicense1.LicenseIDBack += GetLicenseIDBackFromControl;
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblIssueDate.Text = _RenewedLicense.IssueDate.ToShortDateString();
            lblAppFees.Text = _ApplicationType.Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

        }
        private void RefreshApplicationinfosInForm()
        {
            
        }
        private void GetLicenseIDBackFromControl(object sender, int LicenseID)
        {
            _LocalLicense = clsLicense.Find(LicenseID);
            if (_LocalLicense.ExpirationDate.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("   Selected License is not yet Expired,\n   it will expire on : " + _LocalLicense.ExpirationDate.ToShortDateString(), "License Not Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLocalLicenseID.Text = "[???]";
                lblLicenseFees.Text = "[???]";
                lblTotalFees.Text = "[???]";
                lblExpirationDate.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;
                btnRenew.Enabled = false;
                return;
            }
            if (_LocalLicense != null && _LocalLicense.LicenseID != -1)
            {
                clsDrivingLicenseClasse classtype = clsDrivingLicenseClasse.Find(_LocalLicense.LicenseClass);
                lblLocalLicenseID.Text = _LocalLicense.LicenseID.ToString();
                lblLicenseFees.Text = classtype.ClassFees.ToString();
                lblTotalFees.Text = (classtype.ClassFees + _ApplicationType.Fees).ToString();
                lblExpirationDate.Text = _Application.ApplicationDate.AddYears(classtype.DefaultValidityLength).ToShortDateString();
                llblShowLicensesHistory.Enabled = true;
                btnRenew.Enabled = true;

            }
            else
            {
                lblLocalLicenseID.Text = "[???]";
                lblLicenseFees.Text = "[???]";
                lblTotalFees.Text = "[???]";
                lblExpirationDate.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;
                btnRenew.Enabled = false;

            }
        }

        

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_LocalLicense.DriverID).PersonID);
            frm.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
           

            _Application.ApplicantPersonID = clsDriver.Find(_LocalLicense.DriverID).PersonID;
            _Application.ApplicationTypeID = _ApplicationType.ID;
            _Application.ApplicationStatus = 3;
            _Application.PaidFees = Convert.ToDecimal((_ApplicationType.Fees + clsDrivingLicenseClasse.Find(_LocalLicense.LicenseClass).ClassFees));
            _Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Application.Save())
            {
                _RenewedLicense.ApplicationID = _Application.ApplicationID;
                _RenewedLicense.DriverID = _LocalLicense.DriverID;
                _RenewedLicense.LicenseClass = _LocalLicense.LicenseClass;
                _RenewedLicense.IssueDate = DateTime.Now;
                _RenewedLicense.ExpirationDate = DateTime.Now.AddYears(clsDrivingLicenseClasse.Find(_LocalLicense.LicenseClass).DefaultValidityLength);
                _RenewedLicense.IsActive = true;
                _RenewedLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (!tbxNotes.Text.Trim().IsNullOrEmpty())
                {
                    _RenewedLicense.Notes = tbxNotes.Text.Trim();
                }
                else
                {
                    _RenewedLicense.Notes = "";
                }
                _RenewedLicense.IssueReason = 2;

                if (_RenewedLicense.Save())
                {
                    lblRenewedLicenseID.Text = _RenewedLicense.LicenseID.ToString();
                    lblRenewAppID.Text = _Application.ApplicationID.ToString();
                    MessageBox.Show("The International License is issued successfully!");
                    btnRenew.Enabled = false;
                    usFindShowLocalDrivingLicense1.gpFilter.Enabled = false;
                    llblShowLicensesInfos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The Renew of the local license Failled to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsApplication.DeleteApplication(_Application.ApplicationID);
                }
            }
            else
            {
                MessageBox.Show("The application Failled to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblShowLicenseInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfos frmLicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID(_RenewedLicense.LicenseID);
            frmLicenseInfos.ShowDialog();
        }

    }
}
