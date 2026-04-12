using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{

    public partial class frmManageAppTypes : Form
    {
        BindingSource bsAppTypes = new BindingSource();
        public frmManageAppTypes()
        {
            InitializeComponent();
            poisonDataGridView1.ContextMenuStrip = contextMenuStrip1;
        }
        public void refreshdataintable()
        {
            DataTable dt = clsApplicationTypes.GetList();
            bsAppTypes.DataSource = dt;
        }
        private void frmManageAppTypes_Load(object sender, EventArgs e)
        {
            DataTable dt = clsApplicationTypes.GetList();
            bsAppTypes.DataSource = dt;
            poisonDataGridView1.DataSource = bsAppTypes;
            poisonDataGridView1.Columns[0].Width = 110;
            poisonDataGridView1.Columns[0].HeaderText = "ID";
            poisonDataGridView1.RowHeadersVisible = false;
            lblRecords.Text = bsAppTypes.Count.ToString();
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
            if (poisonDataGridView1.CurrentCell != null && poisonDataGridView1.CurrentCell.RowIndex >= 0)
            {
                frmEditAppType editapptype = new frmEditAppType((int)poisonDataGridView1.Rows[poisonDataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                editapptype.ShowDialog();
                refreshdataintable();
            }
            else
            {
                MessageBox.Show("Please select a row first!");
            }
        }
    }
}
