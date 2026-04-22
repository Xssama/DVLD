using DVLD_BUSINESS;

namespace DVDL_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new FrmManagePeople());
            //Application.Run(new frmManageAppointments(32, 1));
            clsGlobal.CurrentUser = clsUser.Find("Xussama");
            //Application.Run(new frmManageLocalDrivingLicenseApplications());
            //Application.Run(new frmShowLicenseInfos(41));

            //Application.Run(frmShowLicenseInfos.LoadFormByLDLAppID(41));
            Application.Run(new frmIssueInternationalLicenseApp());
            //Application.Run(new frmManageDrivers());
            //Application.Run(new frmIssueDriverLicense(36));
            //Application.Run(new frmLogin());

            //Application.Run(new frmPersonLicenseHistory(2041));
            //Application.Run(new frmScheduleTest(30, 1));
        }
    }
}