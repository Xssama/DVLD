using DVDL_app.Properties;
using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class usInternationalLicenseInfos : UserControl
    {
        DataRow InterLicenseInfos;
        public usInternationalLicenseInfos(int InterLicenseID)
        {
            InterLicenseInfos = clsInternationalLicense.GetInternationalLicenseDetailed(InterLicenseID);
            InitializeComponent();
        }
        private void LoadLicenseInfosToControls()
        {
            if (InterLicenseInfos == null)
            {
                return;
            }
            lblFullName.Text = InterLicenseInfos["FullName"].ToString();
            lblInterLicenseID.Text = InterLicenseInfos["InternationalLicenseID"].ToString();
            lblLicenseID.Text = InterLicenseInfos["LicenseID"].ToString();
            lblNationalNo.Text = InterLicenseInfos["NationalNo"].ToString();
            string Gendor = InterLicenseInfos["GendorName"].ToString();
            if (Gendor == "Male")
            {
                lblGendor.Text = "Male";
                pbGendorIcon.Image = Resources.boyIcon;
            }
            else
            {
                lblGendor.Text = "Female";
                pbGendorIcon.Image = Resources.girlIcon;
            }
            lblApplicationID.Text = InterLicenseInfos["ApplicationID"].ToString();
            lblIssuedate.Text = ((DateTime)InterLicenseInfos["IssueDate"]).ToShortDateString();
            
            lblIsActive.Text = InterLicenseInfos["IsActiveText"].ToString();
            lblDateOfBirth.Text = ((DateTime)InterLicenseInfos["DateOfBirth"]).ToShortDateString();
            lblDriverID.Text = InterLicenseInfos["DriverID"].ToString();
            lblExpirationDate.Text = ((DateTime)InterLicenseInfos["ExpirationDate"]).ToShortDateString();

            if (File.Exists(InterLicenseInfos["ImagePath"].ToString()))
            {
                pbProfilePic.ImageLocation = InterLicenseInfos["ImagePath"].ToString();
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

        private void usInternationalLicenseInfos_Load(object sender, EventArgs e)
        {
            LoadLicenseInfosToControls();
        }
    }
}
