using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLD_DataAccess;
namespace DVLD_BUSINESS
{
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public enum enMode { AddNew, Update };
        public enMode Mode;

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }

        public static int PassedTests(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.PassedTests(LDLAppID);
        }
        public  int PassedTests()
        {
            return clsLocalDrivingLicenseApplicationsData.PassedTests(LocalDrivingLicenseApplicationID);
        }
        public static bool IsExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsExist(LocalDrivingLicenseApplicationID);
        }

        public static bool IsPersonAlreadyAppliedToLicenseClass(int ApplicationID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsPersonAlreadyAppliedToLicenseClass(ApplicationID, LicenseClassID);
        }
        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationsData.Find(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewApplication()
        {
            int ID = -1;
            if (clsLocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplication(ref ID, this.ApplicationID, this.LicenseClassID))
            {
                this.LocalDrivingLicenseApplicationID = ID;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool _UpdateApplication()
        {
            return (clsLocalDrivingLicenseApplicationsData.updateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID) != -1);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplication();

                default:
                    return false;
            }
        }

        public static bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            return (clsLocalDrivingLicenseApplicationsData.DeleteApplication(LocalDrivingLicenseApplicationID) != -1);
        }

        public static DataTable GetList(bool forShow = false)
        {
            return clsLocalDrivingLicenseApplicationsData.GetList(forShow);
        }
        public static DataRow ReturnDataRowFromLDLAppView(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.ReturnDataRowFromLDLAppView(LDLAppID);
        }
    }
}
