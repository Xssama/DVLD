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
    public partial class usAdd_Edit_PersonInfos : UserControl
    {
        clsPerson _Person;
        public usAdd_Edit_PersonInfos(clsPerson person)
        {
            _Person = person;
            InitializeComponent();
        }



        private void btnSetImage_Click(object sender, EventArgs e)
        {
            ofdPersonPic.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            if (ofdPersonPic.ShowDialog() == DialogResult.OK)
            {
                string PicLocation = ofdPersonPic.FileName;
                pbPersonImage.ImageLocation = PicLocation;

            }
        }

        private void LoadPersonInfosToControls()
        {
            tbFirstName.Text = _Person.FirstName;
            tbLastName.Text = _Person.LastName;
            tbxThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNo;
            tbAddress.Text = _Person.Address;
            tbEmail.Text = _Person.Email;
            tbPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.Text = (clsCountry.Find(_Person.NationalCountryID).CountryName);

            if (_Person.Gendor == 0)
            {
                cbMale.Checked = true;
                cbFemale.Checked = false;
            }
            else if (_Person.Gendor == 1)
            {
                cbMale.Checked = false;
                cbFemale.Checked = true;
            }
            {

            }

        }

        private void usAdd_Edit_PersonInfos_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            DataTable dt = clsCountry.GetList() ;
            foreach(DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

            if (_Person.Status == clsPerson.enPersonStatus.Update)
            {
                LoadPersonInfosToControls();
            }
            else
            {
                cbMale.Checked = true;
                cbCountry.SelectedIndex = 89;
            }
        }
    }
}
