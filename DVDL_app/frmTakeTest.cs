using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DVDL_app
{
    public partial class frmTakeTest : Form
    {
        clsTest Test = new clsTest();
        clsTestAppointment _TestApp = new clsTestAppointment();
        DataRow rowApplicationInfos;
        public frmTakeTest(int TestAppID)
        {
            _TestApp = clsTestAppointment.Find(TestAppID);
            rowApplicationInfos = clsLocalDrivingLicenseApplication.ReturnDataRowFromLDLAppView(_TestApp.LocalDrivingLicenseApplicationID);
            InitializeComponent();

        }
        private Image GetTestImage(int testTypeID)
        {
            switch (testTypeID)
            {
                case 1: return Properties.Resources.VisionTest;
                case 2: return Properties.Resources.WrittenTest;
                case 3: return Properties.Resources.PracticalTest;
                default: return null; // Or a default placeholder image
            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            pbHeader.Image =  GetTestImage(_TestApp.TestTypeID);

            lblAppID.Text = rowApplicationInfos["LocalDrivingLicenseApplicationID"].ToString();
            lblDrivingClass.Text = rowApplicationInfos["ClassName"].ToString();
            lblName.Text = rowApplicationInfos["FullName"].ToString();
            lblTrials.Text = clsTestAppointment.Trials(_TestApp.LocalDrivingLicenseApplicationID, clsTestType.Find(_TestApp.TestTypeID).Title).ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = _TestApp.PaidFees.ToString();
            rbFail.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to save the Result?,\nAfter That you cannot Edit Pass/Fail Result", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Test.TestResult = rbPass.Checked ;
                Test.TestAppointmentID = _TestApp.TestAppointmentID;
                Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                Test.Notes = tbxNotes.Text.Trim();

                if (Test.Save())
                {
                    _TestApp.IsLocked = true;

                    if (!_TestApp.Save())
                    {
                        MessageBox.Show("Save Test Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clsTest.Delete(Test.TestID);
                        return;
                    }
                    lblTestID.Text = Test.TestID.ToString();
                    MessageBox.Show("The Test Result is Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to save the Test Result!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
