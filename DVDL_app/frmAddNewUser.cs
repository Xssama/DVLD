using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmAddNewUser : Form
    {
        clsPerson _person = new clsPerson();
        clsUser _User = new clsUser();
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
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

        private void refereshPersonInfos()
        {
            gpPersonalInfos.Controls.Clear();
            usPersonInformations personifnos = new usPersonInformations(_person.PersonID);
            personifnos.Dock = DockStyle.Fill;
            gpPersonalInfos.Controls.Add(personifnos);
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
        }
        private void LoadDataBackFromAddingNewPersonForm(object sender, int PersonId)
        {
            _person = clsPerson.Find(PersonId);
            tbxfilterby.Text = PersonId.ToString();
            cbFilterBy.SelectedIndex = 0;

            gbFilter.Enabled = false;
            //delete any error icon in front of filter by text
            errorProvider1.SetError(tbxfilterby, "");
            refereshPersonInfos();
        }

        private void tbxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (clsUser.IsExist(tbxUserName.Text))
            {
                errorProvider1.SetError(tbxUserName, "User with this UserName Already exists!");
            }
            else
            {
                errorProvider1.SetError(tbxUserName, "");
            }
        }



        private void tbxConfrimPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbxConfirmPass.Text != tbxPassword.Text)
            {
                errorProvider1.SetError(tbxConfirmPass, "The input doesn't match the password !!");
            }
            else
            {
                errorProvider1.SetError(tbxConfirmPass, "");
            }
        }

        private void tbxNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbxPassword.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(tbxPassword, "The new password can't be blank !!");
            }
            else
            {
                errorProvider1.SetError(tbxPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(tbxUserName) != "" || tbxUserName.Text.IsNullOrEmpty())
                || (errorProvider1.GetError(tbxPassword) != "" || tbxPassword.Text.IsNullOrEmpty())
                    || (errorProvider1.GetError(tbxConfirmPass) != "" || tbxConfirmPass.Text.IsNullOrEmpty())
                    || (_person.PersonID == -1 || clsUser.isPersonLinkedToUser(_person.PersonID)))
            {
                MessageBox.Show("User can't be Added!!", "error appeared", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _User.Password = tbxPassword.Text;
                _User.UserName = tbxUserName.Text;
                _User.PersonID = _person.PersonID;
                if (htActive.Checked)
                {
                    _User.isActive = true;
                }
                else
                {
                    _User.isActive = false;
                }
                if (_User.Save())
                {
                    MessageBox.Show("User is Added successfully");
                    lblUserid.Text = _User.UserID.ToString();
                }
                else
                {
                    MessageBox.Show("User can't be Added!!", "error appeared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkifPersonLinked()
        {
            if (clsUser.isPersonLinkedToUser(_person.PersonID))
            {
                MessageBox.Show("The Person is already linked to User!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _User.PersonID = _person.PersonID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkifPersonLinked();
            tabControl1.SelectedTab = tpLoginPage;
        }
    }
}
