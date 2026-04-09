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

    public partial class frmManageAppTypes : Form
    {
        BindingSource bsAppTypes = new BindingSource();
        public frmManageAppTypes()
        {
            InitializeComponent();
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
            poisonDataGridView1.Columns[0].HeaderText= "ID";
            poisonDataGridView1.RowHeadersVisible = false;
            lblRecords.Text = bsAppTypes.Count.ToString();
        }
    }
}
