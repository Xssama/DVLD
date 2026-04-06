using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVDL_app
{
    public partial class frmPersonInformations : Form
    {
        int _PersonID = -1;
        public frmPersonInformations(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void frmPersonInformations_Load(object sender, EventArgs e)
        {
            usPersonInformations usPersonDetails = new usPersonInformations(_PersonID);
            usPersonDetails.Dock = DockStyle.Fill;
            gbPersonInfos.Controls.Add(usPersonDetails);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
