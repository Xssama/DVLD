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
    public partial class frmAddEditPerson : Form
    {
 
        clsPerson _Person;
        public frmAddEditPerson(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            InitializeComponent();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (_Person.Status == clsPerson.enPersonStatus.AddNew)
            {
                lblHeader.Text = "Add Person Infos";
            }
            else
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                lblHeader.Text = "Update Person Infos";

            }

            usAdd_Edit_PersonInfos addeditus = new usAdd_Edit_PersonInfos(_Person);
            addeditus.Dock = DockStyle.Fill;
            addeditus.sendpersonidback += FillPersonIdLabel;
            plAddEditUSContainer.Controls.Add(addeditus);
        }

        private void FillPersonIdLabel(object sender, int PersonID)
        {
            lblPersonID.Text = PersonID.ToString();
        }
    }
}
