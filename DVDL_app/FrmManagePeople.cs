using DVLD_BUSINESS;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class FrmManagePeople : Form
    {
        public FrmManagePeople()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshPeopleList()
        {
            bsPeopleList.DataSource = clsPerson.GetListForShow();
            lblRecordsCount.Text = bsPeopleList.Count.ToString();
        }
        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeopleList.AutoGenerateColumns = true;
            dgvPeopleList.DataSource = bsPeopleList;

            RefreshPeopleList();

            foreach (DataGridViewColumn Column in dgvPeopleList.Columns)
            {
                cbFilters.Items.Add(Column.HeaderText);
            }
            cbFilters.SelectedIndex = 0;

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilters.Text != "None")
            {
                
                tbFilterBy.Visible = true;
            }
            else
            {
                tbFilterBy.Visible = false;

            }
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilters.Text;
            string FilterBy = tbFilterBy.Text.Replace("'", "''");
            if (string.IsNullOrEmpty(FilterBy) || FilterColumn == "None")
            {
                bsPeopleList.RemoveFilter();
            }
            else
            {
                if (FilterColumn == "PersonID" && int.TryParse(FilterBy, out _))
                {
                    bsPeopleList.Filter = string.Format("{0} = {1}", FilterColumn, FilterBy);

                }
                else
                {
                    bsPeopleList.Filter = string.Format("{0} like '{1}%'", FilterColumn, FilterBy);

                }
            }
            lblRecordsCount.Text = bsPeopleList.Count.ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            RefreshPeopleList();
        }
    }
}
