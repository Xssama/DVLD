using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class usUserLoginInfos : UserControl
    {
        public usUserLoginInfos(int userid, string username, bool isactive)
        {
            InitializeComponent();

            lblUserid.Text = userid.ToString();
            lblusername.Text = username.Trim();
            if (isactive == true)
            {
                lblisactive.Text = "Yes";

            }
            else
            {
                lblisactive.Text = "No";
            }
        }
    }
}
