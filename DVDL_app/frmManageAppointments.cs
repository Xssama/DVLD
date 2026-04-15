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
        int _TestTypeID = -1;
        BindingSource bsAppointmentsData = new BindingSource();
        public frmManageAppointments(int LDLAppID, int TestType)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _TestTypeID = TestType;
            InitializeComponent();

        }
        void RefreshDataInAppointmentsTable()
        {
            DataTable dt = clsTestAppointment.GetAllTestAppointments();
            bsAppointmentsData.DataSource = dt;
            lblRecords.Text = bsAppointmentsData.Count.ToString();
        }
        private void frmManageAppointments_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsAppointmentsData;
            RefreshDataInAppointmentsTable();
            poisonDataGridView1.Columns["LocalDrivingLicenseApplicationID"].Visible = false;
            poisonDataGridView1.Columns["TestTypeTitle"].Visible = false;
            poisonDataGridView1.Columns["ClassName"].Visible = false;
            poisonDataGridView1.Columns["FullName"].Visible = false;



            usBasicApplicationInfos frm = new usBasicApplicationInfos(_LDLApp.LocalDrivingLicenseApplicationID);
            frm.Dock = DockStyle.Fill;
            plShowAppInfosHandler.Controls.Add(frm);
        }
    }
}
