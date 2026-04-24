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
    public partial class frmPersonLicenseHistory : Form
    {
        clsPerson _person = new clsPerson();
        BindingSource bsLocalLicenses = new BindingSource();
        BindingSource bsInterNationalLicenses = new BindingSource();
        public frmPersonLicenseHistory(int PersonID)
        {
            _person = clsPerson.Find(PersonID);
            InitializeComponent();
        }
        public frmPersonLicenseHistory(string NationalNo)
        {
            _person = clsPerson.Find(NationalNo);
            InitializeComponent();
        }
        private void LoadDataToLocalLicensesTable()
        {
            bsLocalLicenses.DataSource = clsLicense.GetAllPersonLicenses(_person.PersonID);
            dgvLocalLicensesHistory.DataSource = bsLocalLicenses;

            dgvLocalLicensesHistory.Columns["LicenseID"].Width = 150;
            dgvLocalLicensesHistory.Columns["ApplicationID"].Width = 150;
            dgvLocalLicensesHistory.Columns["ClassName"].Width = 300;
            dgvLocalLicensesHistory.Columns["IssueDate"].Width = 150;
            dgvLocalLicensesHistory.Columns["ExpirationDate"].Width = 150;
            dgvLocalLicensesHistory.Columns["IsActive"].Width = 150;

            lblRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

        }

        private void LoadDataToInternationalLicensesTable()
        {
            bsInterNationalLicenses.DataSource = clsInternationalLicense.GetAllPersonInternationalLicenses(_person.PersonID);
            dgvInternationalLicensesHistory.DataSource = bsInterNationalLicenses;

            dgvInternationalLicensesHistory.Columns["InternationalLicenseID"].Width = 170;
            dgvInternationalLicensesHistory.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";

            dgvInternationalLicensesHistory.Columns["ApplicationID"].Width = 150;

            dgvInternationalLicensesHistory.Columns["IssuedUsingLocalLicenseID"].HeaderText= "L.License ID";
            dgvInternationalLicensesHistory.Columns["IssuedUsingLocalLicenseID"].Width = 170;

            dgvInternationalLicensesHistory.Columns["IssueDate"].Width = 200;

            dgvInternationalLicensesHistory.Columns["ExpirationDate"].Width = 200;

            dgvInternationalLicensesHistory.Columns["IsActive"].Width = 170;

            lblIntRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();
        }
        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            usPersonInformations personInfos = new usPersonInformations(_person.PersonID);
            personInfos.Dock = DockStyle.Fill;
            plFindPerson.Controls.Add(personInfos);

            LoadDataToLocalLicensesTable();
            LoadDataToInternationalLicensesTable();

        }
    }
}
