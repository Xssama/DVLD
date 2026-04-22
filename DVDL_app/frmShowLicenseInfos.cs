using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmShowLicenseInfos : Form
    {
        
        private frmShowLicenseInfos()
        {
            InitializeComponent();
        }
        static public frmShowLicenseInfos LoadFormByLDLAppID(int LDLAppID)
        {
            var ctrl = new frmShowLicenseInfos();
            var LicenseInfos =  usLicenseInfos.LoadByLocalDrivingLicenseAppID(LDLAppID);
            LicenseInfos.Dock = DockStyle.Fill;
            ctrl.plDriverInfosContainer.Controls.Add(LicenseInfos);
            return ctrl;
        }

        static public frmShowLicenseInfos LoadFormByLicenseID(int LicenseID)
        {
            var ctrl = new frmShowLicenseInfos();
            var LicenseInfos = usLicenseInfos.LoadByLocalLicenseID(LicenseID);
            LicenseInfos.Dock = DockStyle.Fill;
            ctrl.plDriverInfosContainer.Controls.Add(LicenseInfos);
            return ctrl;
        }
        private void frmShowLicenseInfos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
