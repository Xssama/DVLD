using System.Data;
using DVLD_DataAccess;
namespace DVLD_BUSINESS
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalCountryID { get; set; }
        public string ImagePath { get; set; }

        public enum enPersonStatus { AddNew = 0, Update = 1};
        public enPersonStatus Status;
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName= "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalCountryID= -1;
            this.ImagePath= "";
            this.Status = enPersonStatus.AddNew;
        }
        clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
                                      string Address, short Gendor, string Email, string Phone, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.Status = enPersonStatus.Update;

        }

        public static bool IsExist(int PersonID)
        {
            return clsPersonData.IsExist(PersonID);
        }

        public static bool IsExist(string NationalNo)
        {
            return clsPersonData.IsExist(NationalNo);
        }


        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "",
             FirstName = "",
             SecondName = "",
             ThirdName = "",
             LastName = "",
            Address = "",
            Phone = "",
            Email = "",
            ImagePath = "";
            short Gendor = -1;
            DateTime DateOfBirth = DateTime.Now;
            int NationalCountryID = -1;
            if (clsPersonData.Find(PersonID,ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
                ref Phone, ref Email, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Address, Gendor, Email, Phone, NationalCountryID, ImagePath);
            }
            else
            {
                return new clsPerson();
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            int Personid = -1;
            string  FirstName = "",
             SecondName = "",
             ThirdName = "",
             LastName = "",
            Address = "",
            Phone = "",
            Email = "",
            ImagePath = "";
            short Gendor = -1;
            DateTime DateOfBirth = DateTime.Now;
            int NationalCountryID = -1;
            if (clsPersonData.Find(ref Personid,NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
                ref Phone, ref Email, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(Personid, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Address, Gendor, Email, Phone, NationalCountryID, ImagePath);
            }
            else
            {
                return new clsPerson();
            }
        }
        bool _AddPerson()
        {
            int Personid = -1;
            if (clsPersonData.AddNewPerson(ref Personid, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.Address, this.Gendor, this.Email, this.Phone, this.NationalCountryID, this.ImagePath))
            {
                this.PersonID = Personid;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool _Update()
        {
            return ((clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.Gendor, this.Address, this.Email, this.Phone, this.NationalCountryID, this.ImagePath)) != -1);
            
        }
        public bool Save()
        {
            switch (this.Status)
            {
                case enPersonStatus.AddNew:
                    if (_AddPerson())
                    {
                        this.Status = enPersonStatus.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                case enPersonStatus.Update:
                    if (_Update())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    break;
            }
            return false;
        }

        static public bool DeletePerson(int PersonID)
        {
            return (clsPersonData.DeletePerson(PersonID) != -1);
        }

        static public DataTable GetList()
        {
            return clsPersonData.GetList();
        }
        static public DataTable GetListForShow()
        {
            return clsPersonData.GetListForShow();
        }



    }
}
