using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static DVLD_BUSINESS.clsPerson;

namespace DVLD_BUSINESS
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public bool isActive { get; set; }
        public enum enUserStatus { AddNew, Update };
        public enUserStatus UserStatus;
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;
            UserStatus = enUserStatus.AddNew;
        }
        clsUser(int userid, int PersonID, string username, string password, bool isactive)
        {
            this.UserID = userid;
            this.PersonID = PersonID;
            this.UserName = username;
            this.Password = password;
            this.isActive = isactive;
            UserStatus = enUserStatus.Update;
        }


        public static bool IsExist(int UserID)
        {
            return clsUsersData.IsExist(UserID);
        }

        public static bool IsExist(string UserName)
        {
            return clsUsersData.IsExist(UserName);
        }
        public static bool isPersonLinkedToUser(int PersonId)
        {
            return clsUsersData.isPersonLinkedTouser(PersonId);
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "",
             Password = "";
            bool isActive = false;
            int Personid = -1;
            if (clsUsersData.Find(UserID, ref UserName, ref Personid, ref Password, ref isActive))
            {
                return new clsUser(UserID, Personid, UserName, Password,isActive);
            }
            else
            {
                return new clsUser();
            }
        }

        public static clsUser Find(string UserName)
        {
            string Password = "";
            bool isActive = false;
            int Personid = -1, UserID = -1;
            if (clsUsersData.Find(ref UserID, UserName, ref Password, ref Personid, ref isActive))
            {
                return new clsUser(UserID, Personid, UserName, Password, isActive);
            }
            else
            {
                return new clsUser();
            }
        }
        bool _AddUser()
        {
            int UserID = -1;
            if (clsUsersData.AddNewUser(ref UserID, this.UserName, this.Password, this.PersonID, this.isActive))
            {
                this.UserID = UserID;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool _Update()
        {
            return ((clsUsersData.UpdateUser(this.UserID, this.UserName, this.Password, this.PersonID, this.isActive)) != -1);

        }
        public bool Save()
        {
            switch (this.UserStatus)
            {
                case enUserStatus.AddNew:
                    if (_AddUser())
                    {
                        this.UserStatus = enUserStatus.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enUserStatus.Update:
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

        public static bool DeleteUser(int userid)
        {
            return (clsUsersData.DeleteUser(userid) != -1);
        }
        static public DataTable GetList(bool forShow = false)
        {
            return clsUsersData.GetList(forShow);
        }

    }

}
