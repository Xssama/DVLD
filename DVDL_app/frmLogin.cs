using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DVLD_BUSINESS;
using Microsoft.IdentityModel.Tokens;
using System.Numerics;
namespace DVDL_app
{
    public partial class frmLogin : Form
    {
        string RememberMeFileLocation = @"C:\DVLD-USER-RememberME\RememerMeFile.txt";
        clsUser _User;
        public frmLogin()
        {
            InitializeComponent();
            List<string>  vstr = System.IO.File.ReadAllLines(RememberMeFileLocation).ToList();
            if (vstr.Count() == 0)
            {
                return;
            }
            else
            { 
                    tbxUserName.Text = vstr[0].Trim();
                    tbxPassword.Text = vstr[1].Trim();
                    htRememberMe.Checked = true;
            }
            
            
        }

        void ValiditingTextBoxInput(object sender, EventArgs ev)
        {
            TextBox tbx = (TextBox)sender;
            if (tbx.Text.Trim().IsNullOrEmpty())
            {
                errorProvider.ContainerControl = this;
                errorProvider.SetIconPadding(tbx, 27);
                errorProvider.SetError(tbx, tbx.Tag + " Can't be blank!");
            }
            else
            {
                errorProvider.SetError(tbx, "");
            }

        }

        private bool VerifyInputs()
        {
            if ((errorProvider.GetError(tbxUserName) != "" || tbxUserName.Text.IsNullOrEmpty()) ||
                (errorProvider.GetError(tbxPassword) != "" || tbxUserName.Text.IsNullOrEmpty()))
            {
                MessageBox.Show("Username/Password is invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string UserName = tbxUserName.Text.Trim(), Password = tbxPassword.Text.Trim();
            _User = clsUser.Find(UserName);
            if (_User.Password != Password)
            {
                MessageBox.Show("Username/Password is invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RememberUserHndler()
        {
            if (htRememberMe.Checked == true)
            {
                using (StreamWriter sw = new StreamWriter(RememberMeFileLocation))
                {
                     sw.WriteLine(tbxUserName.Text.Trim());
                     sw.WriteLine(tbxPassword.Text.Trim());                   
                }
            }
            else
            {
                File.WriteAllText(RememberMeFileLocation, "");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (VerifyInputs())
            {
                RememberUserHndler();
                frmMainScreen MainScreen = new frmMainScreen(_User);
                MainScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try Again :(");
            }
        }
    }
}
