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
    public partial class frmReplementLostDamagedLicense : Form
    {
        clsApplicationType _ApplicationType = new clsApplicationType();
        clsLicense _LocalLicense = new clsLicense();
        clsApplication _Application = new clsApplication();
        clsLicense _ReplacementLicense = new clsLicense();
        public frmReplementLostDamagedLicense()
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
            lblAppFees.Text = _ApplicationType.Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            rbDamagedLicense.Checked = true;
        }
        private void RefreshApplicationinfosInForm()
        {

        }
        private void GetLicenseIDBackFromControl(object sender, int LicenseID)
        {
            _LocalLicense = clsLicense.Find(LicenseID);
            if (_LocalLicense.IsActive == false)
            {
                MessageBox.Show("   Selected License is Not Active,Choose an Active License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLocalLicenseID.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;
                btnIssueReplacement.Enabled = false;
                return;
            }
            if (_LocalLicense != null && _LocalLicense.LicenseID != -1)
            {
                lblLocalLicenseID.Text = _LocalLicense.LicenseID.ToString();
                llblShowLicensesHistory.Enabled = true;
                btnIssueReplacement.Enabled = true;

            }
            else
            {
                lblLocalLicenseID.Text = "[???]";
                llblShowLicensesHistory.Enabled = false;
                btnIssueReplacement.Enabled = false;

            }
        }



        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(clsDriver.Find(_LocalLicense.DriverID).PersonID);
            frm.ShowDialog();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            clsDrivingLicenseClasse LicenseClass = clsDrivingLicenseClasse.Find(_LocalLicense.LicenseClass);
            _Application.ApplicantPersonID = clsDriver.Find(_LocalLicense.DriverID).PersonID;
            _Application.ApplicationTypeID = _ApplicationType.ID;
            _Application.ApplicationStatus = 3;
            _Application.PaidFees = Convert.ToDecimal(_ApplicationType.Fees);
            _Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Application.Save())
            {
                _ReplacementLicense.ApplicationID = _Application.ApplicationID;
                _ReplacementLicense.DriverID = _LocalLicense.DriverID;
                _ReplacementLicense.LicenseClass = _LocalLicense.LicenseClass;
                _ReplacementLicense.IssueDate = DateTime.Now;
                _ReplacementLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
                _ReplacementLicense.IsActive = true;
                _ReplacementLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
               
                _ReplacementLicense.Notes = "";
                _ReplacementLicense.IssueReason = (short)(rbDamagedLicense.Checked == true ? 3 : 4); //RENEW
                _ReplacementLicense.PaidFees = LicenseClass.ClassFees;

                _LocalLicense.IsActive = false; //Desctivate the old license
                if (_ReplacementLicense.Save() && _LocalLicense.Save())
                {
                    lblReplacedLicenseID.Text = _ReplacementLicense.LicenseID.ToString();
                    lblReplacementAppID.Text = _Application.ApplicationID.ToString();
                    MessageBox.Show("The License is Replaced successfully!");
                    btnIssueReplacement.Enabled = false;
                    gbReplacementfor.Enabled = false;
                    usFindShowLocalDrivingLicense1.gpFilter.Enabled = false;
                    llblShowLicensesInfos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The Renew of the local license Failled to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsLicense.DeleteLicense(_ReplacementLicense.LicenseID);
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
            frmShowLicenseInfos frmLicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID(_ReplacementLicense.LicenseID);
            frmLicenseInfos.ShowDialog();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked == true)
            {
                lblFormHeader.Text = "Replacement For Damaged License";
                _ApplicationType = clsApplicationType.Find("Replacement for a Damaged Driving License");
                lblAppFees.Text = _ApplicationType.Fees.ToString();
            }
            else
            {
                lblFormHeader.Text = "Replacement For Lost License";
                _ApplicationType = clsApplicationType.Find("Replacement for a Lost Driving License");
                lblAppFees.Text = _ApplicationType.Fees.ToString();
            }
        }
    }
}
