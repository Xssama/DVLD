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
    public partial class usPersonInformations : UserControl
    {
        clsPerson _person;
        public usPersonInformations(int PersonID)
        {
            _person = clsPerson.Find(PersonID);
            InitializeComponent();
        }

        private void LoadPersoninfosToControl()
        {
            string FullName = "";
            lblPersonid.Text = _person.PersonID.ToString();
            FullName += _person.FirstName + " ";
            FullName += _person.SecondName + " ";
            if (!string.IsNullOrEmpty(_person.ThirdName))
            {
                FullName += _person.ThirdName + " ";

            }
            FullName += _person.LastName;
            lblFullName.Text = FullName;
            lblNationalNo.Text = _person.NationalNo;
            if (!string.IsNullOrEmpty(_person.Email))
            {
                lblEmail.Text = _person.Email;
            }
            else
            {
                lblEmail.Text = "Not Set";
            }
            lblAddress.Text = _person.Address;
            lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();
            lblPhone.Text = _person.Phone;
            lblCountry.Text = (clsCountry.Find(_person.NationalCountryID).CountryName);
            if (File.Exists(_person.ImagePath))
            {
                pbProfilePic.ImageLocation = _person.ImagePath;

            }
            else
            {
                if (_person.Gendor == 0)
                {
                    pbProfilePic.Image = Properties.Resources.DefaultMalePic;
                }
                else
                {
                    pbProfilePic.Image = Properties.Resources.DefaultFemalePic;

                }
            }
            if (_person.Gendor == 0)
            {
                pbGendorIcon.Image = Properties.Resources.boyIcon;
                lblGendor.Text = "Male";
            }
            else
            {
                pbGendorIcon.Image = Properties.Resources.girlIcon;
                lblGendor.Text = "Female";

            }
        }

        private void usPersonInformations_Load(object sender, EventArgs e)
        {
            LoadPersoninfosToControl();
        }

        private void llEditPersonInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_person.PersonID);
            frm.ShowDialog();
            _person = clsPerson.Find(_person.PersonID);
            LoadPersoninfosToControl();
        }
    }
}
