using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmManageDrivers : Form
    {
        BindingSource bsDirvers = new BindingSource();
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        void RefreshDataInDriversTable()
        {
            DataTable dt = clsDriver.GetAllDrivers();
            bsDirvers.DataSource = dt;
            lblRecords.Text = bsDirvers.Count.ToString();

        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsDirvers;
            RefreshDataInDriversTable();

            poisonDataGridView1.Columns["FullName"].HeaderText = "Full Name";
            poisonDataGridView1.Columns["FullName"].Width = 300;

            poisonDataGridView1.Columns["Date"].Width = 170;
            poisonDataGridView1.Columns["DriverID"].Width = 110;
            poisonDataGridView1.Columns["PersonID"].Width = 110;

            cbFilters.SelectedIndex = 0;
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

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                tbxFilter.Text = "";
                tbxFilter.Visible = false;
            }
            else
            {
                tbxFilter.Visible = true;
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbxFilter.Text.IsNullOrEmpty())
            {
                bsDirvers.RemoveFilter();
                return;
            }
            if (cbFilters.Text == "PersonID" || cbFilters.Text == "DriverID")
            {
                if (int.TryParse(tbxFilter.Text, out _))
                {
                    string Filter = string.Format("{0} = {1}", tbxFilter.Text.Trim(), cbFilters.Text);
                    bsDirvers.Filter = Filter;

                }
              
            }
            else
            {

                string Filter = string.Format("{0} like '%{1}%'", cbFilters.Text, tbxFilter.Text.Trim());
                bsDirvers.Filter = Filter;
            }
            lblRecords.Text = bsDirvers.Count.ToString();
        }
    }
}
