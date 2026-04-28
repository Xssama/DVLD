using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmManageDetainedLicenses : Form
    {
        BindingSource bsDetainedLicenses = new BindingSource();
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
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

        private void btnDetainLicense_MouseDown(object sender, MouseEventArgs e)
        {
            btnDetainLicense.BackColor = Color.Orange;
        }

        private void btnDetainLicense_MouseUp(object sender, MouseEventArgs e)
        {
            btnDetainLicense.BackColor = Color.Transparent;
        }

        private void btnReleaseLicense_MouseDown(object sender, MouseEventArgs e)
        {
            btnReleaseLicense.BackColor = Color.Orange;
        }

        private void btnReleaseLicense_MouseUp(object sender, MouseEventArgs e)
        {
            btnReleaseLicense.BackColor = Color.Transparent;
        }
        private void RefreshDataInTable()
        {
            DataTable dt = clsDetainedLicense.GetAllDetainedLicenses();
            bsDetainedLicenses.DataSource = dt;
            lblRecords.Text = bsDetainedLicenses.Count.ToString();
        }
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            dgvDetainedLicenses.DataSource = bsDetainedLicenses;
            RefreshDataInTable();
            cbFilters.SelectedIndex = 0;
            dgvDetainedLicenses.Columns["DetainID"].HeaderText = "Detain ID";
            dgvDetainedLicenses.Columns["LicenseID"].HeaderText = "License ID";
            dgvDetainedLicenses.Columns["FineFees"].HeaderText = "Fine Fees";


            dgvDetainedLicenses.Columns["FullName"].HeaderText = "Full Name";
            dgvDetainedLicenses.Columns["FullName"].Width = 220;


            dgvDetainedLicenses.Columns["NationalNo"].HeaderText = "National N°";
            dgvDetainedLicenses.Columns["NationalNo"].Width = 120;


            dgvDetainedLicenses.Columns["ReleaseDate"].HeaderText = "Release Date";
            dgvDetainedLicenses.Columns["ReleaseDate"].Width = 170;

            dgvDetainedLicenses.Columns["DetainDate"].HeaderText = "Detain Date";
            dgvDetainedLicenses.Columns["DetainDate"].Width = 170;

            dgvDetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "R.AppID";
            dgvDetainedLicenses.Columns["ReleaseApplicationID"].Width = 120;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
            RefreshDataInTable();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicense = new frmReleaseDetainedLicense();
            ReleaseDetainedLicense.ShowDialog();
            RefreshDataInTable();
        }

        private void dgvDetainedLicenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDetainedLicenses.ClearSelection();
                dgvDetainedLicenses.Rows[e.RowIndex].Selected = true;
                dgvDetainedLicenses.CurrentCell = dgvDetainedLicenses.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell != null && dgvDetainedLicenses.CurrentCell.RowIndex >= 0)
            {
                frmPersonInformations PersonInfos = new frmPersonInformations(clsPerson.Find((string)dgvDetainedLicenses.Rows[dgvDetainedLicenses.CurrentCell.RowIndex].Cells[6].Value).PersonID);
                PersonInfos.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell != null && dgvDetainedLicenses.CurrentCell.RowIndex >= 0)
            {
                frmShowLicenseInfos LicenseInfos = frmShowLicenseInfos.LoadFormByLicenseID((int)dgvDetainedLicenses.Rows[dgvDetainedLicenses.CurrentCell.RowIndex].Cells[1].Value);
                LicenseInfos.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell != null && dgvDetainedLicenses.CurrentCell.RowIndex >= 0)
            {
                frmPersonLicenseHistory PersonLicensesHistory = new frmPersonLicenseHistory((string)dgvDetainedLicenses.Rows[dgvDetainedLicenses.CurrentCell.RowIndex].Cells[6].Value);
                PersonLicensesHistory.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell != null && dgvDetainedLicenses.CurrentCell.RowIndex >= 0)
            {
                if ((bool)dgvDetainedLicenses.Rows[dgvDetainedLicenses.CurrentCell.RowIndex].Cells[3].Value == false)
                {
                    releaseLicenseToolStripMenuItem.Enabled = true;
                }
                else
                {
                    releaseLicenseToolStripMenuItem.Enabled = false;
                }
            }
        }


        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell != null && dgvDetainedLicenses.CurrentCell.RowIndex >= 0)
            {
                int LicenseID =(int)dgvDetainedLicenses.Rows[dgvDetainedLicenses.CurrentCell.RowIndex].Cells[1].Value;
                frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense(LicenseID);
                ReleaseLicense.ShowDialog();
                RefreshDataInTable();
            }


        }
    }
}
