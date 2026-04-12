using DVLD_DataAccess;
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

    public partial class frmEditAppType : Form
    {
        clsApplicationType _AppType = new clsApplicationType();
        public frmEditAppType(int AppID)
        {
            _AppType = clsApplicationType.Find(AppID);
            InitializeComponent();
            tbxID.Text = _AppType.ID.ToString();
            tbxTitle.Text = _AppType.Title;
            tbxFees.Text = _AppType.Fees.ToString();
        }

        private void tbxFees_Validating(object sender, CancelEventArgs e)
        {
            if (tbxFees.Text.IsNullOrEmpty() || !float.TryParse(tbxFees.Text, out _))
            {
                errorProvider1.SetError(tbxFees, "The Input is invalid, try again !");
            }
            else
            {
                errorProvider1.SetError(tbxFees, "");
            }
        }

        private void tbxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (tbxTitle.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(tbxTitle, "Title can't be blank!");

            }
            else
            {
                errorProvider1.SetError(tbxTitle, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbxTitle) != "" || errorProvider1.GetError(tbxFees) != "" )
            {
               
                MessageBox.Show("The inputs is not valid!", "Update application type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _AppType.Title = tbxTitle.Text;
                _AppType.Fees = float.Parse(tbxFees.Text);
                if (_AppType.Update())
                {
                    MessageBox.Show("The application type is updated successfully", "Update application type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The application type is not updated", "Update application type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
