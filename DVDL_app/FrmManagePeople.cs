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

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentCell != null)
            {
                int PersonSelectedID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
                frmPersonInformations frmPersonInfosShow = new frmPersonInformations(PersonSelectedID);
                frmPersonInfosShow.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
            RefreshPeopleList();
        }

        private void dgvPeopleList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvPeopleList.ClearSelection();
                dgvPeopleList.Rows[e.RowIndex].Selected = true;
                dgvPeopleList.CurrentCell = dgvPeopleList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();


            RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentCell == null)
            {
                int PersonSelectedID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
                frmPersonInformations frmPersonInfosShow = new frmPersonInformations(PersonSelectedID);
                frmPersonInfosShow.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
            RefreshPeopleList();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentCell != null)
            {
                int PersonSelectedID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
                if (MessageBox.Show($"Are you sure you want to delete the person with id : {PersonSelectedID}", "Delete Person", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {

                    if (clsPerson.DeletePerson(PersonSelectedID))
                    {
                        MessageBox.Show("The Person is deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("The Person isn't deleted!.");

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
            RefreshPeopleList();
        }
    }
}
