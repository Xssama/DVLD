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
    public partial class usBasicApplicationInfos : UserControl
    {
        clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();
        clsApplication _ApplicationInfos = new clsApplication();
        enum enAppStatus { New = 1, Cancelled = 2, Completed = 3 };
        public usBasicApplicationInfos(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _ApplicationInfos = clsApplication.Find(_LDLApp.ApplicationID);
            InitializeComponent();
        }

        private void usBasicApplicationInfos_Load(object sender, EventArgs e)
        {
            lblAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = clsDrivingLicenseClasse.Find(_LDLApp.LicenseClassID).ClassName;
            lblPassedTests.Text = _LDLApp.PassedTests().ToString();
            if (_ApplicationInfos.ApplicationStatus != 3)
            {
                lblShowLicenseInfos.Enabled = false;
            }
            else
            {
                lblShowLicenseInfos.Enabled = true;

            }
            lblID.Text = _ApplicationInfos.ApplicationID.ToString();
            lblStatus.Text = ((enAppStatus)_ApplicationInfos.ApplicationStatus).ToString();
            lblFees.Text = _ApplicationInfos.PaidFees.ToString();
            lbltype.Text = clsApplicationType.Find((_ApplicationInfos.ApplicationTypeID)).Title;
            clsPerson _person = clsPerson.Find(_ApplicationInfos.ApplicantPersonID);
            lblApplicant.Text = _person.FirstName + " " + _person.SecondName + " " + (_person.ThirdName != null ? _person.ThirdName + " " : "") + _person.LastName;
            lblDate.Text = _ApplicationInfos.ApplicationDate.ToShortDateString();
            lblDateStatus.Text = _ApplicationInfos.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = _ApplicationInfos.CreatedByUserID.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInformations frm = new frmPersonInformations(_ApplicationInfos.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
