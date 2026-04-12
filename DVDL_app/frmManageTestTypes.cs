using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BUSINESS;
namespace DVDL_app
{

    public partial class frmManageTestTypes : Form
    {
        BindingSource bsTestTypes = new BindingSource();
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void refreshdataintable()
        {
            DataTable dt = clsTestType.GetList();
            bsTestTypes.DataSource = dt;
            lblRecords.Text = bsTestTypes.Count.ToString();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            refreshdataintable();
            poisonDataGridView1.DataSource = bsTestTypes;
            poisonDataGridView1.Columns["TestTypeID"].Width = 90;
            poisonDataGridView1.Columns["TestTypeID"].HeaderText = "ID";

            poisonDataGridView1.Columns["TestTypeFees"].Width = 150;
            poisonDataGridView1.Columns["TestTypeFees"].HeaderText = "Fees";

            poisonDataGridView1.Columns["TestTypeTitle"].Width = 200;
            poisonDataGridView1.Columns["TestTypeTitle"].HeaderText = "Title";

            poisonDataGridView1.Columns["TestTypeDescription"].HeaderText = "Description";
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

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poisonDataGridView1.CurrentCell != null)
            {
                frmEditTestType edittesttype = new frmEditTestType((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                edittesttype.ShowDialog();
                refreshdataintable();
            }
        }
    }
}
