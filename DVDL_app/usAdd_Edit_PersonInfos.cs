using DVLD_BUSINESS;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DVDL_app
{
    
    public partial class usAdd_Edit_PersonInfos : UserControl
    {
        public delegate void SendPersonIDBack(object sender, int PersonID);
        public event SendPersonIDBack sendpersonidback;
        clsPerson _Person;
        private readonly string _PhotosStoragePath = @"C:\DVLD-People-Images\";
        private string _CuurentImagePath = string.Empty;
        public usAdd_Edit_PersonInfos(clsPerson person)
        {
            _Person = person;
            InitializeComponent();
        }



        private void btnSetImage_Click(object sender, EventArgs e)
        {
            ofdPersonPic.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPersonPic.Title = "Select Profile Image";

            if (ofdPersonPic.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!Directory.Exists(_PhotosStoragePath))
                    {
                        Directory.CreateDirectory(_PhotosStoragePath);
                    }

                    string SourceFilePath = ofdPersonPic.FileName;
                    string SourceFileExtension = Path.GetExtension(SourceFilePath);

                    string UniqueFileName = Guid.NewGuid().ToString() + SourceFileExtension;
                    string DestinationFilePath = Path.Combine(_PhotosStoragePath, UniqueFileName);

                    File.Copy(SourceFilePath, DestinationFilePath);
                    pbPersonImage.ImageLocation = DestinationFilePath;
                    pbPersonImage.Tag = "Costum";
                    _CuurentImagePath = DestinationFilePath;
                    btnRemove.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error setting image: {ex.Message}", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }

        private void LoadPersonInfosToControls()
        {
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
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

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                pbPersonImage.Tag = "Costum";
                _CuurentImagePath = _Person.ImagePath;
                
            }
        }
        private void LoadPersonInfosFromControls()
        {
            _Person.FirstName = tbFirstName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbxThirdName.Text;
            _Person.NationalNo = tbNationalNo.Text;
            _Person.Email = tbEmail.Text;
            _Person.Phone = tbPhone.Text;
            _Person.Address = tbAddress.Text;
            _Person.NationalCountryID = (clsCountry.Find(cbCountry.Text)).CountryID;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (cbMale.Checked == true)
            {
                _Person.Gendor = 0;
            }
            else if (cbFemale.Checked == true)
            {
                _Person.Gendor = 1;

            }

            if ((string)pbPersonImage.Tag == "Costum" && !string.IsNullOrEmpty(_CuurentImagePath))
            {
                _Person.ImagePath = _CuurentImagePath;
            }
            else
            {
                _Person.ImagePath = string.Empty;
            }
        }
        private void usAdd_Edit_PersonInfos_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            DataTable dt = clsCountry.GetList();
            foreach (DataRow row in dt.Rows)
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

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked == true)
            {
                cbFemale.Checked = false;
                if (pbPersonImage.Image == null || (string)pbPersonImage.Tag == "Female")
                {
                    pbPersonImage.Tag = "Male";

                    pbPersonImage.Image = Properties.Resources.DefaultMalePic;
                }

            }
        }
        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked == true)
            {
                cbMale.Checked = false;
                if (pbPersonImage.Image == null || (string)pbPersonImage.Tag == "Male")
                {
                    pbPersonImage.Tag = "Female";
                    pbPersonImage.Image = Properties.Resources.DefaultFemalePic;
                }

            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (File.Exists(_CuurentImagePath))
            {
                File.Delete(_CuurentImagePath);
                _CuurentImagePath = string.Empty;

            }
            if (cbMale.Checked == true)
            {
                pbPersonImage.Tag = "Male";
                pbPersonImage.Image = Properties.Resources.DefaultMalePic;
            }
            else if (cbFemale.Checked == true)
            {
                pbPersonImage.Tag = "Female";
                pbPersonImage.Image = Properties.Resources.DefaultFemalePic;
            }
            else
            {
                pbPersonImage.Image = null;
            }
            btnRemove.Visible = false;
        }
        private void ValiditingControlsAtFocusChange(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (string.IsNullOrEmpty(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider1.SetError(textbox, textbox.Tag.ToString() + " cannot be blank!");
            }
            else
            {
                errorProvider1.SetError(textbox, "");

            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = tbEmail.Text.Trim();
            if (string.IsNullOrEmpty(Email))
            {
                errorProvider1.SetError(tbEmail, "");
                return;
            }
            string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(Email, Pattern))
            {
                errorProvider1.SetError(tbEmail, "Email Format is incorrect");
                e.Cancel = true;
                tbEmail.Focus();
            }
            else
            {
                errorProvider1.SetError(tbEmail, "");
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            string Phone = tbPhone.Text.Trim();
            if (string.IsNullOrEmpty(Phone))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Phone can't be blank!!");
                tbPhone.Focus();
            }
            string Pattern = @"^\+?[0-9]{8,15}$";
            if (!Regex.IsMatch(Phone, Pattern))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Phone format is incorrect!");
                tbPhone.Focus();
            }
            else
            {
                errorProvider1.SetError(tbPhone, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbFirstName) != "" || errorProvider1.GetError(tbSecondName) != "" || errorProvider1.GetError(tbxThirdName) != ""
                || errorProvider1.GetError(tbLastName) != "" || errorProvider1.GetError(tbNationalNo) != "" || errorProvider1.GetError(tbEmail) != ""
                || errorProvider1.GetError(tbPhone) != "" || errorProvider1.GetError(tbAddress) != "" || (cbMale.Checked == false && cbFemale.Checked == false))
            {
                MessageBox.Show("Please fill in all required fields before saving.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoadPersonInfosFromControls();
                if (_Person.Save())
                {
                    MessageBox.Show("Person infos are saved successfully.", "Infromations saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Person infos arn't saved successfully.", "Infromations not saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                sendpersonidback?.Invoke(this, _Person.PersonID);
                
            }
        }
    }
}
