using DVDL_app.Properties;
using DVLD_BUSINESS;
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
    public partial class usLicenseInfos : UserControl
    {
        public DataRow LicenseInfos;
        private usLicenseInfos()
        {
            InitializeComponent();
        }
        static public usLicenseInfos LoadByLocalLicenseID(int LicenseID)
        {
            var ctrl = new usLicenseInfos();
            ctrl.LicenseInfos = clsLocalDrivingLicenseApplication.GetLicenseInfosByLicenseID(LicenseID);
            return ctrl;
        }
        static public usLicenseInfos LoadByLocalDrivingLicenseAppID(int LDLAppID)
        {
            var ctrl = new usLicenseInfos();
            ctrl.LicenseInfos = clsLocalDrivingLicenseApplication.GetLicenseInfosByLDLAppID(LDLAppID);
            return ctrl;
        }
        private void usLicenseInfos_Load(object sender, EventArgs e)
        {
            if (LicenseInfos == null)
            {
                return;
            }
            lblClass.Text = LicenseInfos["ClassName"].ToString();
            lblFullName.Text = LicenseInfos["FullName"].ToString();
            lblLicenseID.Text = LicenseInfos["LicenseID"].ToString();
            lblNationalNo.Text = LicenseInfos["NationalNo"].ToString();
            string Gendor = LicenseInfos["GendorName"].ToString();
            if (Gendor == "Male")
            {
                lblGendor.Text = "Male";
                pbGendorIcon.Image = Resources.boyIcon;
            }
            else
            {
                lblGendor.Text = "female";
                pbGendorIcon.Image = Resources.girlIcon;
            }

            lblIssuedate.Text = ((DateTime)LicenseInfos["IssueDate"]).ToShortDateString();
            lblIssueReason.Text = LicenseInfos["IssueReasonDes"].ToString();
            if (!LicenseInfos["Notes"].ToString().IsNullOrEmpty())
            {
                lblNotes.Text = LicenseInfos["Notes"].ToString();
            }
            else
            {
                lblNotes.Text = "No Notes";
            }
            lblIsActive.Text = LicenseInfos["IsActiveText"].ToString();
            lblDateOfBirth.Text = ((DateTime)LicenseInfos["DateOfBirth"]).ToShortDateString();
            lblDriverID.Text = LicenseInfos["DriverID"].ToString();
            lblExpirationDate.Text = ((DateTime)LicenseInfos["ExpirationDate"]).ToShortDateString();
            lblIsDetained.Text = LicenseInfos["IsDetained"].ToString();

            if (File.Exists(LicenseInfos["ImagePath"].ToString()))
            {
                pbProfilePic.ImageLocation = LicenseInfos["ImagePath"].ToString();
            }
            else
            {
                if (Gendor == "Male")
                {
                    pbProfilePic.Image = Resources.DefaultMalePic;
                }
                else
                {
                    pbProfilePic.Image = Resources.DefaultFemalePic;
                }
            }

        }
    }
}
