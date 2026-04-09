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
            //Application.Run(new frmMainScreen());
            Application.Run(new frmLogin());
        }
    }
}