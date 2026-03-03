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
            Application.Run(new frmAddEditPerson(1));
           
        }
    }
}