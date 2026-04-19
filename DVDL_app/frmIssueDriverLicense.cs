using DVLD_BUSINESS;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmIssueDriverLicense : Form
    {
        clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();
        clsLicense _License = new clsLicense();
        clsApplication _app = new clsApplication();
        clsDrivingLicenseClasse _LicenseClass = new clsDrivingLicenseClasse();
        clsDriver _Driver = new clsDriver();
        public frmIssueDriverLicense(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _app = clsApplication.Find(_LDLApp.ApplicationID);
            _LicenseClass = clsDrivingLicenseClasse.Find(_LDLApp.LicenseClassID);
            InitializeComponent();
        }

        private void frmIssueDriverLicense_Load(object sender, EventArgs e)
        {
            usBasicApplicationInfos usBasicInfos = new usBasicApplicationInfos(_LDLApp.LocalDrivingLicenseApplicationID);
            usBasicInfos.Dock = DockStyle.Fill;
            plLDLBasicInfos.Controls.Add(usBasicInfos);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool DriverIsNew = false;
            _Driver = clsDriver.FindByPersonID(_app.ApplicantPersonID);
            if (_Driver.DriverID == -1)
            {
                 DriverIsNew = true;
                _Driver.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _Driver.CreatedDate = DateTime.Now;
                _Driver.PersonID = _app.ApplicantPersonID;
                if (!_Driver.Save())
                {
                    MessageBox.Show("The Driver failed to Save!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           

            _License.IssueReason = 1;
            _License.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _License.IsActive = true;
            _License.PaidFees = _LicenseClass.ClassFees;
            _License.Notes = tbxNotes.Text.Trim();
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
            _License.LicenseClass = _LDLApp.LicenseClassID;
            _License.DriverID = _Driver.DriverID;
            _License.ApplicationID = _app.ApplicationID;

            if (_License.Save())
            {
                _app.ApplicationStatus = 3;
                _app.LastStatusDate = DateTime.Now;
                if (_app.Save())
                {
                    MessageBox.Show("The License is Issued successfully :)", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The Application failed to Update!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    clsLicense.DeleteLicense(_License.LicenseID);
                    if (DriverIsNew)
                    {
                        clsDriver.DeleteDriver(_Driver.DriverID);
                    }
                }
            }
            else
            {
                MessageBox.Show("The License isn't Issued , Something happend:(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsDriver.DeleteDriver(_Driver.DriverID);
            }
        }
    }
}
