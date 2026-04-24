using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class FrmInternationalLicenseInfos : Form
    {
        int _InterNationalcLicenseID = -1;
        public FrmInternationalLicenseInfos(int InterNationalID)
        {
            _InterNationalcLicenseID = InterNationalID;
            InitializeComponent();
        }

        private void FrmInternationalLicenseInfos_Load(object sender, EventArgs e)
        {
            usInternationalLicenseInfos usLicenseInfos = new usInternationalLicenseInfos(_InterNationalcLicenseID);
            usLicenseInfos.Dock = DockStyle.Fill;
            plLicenseInfosContainer.Controls.Add(usLicenseInfos);
        }
    }
}
