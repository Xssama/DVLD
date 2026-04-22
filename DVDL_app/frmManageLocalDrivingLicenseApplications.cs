using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        BindingSource bsApplications = new BindingSource();
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        void RefreshDataInTable()
        {
            DataTable dt = clsLocalDrivingLicenseApplication.GetList(true);
            bsApplications.DataSource = dt;
            lblRecords.Text = bsApplications.Count.ToString();
        }

        void RefeshAvailableTestToSechdule()
        {
            int PassedTests = clsLocalDrivingLicenseApplication.PassedTests((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            if (PassedTests == 3 || (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value != "New")
            {
                sechudleToolStripMenuItem.Enabled = false;
                return;
            }
            else
            {
                sechudleToolStripMenuItem.Enabled = true;

            }
            visionTestToolStripMenuItem.Enabled = false;
            writtenTestToolStripMenuItem.Enabled = false;
            practiceTestToolStripMenuItem.Enabled = false;

            switch (PassedTests)
            {
                case 0:
                    visionTestToolStripMenuItem.Enabled = true;
                    break;
                case 1:
                    writtenTestToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    practiceTestToolStripMenuItem.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsApplications;
            RefreshDataInTable();
            poisonDataGridView1.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L AppID";
            poisonDataGridView1.Columns["LocalDrivingLicenseApplicationID"].Width = 140;

            poisonDataGridView1.Columns["Status"].Width = 110;

            poisonDataGridView1.Columns["NationalNo"].HeaderText = "National N°";
            poisonDataGridView1.Columns["NationalNo"].Width = 160;

            poisonDataGridView1.Columns["ClassName"].HeaderText = "Class Name";
            poisonDataGridView1.Columns["ClassName"].Width = 220;

            poisonDataGridView1.Columns["FullName"].HeaderText = "Full Name";
            poisonDataGridView1.Columns["FullName"].Width = 220;

            poisonDataGridView1.Columns["ApplicationDate"].HeaderText = "Application Date";
            poisonDataGridView1.Columns["ApplicationDate"].Width = 200;

            poisonDataGridView1.Columns["PassedTestCount"].HeaderText = "Tests Passed";
            poisonDataGridView1.Columns["PassedTestCount"].Width = 120;

            cbFilters.SelectedItem = cbFilters.Items[0];

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                tbxFilter.Visible = false;
                tbxFilter.Text = "";
                bsApplications.RemoveFilter();
            }
            else
            {
                tbxFilter.Visible = true;
                tbxFilter.Focus();
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 1)
            {
                bsApplications.Filter = string.Format("{0} = {1}", "LocalDrivingLicenseApplicationID", Convert.ToInt32(tbxFilter.Text));
            }
            else if (cbFilters.SelectedIndex != 0)
            {
                if (tbxFilter.Text.IsNullOrEmpty())
                {
                    bsApplications.RemoveFilter();
                }
                else
                {
                    bsApplications.Filter = string.Format("{0} like '%{1}%'", (cbFilters.SelectedIndex == 2 ? "FullName" : "Status"), tbxFilter.Text.Trim());
                }
            }
            lblRecords.Text = bsApplications.Count.ToString();

        }

        private void pbAddNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            pbAddNewUser.BackColor = Color.Orange;
        }

        private void pbAddNewUser_MouseUp(object sender, MouseEventArgs e)
        {
            pbAddNewUser.BackColor = Color.Transparent;

        }

        private void pbAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddLocalDrivingLicenseApp frm = new frmAddLocalDrivingLicenseApp();
            frm.ShowDialog();
            RefreshDataInTable();
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

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmManageAppointments appointment = new frmManageAppointments((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value, 1);
                appointment.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            RefeshAvailableTestToSechdule();
            if (clsLocalDrivingLicenseApplication.PassedTests((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value) == 3 &&
                (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value != "Completed")
            {
                issueLicenseFirstNameToolStripMenuItem.Enabled = true;
            }
            else
            {
                issueLicenseFirstNameToolStripMenuItem.Enabled = false;
            }

            if (clsDriver.isPerson_A_Driver((string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[2].Value))
            {
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            }
            else
            {
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            }

            if ((string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value == "Completed")
            {
                showLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                showLicenseToolStripMenuItem.Enabled = false;
            }

            if ((string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value == "New"
                || (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value == "Cancelled")
            {
                deleteApplicationToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteApplicationToolStripMenuItem.Enabled = false;

            }

            if ((string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value == "New")
            {
                cancellApplicationToolStripMenuItem.Enabled = true;
            }
            else
            {
                cancellApplicationToolStripMenuItem.Enabled = false;

            }
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmManageAppointments appointment = new frmManageAppointments((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value, 2);
                appointment.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void practiceTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmManageAppointments appointment = new frmManageAppointments((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value, 3);
                appointment.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void issueLicenseFirstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmIssueDriverLicense DrivingLicense = new frmIssueDriverLicense((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                DrivingLicense.ShowDialog();
                RefreshDataInTable();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmPersonLicenseHistory licensesHistory = new frmPersonLicenseHistory((string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                licensesHistory.Show();
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                string Status = (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value;
                int PassedTests = (int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[5].Value;

                if (Status == "New" && PassedTests == 0)
                {
                    int LDLAppID = (int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                    clsLocalDrivingLicenseApplication LDL = clsLocalDrivingLicenseApplication.Find(LDLAppID);
                    int AppID = LDL.ApplicationID;
                    if (clsLocalDrivingLicenseApplication.DeleteApplication(LDL.LocalDrivingLicenseApplicationID))
                    {
                        if (clsApplication.DeleteApplication(AppID))
                        {
                            MessageBox.Show("The application is deleted Successfully", "Completed", MessageBoxButtons.OK);
                            RefreshDataInTable();
                            return;
                        }
                    }
                }

                MessageBox.Show("  This application can't be deleted, It's linked to data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cancellApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0
                && (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[6].Value == "New")
            {
                clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                clsApplication App = clsApplication.Find(LDLApp.ApplicationID);
                App.ApplicationStatus = 2;
                App.LastStatusDate = DateTime.Now;
                if (!App.Save())
                {
                    MessageBox.Show("Application Failed to cancel!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RefreshDataInTable();
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmShowLicenseInfos frm = frmShowLicenseInfos.LoadFormByLDLAppID((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                frm.ShowDialog();
            }
        }
    }
}
