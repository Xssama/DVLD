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
    public partial class frmUserInfos : Form
    {
        clsUser _User = new clsUser();
        public frmUserInfos(int Userid)
        {
            _User = clsUser.Find(Userid);
            InitializeComponent();
        }

        private void frmUserInfos_Load(object sender, EventArgs e)
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
