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
        clsUser _User = new clsUser();
        public frmManageLocalDrivingLicenseApplications(clsUser user)
        {
            _User = user;
            InitializeComponent();
        }
        public void RefreshDataInTable()
        {
            DataTable dt = clsLocalDrivingLicenseApplication.GetList(true);
            bsApplications.DataSource = dt;
            lblRecords.Text = bsApplications.Count.ToString();
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
            frmAddLocalDrivingLicenseApp frm = new frmAddLocalDrivingLicenseApp(_User);
            frm.ShowDialog();
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
    }
}
