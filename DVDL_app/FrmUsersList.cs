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
            DataTable dtusers = clsUser.GetList(true);
            bsUsers.DataSource = dtusers;
        }
        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = bsUsers;
            RefreshDataInTable();
            lblRecords.Text = poisonDataGridView1.RowCount.ToString();

            cbFilters.SelectedIndex = 0;

            poisonDataGridView1.ContextMenuStrip = contextMenuStrip1;
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

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentRow != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                int SelectedUserId = (int)poisonDataGridView1.CurrentRow.Cells[0].Value;
                frmUserInfos userifos = new frmUserInfos(SelectedUserId);
                userifos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a row first!.");
            }
        }

        private void poisonDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                poisonDataGridView1.ClearSelection();
                poisonDataGridView1.Rows[e.RowIndex].Selected = true;
                poisonDataGridView1.CurrentCell = poisonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void pbAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser addnewuser = new frmAddNewUser();
            addnewuser.ShowDialog();
            RefreshDataInTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUser addnewuser = new frmAddNewUser();
            addnewuser.ShowDialog();
            RefreshDataInTable();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                int SelectedUserID = (int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Are you sure you want to delete the user => " +
                (string)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[3].Value,
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsUser.DeleteUser(SelectedUserID))
                    {
                        MessageBox.Show("The user is deleted successfuly.");
                        RefreshDataInTable();
                    }
                    else
                    {
                        MessageBox.Show("The user is Linked to other data,it can't be deleted.");

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!.");
            }
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null || poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmAddNewUser edituser = new frmAddNewUser((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value, true);
                edituser.StartPosition = FormStartPosition.CenterScreen;
                edituser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a row first!.");

            }
            RefreshDataInTable();
        }

        private void pbAddNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            pbAddNewUser.BackColor = Color.AliceBlue;
        }

        private void pbAddNewUser_MouseUp(object sender, MouseEventArgs e)
        {
            pbAddNewUser.BackColor = Color.Transparent;

        }
    }
}
