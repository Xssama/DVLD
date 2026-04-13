using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmVisionTest : Form
    {
        public frmVisionTest()
        {
            InitializeComponent();
        }

       

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            usBasicApplicationInfos us = new usBasicApplicationInfos(32);
            us.Dock = DockStyle.Fill;
            plAppInfos.Controls.Add(us);
        }
    }
}
