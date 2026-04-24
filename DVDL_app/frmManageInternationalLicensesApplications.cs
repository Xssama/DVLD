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
    public partial class frmManageInternationalLicensesApplications : Form
    {
        BindingSource bsApplications = new BindingSource();
        public frmManageInternationalLicensesApplications()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            bsApplications.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            poisonDataGridView1.DataSource = bsApplications;

            poisonDataGridView1.Columns["CreatedByUserID"].Visible = false;

            poisonDataGridView1.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
            poisonDataGridView1.Columns["InternationalLicenseID"].Width = 150;


            poisonDataGridView1.Columns["ApplicationID"].HeaderText = "Application ID";
            poisonDataGridView1.Columns["ApplicationID"].Width = 150;

            poisonDataGridView1.Columns["DriverID"].HeaderText = "Driver ID";
            poisonDataGridView1.Columns["DriverID"].Width = 150;

            poisonDataGridView1.Columns["ApplicationID"].HeaderText = "Application ID";
            poisonDataGridView1.Columns["ApplicationID"].Width = 150;

            poisonDataGridView1.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
            poisonDataGridView1.Columns["IssuedUsingLocalLicenseID"].Width = 150;


            poisonDataGridView1.Columns["IssueDate"].HeaderText = "Issue Date";
            poisonDataGridView1.Columns["IssueDate"].Width = 190;

            poisonDataGridView1.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            poisonDataGridView1.Columns["ExpirationDate"].Width = 190;

            poisonDataGridView1.Columns["IsActive"].HeaderText = "Is Active";
            poisonDataGridView1.Columns["IsActive"].Width = 120;

            lblRecords.Text = poisonDataGridView1.Rows.Count.ToString();
        }

        private void RefreshDataInTable()
        {
            bsApplications.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            poisonDataGridView1.DataSource = bsApplications;
            lblRecords.Text = poisonDataGridView1.Rows.Count.ToString();

        }

        private void frmManageInternationalLicensesApplications_Load(object sender, EventArgs e)
        {
            LoadTable();
            cbFilters.SelectedIndex = 0;
        }


        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                tbxFilter.Visible = false;
            }
            else
            {
                tbxFilter.Visible = true;
            }
        }

        private void pbIssueNewInterLiense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicenseApp frm = new frmIssueInternationalLicenseApp();
            frm.ShowDialog();
            RefreshDataInTable();
        }

        private void pbIssueNewInterLiense_MouseDown(object sender, MouseEventArgs e)
        {
            pbIssueNewInterLiense.BackColor = Color.Orange;
        }

        private void pbIssueNewInterLiense_MouseUp(object sender, MouseEventArgs e)
        {
            pbIssueNewInterLiense.BackColor = Color.Transparent;

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

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                FrmInternationalLicenseInfos LicenseInfos = new FrmInternationalLicenseInfos((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                LicenseInfos.ShowDialog();
            }
        }

        private void showPersonInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                clsDriver driver = clsDriver.Find((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                frmPersonInformations PersonInfos = new frmPersonInformations(driver.PersonID);
                PersonInfos.ShowDialog();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                clsDriver driver = clsDriver.Find((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                frmPersonLicenseHistory PersonLicensesHistory = new frmPersonLicenseHistory(driver.PersonID);
                PersonLicensesHistory.ShowDialog();
            }
        }
    }
}
