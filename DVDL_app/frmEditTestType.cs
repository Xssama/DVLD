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
    public partial class frmEditTestType : Form
    {
        clsTestType _TestType = new clsTestType();
        public frmEditTestType(int TestID)
        {
            _TestType = clsTestType.Find(TestID);
            InitializeComponent();
            tbxID.Text = _TestType.ID.ToString();
            tbxTitle.Text = _TestType.Title;
            tbxDescription.Text = _TestType.Description;
            tbxDescription.MultiLine = true;
            tbxFees.Text = _TestType.Fees.ToString();
            
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


        private void aloneTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbxDescription.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(tbxTitle, "Description can't be blank!");

            }
            else
            {
                errorProvider1.SetError(tbxTitle, "");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbxTitle) != "" || errorProvider1.GetError(tbxFees) != "" || errorProvider1.GetError(tbxDescription) != "")
            {

                MessageBox.Show("The inputs is not valid!", "Update Test type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _TestType.Title = tbxTitle.Text.Trim();
                _TestType.Fees = float.Parse(tbxFees.Text.Trim());
                _TestType.Description = tbxDescription.Text.Trim();
                if (_TestType.Update())
                {
                    MessageBox.Show("The Test type is updated successfully", "Update Test type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Test type is not updated", "Update Test type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
