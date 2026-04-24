using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
   
    public partial class usFindShowLocalDrivingLicense : UserControl
    {
        public delegate void GetLicenseIDBackEventHnadler(object sender, int LicenseID);
        public event GetLicenseIDBackEventHnadler LicenseIDBack;
        public usFindShowLocalDrivingLicense()
        {
            InitializeComponent();
        }
        private void usFindShowLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            usLicenseInfos LicenseInfos = usLicenseInfos.LoadByLocalLicenseID(-1);
            LicenseInfos.Dock = DockStyle.Fill;
            gpLicenseInfos.Controls.Add(LicenseInfos);
            
        }

        private void tbxLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (tbxLicenseID.Text.IsNullOrEmpty() || !int.TryParse(tbxLicenseID.Text, out _))
            {
                errorProvider1.SetError(tbxLicenseID, "The Input is Invalid!");
            }
            else
            {
                errorProvider1.SetError(tbxLicenseID, "");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbxLicenseID) == "" && int.TryParse(tbxLicenseID.Text, out int LicenseID))
            {
                gpLicenseInfos.Controls.Clear();
                usLicenseInfos LicenseInfos = usLicenseInfos.LoadByLocalLicenseID(LicenseID);
                LicenseInfos.Dock = DockStyle.Fill;
                gpLicenseInfos.Controls.Add(LicenseInfos);
                if (LicenseInfos.LicenseInfos != null)
                {
                    LicenseIDBack?.Invoke(this, LicenseID);

                }
                else
                {
                    LicenseIDBack?.Invoke(this, -1);
                }
            }

        }

        private void btnSearch_MouseDown(object sender, MouseEventArgs e)
        {
            btnSearch.BackColor = Color.OrangeRed;
        }

        private void btnSearch_MouseUp(object sender, MouseEventArgs e)
        {
            btnSearch.BackColor = Color.Transparent;

        }
    }
}
