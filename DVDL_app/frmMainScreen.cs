using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVLD_BUSINESS;
namespace DVDL_app
{
    public partial class frmMainScreen : Form
    {
        clsUser _User = new clsUser();
        public frmMainScreen(clsUser user)
        {
            _User = user;
            InitializeComponent();
        }

        private void loginUserInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfos frmuserinfos = new frmUserInfos(_User.UserID);
            frmuserinfos.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frmchangepass = new frmChangeUserPassword(_User.UserID);
            frmchangepass.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
