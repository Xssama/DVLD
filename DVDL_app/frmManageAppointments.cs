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
    public partial class frmManageAppointments : Form
    {
        clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();
        string[] tbTestTypeTitle = new string[3] { "Vision Test", "Written (Theory) Test", "Practical (Street) Test" };
        string[] tbHeaderTitle = new string[3] { "Vision Test Appointment", "Written Test Appointment", "Practical Test Appointment" };
        Image[] tbHeaderPics = new Image[3] { Properties.Resources.VisionTest, Properties.Resources.WrittenTest, Properties.Resources.PracticalTest };
        int _TestTypeID = -1;
        BindingSource bsAppointmentsData = new BindingSource();
        public frmManageAppointments(int LDLAppID, int TestType)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _TestTypeID = TestType;
            InitializeComponent();
            lblHeader.Text = tbHeaderTitle[TestType - 1];
            pbHeaderPic.Image = tbHeaderPics[TestType - 1];
        }


        void RefreshDataInAppointmentsTable()
        {
            DataTable dt = clsTestAppointment.GetDVLDAppAppointments(_LDLApp.LocalDrivingLicenseApplicationID, tbTestTypeTitle[_TestTypeID - 1]);
            bsAppointmentsData.DataSource = dt;
            lblRecords.Text = bsAppointmentsData.Count.ToString();
        }
        void AddBasicInfosFormToPanel()
        {
            plShowAppInfosHandler.Controls.Clear();
            usBasicApplicationInfos usBasicInfos = new usBasicApplicationInfos(_LDLApp.LocalDrivingLicenseApplicationID);
            usBasicInfos.Dock = DockStyle.Fill;
            plShowAppInfosHandler.Controls.Add(usBasicInfos);
        }
        private void frmManageAppointments_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsAppointmentsData;
            RefreshDataInAppointmentsTable();
            poisonDataGridView1.Columns["LocalDrivingLicenseApplicationID"].Visible = false;
            poisonDataGridView1.Columns["TestTypeTitle"].Visible = false;
            poisonDataGridView1.Columns["ClassName"].Visible = false;
            poisonDataGridView1.Columns["FullName"].Visible = false;

            poisonDataGridView1.Columns["TestAppointmentID"].Width = 200;
            poisonDataGridView1.Columns["AppointmentDate"].Width = 200;
            poisonDataGridView1.Columns["PaidFees"].Width = 180;
            poisonDataGridView1.Columns["IsLocked"].Width = 180;


            AddBasicInfosFormToPanel();
        }

        private void poisonDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                poisonDataGridView1.ClearSelection();
                poisonDataGridView1.Rows[e.RowIndex].Selected = true;
                poisonDataGridView1.CurrentCell = poisonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        bool isLDLHasUnlockedTestOrAlreadyPassedTest()
        {
            if (clsTestAppointment.LDLAppHasPassedTest(_LDLApp.LocalDrivingLicenseApplicationID, tbTestTypeTitle[_TestTypeID - 1]) == true)
            {
                MessageBox.Show("Person Already Passed The Test!, You cannot add an appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (clsTestAppointment.LDLAppHasUnlockedAppointment(_LDLApp.LocalDrivingLicenseApplicationID, tbTestTypeTitle[_TestTypeID - 1]) == true)
            {
                MessageBox.Show("Person Already Has an Active Appointment for this Test!, You cannot add new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void pbAddSchedule_Click(object sender, EventArgs e)
        {
            if (!isLDLHasUnlockedTestOrAlreadyPassedTest())
            {
                frmScheduleTest frm = new frmScheduleTest(_LDLApp.LocalDrivingLicenseApplicationID, _TestTypeID);
                frm.ShowDialog();
                RefreshDataInAppointmentsTable();
                AddBasicInfosFormToPanel();
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0 )
            {
                frmTakeTest frm = new frmTakeTest((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                frm.ShowDialog();
                RefreshDataInAppointmentsTable();
                AddBasicInfosFormToPanel();
            }
        }
    }
}
