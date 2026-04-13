using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Net.WebRequestMethods;

namespace DVLD_BUSINESS
{
    public class clsDrivingLicenseClasse
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clsDrivingLicenseClasse () 
        {
            ID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }
        public clsDrivingLicenseClasse(int id, string classname, string classdescription,short miniallowedage, short defaultvaliditylength, float classfees)
        {

            ID = id;
            ClassName = classname;
            ClassDescription = classdescription;
            MinimumAllowedAge = miniallowedage;
            DefaultValidityLength = defaultvaliditylength;
            ClassFees = classfees;
        }

        static public clsDrivingLicenseClasse Find(int ID)
        {
            string ClassName = "";
            string ClassDes = "";
            short MiniAllowedAge = 0;
            short ValidityLength = 0;
            float fees = 0;
            if (clsDrivingLicenseClasses.Find(ID, ref ClassName,ref ClassDes, ref MiniAllowedAge, ref ValidityLength, ref fees))
            {
                return new clsDrivingLicenseClasse(ID, ClassName,ClassDes, MiniAllowedAge, ValidityLength, fees);
            }
            else
            {
                return new clsDrivingLicenseClasse();
            }
        }

        static public clsDrivingLicenseClasse Find(string ClassName)
        {
            int ID = -1;
            string ClassDes = "";
            short MiniAllowedAge = 0;
            short ValidityLength = 0;
            float fees = 0;
            if (clsDrivingLicenseClasses.Find(ref ID, ClassName,ref ClassDes, ref MiniAllowedAge, ref ValidityLength, ref fees))
            {
                return new clsDrivingLicenseClasse(ID, ClassName, ClassDes, MiniAllowedAge, ValidityLength, fees);
            }
            else
            {
                return new clsDrivingLicenseClasse();
            }
        }

        public bool Update()
        {
            return (clsDrivingLicenseClasses.Update(ID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees) == -1 ? false : true);
        }

        static public DataTable GetList()
        {
            return clsDrivingLicenseClasses.GetList();
        }
    }
}
