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
        clsUser _user = new clsUser();
        public frmAddLocalDrivingLicenseApp(clsUser user)
        {
            _user = user;
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

            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = _user.UserName;
        }

        private void cbLicenseClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFees.Text = clsDrivingLicenseClasse.Find(cbLicenseClasse.SelectedIndex + 1).ClassFees.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpAppInfos;
        }
    }
}
