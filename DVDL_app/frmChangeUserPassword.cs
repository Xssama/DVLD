using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
namespace DVDL_app
{
    public partial class frmChangeUserPassword : Form
    {
        clsUser _User = new clsUser();
        public frmChangeUserPassword(int UserID)
        {
            _User = clsUser.Find(UserID);
            InitializeComponent();
        }

        private void tbxCurentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxCurentPassword.Text != _User.Password)
            {
                errorProvider1.SetError(tbxCurentPassword, "The Password is wrong !");
            }
            else
            {
                errorProvider1.SetError(tbxCurentPassword, "");
            }
        }



        private void tbxConfrimPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbxConfirmPass.Text != tbxNewPass.Text)
            {
                errorProvider1.SetError(tbxConfirmPass, "The input doesn't match the new password !!");
            }
            else
            {
                errorProvider1.SetError(tbxConfirmPass, "");
            }
        }

        private void tbxNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbxNewPass.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(tbxNewPass, "The new password can't be blank !!");
            }
            else
            {
                errorProvider1.SetError(tbxNewPass, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(tbxCurentPassword) != "" || tbxCurentPassword.Text.IsNullOrEmpty())
                || (errorProvider1.GetError(tbxNewPass) != "" || tbxNewPass.Text.IsNullOrEmpty())
                    || (errorProvider1.GetError(tbxConfirmPass) != "" || tbxConfirmPass.Text.IsNullOrEmpty()))
            {
                MessageBox.Show("Password can't be changed!!", "error appeared", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _User.Password = tbxNewPass.Text;
                if (_User.Save())
                {
                    MessageBox.Show("Password is changed!!");

                }
                else
                {
                    MessageBox.Show("Password can't be changed!!", "error appeared", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            usPersonInformations personinfos = new usPersonInformations(_User.PersonID);
            personinfos.Dock = DockStyle.Fill;
            gbPersonInfos.Controls.Add(personinfos);

            usUserLoginInfos logininfos = new usUserLoginInfos(_User.UserID, _User.UserName, _User.isActive);
            logininfos.Dock = DockStyle.Fill;
            gbLoginInfos.Controls.Add(logininfos);
        }
    }
}
