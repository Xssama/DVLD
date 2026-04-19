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
            //clsGlobal.CurrentUser = clsUser.Find("F48");
            Application.Run(new frmLogin());
            //Application.Run(new frmManageDrivers());
            //Application.Run(new frmIssueDriverLicense(36));
            //Application.Run(new frmLogin());

            //Application.Run(new frmManageLocalDrivingLicenseApplications(clsGlobal.CurrentUser));
            //Application.Run(new frmScheduleTest(30, 1));
        }
    }
}