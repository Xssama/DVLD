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
        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            usPersonInformations personInfos = new usPersonInformations(_person.PersonID);
            personInfos.Dock = DockStyle.Fill;
            plFindPerson.Controls.Add(personInfos);

            bsLocalLicenses.DataSource = clsLicense.GetAllPersonLicenses(_person.PersonID);
            dgvLocalLicensesHistory.DataSource = bsLocalLicenses;

            dgvLocalLicensesHistory.Columns["LicenseID"].Width = 150;
            dgvLocalLicensesHistory.Columns["ApplicationID"].Width = 150;
            dgvLocalLicensesHistory.Columns["ClassName"].Width = 300;
            dgvLocalLicensesHistory.Columns["IssueDate"].Width = 150;
            dgvLocalLicensesHistory.Columns["ExpirationDate"].Width = 150;
            dgvLocalLicensesHistory.Columns["IsActive"].Width = 150;

        }
    }
}
