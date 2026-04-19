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
    public partial class usFindPerson : UserControl
    {
        public delegate void SendThePersonBackHandler(object sender, int ID);
        public SendThePersonBackHandler SendIDBack;
        clsPerson _person = new clsPerson();
        public usFindPerson(int PersonID = -1)
        {
            InitializeComponent();
            if (PersonID >= 0 && clsPerson.IsExist(PersonID))
            {
                _person = clsPerson.Find(PersonID);
                refereshPersonInfos();
                gbFilter.Enabled = false;
            }
        }

        public usFindPerson(string NationalNo = "")
        {
            InitializeComponent();
            if (NationalNo != "" && clsPerson.IsExist(NationalNo))
            {
                _person = clsPerson.Find(NationalNo);
                refereshPersonInfos();
                gbFilter.Enabled = false;
            }
        }

        // Add an explicit parameterless constructor so Designer code (new usFindPerson())
        // resolves unambiguously even if other overloads exist.
        public usFindPerson()
        {
            InitializeComponent();
        }
        private void refereshPersonInfos()
        {
            gpPersonalInfos.Controls.Clear();
            usPersonInformations personifnos = new usPersonInformations(_person.PersonID);
            personifnos.Dock = DockStyle.Fill;
            gpPersonalInfos.Controls.Add(personifnos);
        }
        private void usFindPerson_Load(object sender, EventArgs e)
        {
            ToolTip searchHoverTip = new ToolTip();
            searchHoverTip.SetToolTip(btnSearch, "Click here to search for the person");

            ToolTip addpersonHoverTip = new ToolTip();
            addpersonHoverTip.SetToolTip(btnAddPerson, "Click here to add new person");

            cbFilterBy.SelectedIndex = 0;
            refereshPersonInfos();
            
        }


        private void tbxfilterby_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetIconPadding(tbxfilterby, 20);
            if (cbFilterBy.SelectedIndex == 0)
            {
                if (!int.TryParse(tbxfilterby.Text, out int PersonID) || tbxfilterby.Text.IsNullOrEmpty())
                {
                    errorProvider1.SetError(tbxfilterby, "The input is invalid, Enter a number Please!");
                }
                else
                {
                    errorProvider1.SetError(tbxfilterby, "");
                }
            }
            else
            {
                if (tbxfilterby.Text.IsNullOrEmpty())
                {
                    errorProvider1.SetError(tbxfilterby, "The input is invalid");
                }
                else
                {
                    errorProvider1.SetError(tbxfilterby, "");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (errorProvider1.GetError(tbxfilterby) != "" || tbxfilterby.Text.IsNullOrEmpty())
            {
                tbxfilterby.Focus();
            }
            else
            {
                if (cbFilterBy.SelectedIndex == 0)
                {
                    _person = clsPerson.Find(int.Parse(tbxfilterby.Text));
                    if (_person.PersonID == -1)
                    {
                        MessageBox.Show("There's no Person with this id in the systeme!!", "No Person Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SendIDBack?.Invoke(this, _person.PersonID);
                        refereshPersonInfos();
                    }
                }
                else
                {
                    _person = clsPerson.Find(tbxfilterby.Text);
                    if (_person.PersonID == -1)
                    {
                        MessageBox.Show("There's no Person with this N° in the systeme!!", "No Person Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SendIDBack?.Invoke(this, _person.PersonID);
                        refereshPersonInfos();
                    }
                }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addperson = new frmAddEditPerson();
            addperson.SendPersonIdBack += LoadDataBackFromAddingNewPersonForm;
            addperson.ShowDialog();
            SendIDBack?.Invoke(this, _person.PersonID);
        }
        private void LoadDataBackFromAddingNewPersonForm(object sender, int PersonId)
        {
            _person = clsPerson.Find(PersonId);
            if (_person.PersonID != -1)
            {
                tbxfilterby.Text = PersonId.ToString();
                cbFilterBy.SelectedIndex = 0;

                gbFilter.Enabled = false;
                //delete any error icon in front of filter by text
                errorProvider1.SetError(tbxfilterby, "");
                refereshPersonInfos();
                SendIDBack?.Invoke(this, _person.PersonID);
            }
           
        }
    }
}
