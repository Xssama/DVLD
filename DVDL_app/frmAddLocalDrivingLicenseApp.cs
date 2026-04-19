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
    public partial class frmAddLocalDrivingLicenseApp : Form
    {
        clsPerson _person = new clsPerson();
        clsApplication _app = new clsApplication();
        clsLocalDrivingLicenseApplication _LDLapp = new clsLocalDrivingLicenseApplication();
        DateTime _nowdate = DateTime.Now;
        public frmAddLocalDrivingLicenseApp()
        {
            InitializeComponent();
        }

        private void usFindPerson1_Load(object sender, EventArgs e)
        {
            usFindPerson1.SendIDBack += GetThePersonIDBackFromFindPerson;

        }

        private void GetThePersonIDBackFromFindPerson(object sender, int ID)
        {
            _person = clsPerson.Find(ID);
        }

        private void frmAddLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            DataTable dt = clsDrivingLicenseClasse.GetList();
            foreach (DataRow row in dt.Rows)
            {
                cbLicenseClasse.Items.Add(row["ClassName"]);
            }
            cbLicenseClasse.SelectedIndex = 0;

            lblAppDate.Text = _nowdate.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void cbLicenseClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFees.Text = clsDrivingLicenseClasse.Find(cbLicenseClasse.SelectedIndex + 1).ClassFees.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpAppInfos;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_person.PersonID == -1 )
            {
                MessageBox.Show("You didn't provide the person concerned", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (clsLocalDrivingLicenseApplication.IsPersonAlreadyAppliedToLicenseClass(_person.PersonID, cbLicenseClasse.SelectedIndex + 1))
            {
                MessageBox.Show("You Already applied to the license class, choose another driving class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _app.ApplicantPersonID = _person.PersonID;
                _app.ApplicationDate = _nowdate;
                _app.LastStatusDate = _nowdate;
                _app.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _app.ApplicationTypeID = 1;
                _app.ApplicationStatus = 1;
                _app.PaidFees = Convert.ToDecimal(lblFees.Text);
                if (_app.Save())
                {
                    _LDLapp.ApplicationID = _app.ApplicationID;
                    _LDLapp.LicenseClassID = cbLicenseClasse.SelectedIndex + 1;
                    if (_LDLapp.Save())
                    {
                        lblAppID.Text = _LDLapp.LocalDrivingLicenseApplicationID.ToString();
                        MessageBox.Show("The application is under review", "Application is successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The application failed, please try again", "Application failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsApplication.DeleteApplication(_app.ApplicationID);
                    }
                }
                else
                {
                    MessageBox.Show("The application failed, please try again", "Application failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
