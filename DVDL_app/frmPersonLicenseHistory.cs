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

            dgvInternationalLicensesHistory.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
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

        private void dgvInternationalLicensesHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternationalLicensesHistory.ClearSelection();
                dgvInternationalLicensesHistory.Rows[e.RowIndex].Selected = true;
                dgvInternationalLicensesHistory.CurrentCell = dgvInternationalLicensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void dgvLocalLicensesHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvLocalLicensesHistory.ClearSelection();
                dgvLocalLicensesHistory.Rows[e.RowIndex].Selected = true;
                dgvLocalLicensesHistory.CurrentCell = dgvLocalLicensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicensesHistory.CurrentCell != null && dgvInternationalLicensesHistory.CurrentCell.RowIndex >= 0)
            {
                FrmInternationalLicenseInfos interLicenseInfos = new FrmInternationalLicenseInfos((int)dgvInternationalLicensesHistory.Rows[dgvInternationalLicensesHistory.CurrentCell.RowIndex].Cells[0].Value);
                interLicenseInfos.ShowDialog();
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicensesHistory.CurrentCell != null && dgvLocalLicensesHistory.CurrentCell.RowIndex >= 0)
            {
                frmShowLicenseInfos LocalLicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID((int)dgvLocalLicensesHistory.Rows[dgvLocalLicensesHistory.CurrentCell.RowIndex].Cells[0].Value);
                LocalLicenseInfos.ShowDialog();
            }
        }
    }
}
