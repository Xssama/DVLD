using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;

namespace DVDL_app
{
    public partial class FrmUsersList : Form
    {
        private BindingSource bsUsers = new BindingSource();
        public FrmUsersList()
        {
            InitializeComponent();
        }

        private void RefreshDataInTable()
        {
            DataTable dtusers = clsUser.GetList();
            bsUsers.DataSource = dtusers;
        }
        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsUsers;
            RefreshDataInTable();
            poisonDataGridView1.Columns["Password"].Visible = false;
            lblRecords.Text = poisonDataGridView1.RowCount.ToString();

            cbFilters.SelectedIndex = 0;
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 0)
            {
                tbxFilter.Visible = false;
                tbxFilter.Text = null;
            }
            else
            {
                tbxFilter.Visible = true;
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilters.Text;
            string FilterByText = tbxFilter.Text;

            if (!FilterByText.IsNullOrEmpty() && cbFilters.Text != "None")
            {
                if (FilterColumn == "UserID" || FilterColumn == "PersonID")
                {
                    bsUsers.Filter = string.Format("{0} = {1}", FilterColumn, int.Parse(FilterByText));
                }
                else
                {
                    bsUsers.Filter = string.Format("{0}  like '%{1}%'", FilterColumn, FilterByText);
                }
                
            }
            else
            {
                bsUsers.RemoveFilter();
            }
        }
    }
}
