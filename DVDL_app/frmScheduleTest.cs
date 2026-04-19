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
    public partial class frmScheduleTest : Form
    {
        const int _APPLICATION_TYPE = 8;
        Image[] tbHeaderPics = new Image[3] { Properties.Resources.VisionTest, Properties.Resources.WrittenTest, Properties.Resources.PracticalTest };
        string[] tbTestTypeTitle = new string[3] { "Vision Test", "Written (Theory) Test", "Practical (Street) Test" };
        clsTestAppointment _testapp = new clsTestAppointment();
        clsApplication _application = new clsApplication();
        int _Trials;
        DataRow rowLDLAppinfos;
        clsTestType _TestType;
        public frmScheduleTest(int LDLAppID, int TestTypeID, int TestappID = -1)
        {
            _TestType = clsTestType.Find(TestTypeID);
            _testapp.TestTypeID = TestTypeID;
            if (TestappID != -1)
            {
                _testapp = clsTestAppointment.Find(TestappID);
            }
            _Trials = clsTestAppointment.Trials(LDLAppID, tbTestTypeTitle[TestTypeID - 1]);
            rowLDLAppinfos = clsLocalDrivingLicenseApplication.ReturnDataRowFromLDLAppView(LDLAppID);
            InitializeComponent();
            pbHeader.Image = tbHeaderPics[(TestTypeID >=0 && TestTypeID < 3 ? TestTypeID : 1) - 1];

        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if (_Trials > 0)
            {
                lblHeader.Text = "Schedule Retake Test ";
                gpRetakeTestInfos.Enabled = true;
            }
            else
            {
                lblHeader.Text = "Schedule Test ";
                gpRetakeTestInfos.Enabled = false;
            }
            lblTrials.Text = _Trials.ToString();
            lblAppID.Text = rowLDLAppinfos["LocalDrivingLicenseApplicationID"].ToString();
            lblDrivingClass.Text = rowLDLAppinfos["ClassName"].ToString();
            lblName.Text = rowLDLAppinfos["FullName"].ToString();
            lblFees.Text = _TestType.Fees.ToString();
            if (_Trials > 0)
            {
                float Fees = clsApplicationType.Find(_APPLICATION_TYPE).Fees;
                _application.ApplicationTypeID = _APPLICATION_TYPE;
                _application.PaidFees =Convert.ToDecimal(Fees);
                gpRetakeTestInfos.Enabled = true;
                lblRetakeFees.Text = Fees.ToString();
                lblTotalFees.Text = (_TestType.Fees + Fees).ToString();
            }
            else
            {
                gpRetakeTestInfos.Enabled = false;
                lblTotalFees.Text = _TestType.Fees.ToString();
            }
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Trials > 0 && gpRetakeTestInfos.Enabled == true)
            {
                if (_application.Mode == clsApplication.enMode.Update)
                {
                    _application.LastStatusDate = DateTime.Now;

                }
                else
                {
                    _application.ApplicationDate = DateTime.Now;
                    _application.LastStatusDate = DateTime.Now;
                    _application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    _application.ApplicationStatus = 0;
                    _application.ApplicantPersonID = clsPerson.Find(rowLDLAppinfos["NationalNo"].ToString()).PersonID;
                }
                if (_application.Save())
                {
                    lblRetakeTestAppID.Text = _application.ApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show("The Application Failed to Save", "Error");
                    return;
                }
                
            }
            _testapp.AppointmentDate = dateTimePicker1.Value;
            _testapp.IsLocked = false;
            _testapp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_testapp.TestAppointmentID == -1)
            {
                _testapp.PaidFees = _TestType.Fees + Convert.ToSingle(_application.PaidFees);
                _testapp.LocalDrivingLicenseApplicationID = int.Parse(rowLDLAppinfos["LocalDrivingLicenseApplicationID"].ToString());
            }

            if (_testapp.Save())
            {
                MessageBox.Show("The Appointment is Taken", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("The Appointment is not Taken, an error Appeared", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (_application.ApplicationID != -1)
                {
                    clsApplication.DeleteApplication(_application.ApplicationID);
                    lblRetakeTestAppID.Text = "[???]";
                }
                
            }
        }
    }
}
