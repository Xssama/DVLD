using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLD_DataAccess;

namespace DVLD_BUSINESS
{
    public class clsApplicationType
    {
        public int ID { get; set; }
        public string Title{ get; set; }
        public float Fees { get; set; }
        public clsApplicationType()
        {
            ID = -1;
            Title = "";
            Fees = 0;
        }
        private clsApplicationType(int id, string title, float fees)
        {
            ID = id;
            Title = title;
            Fees = fees;
        }

        static public clsApplicationType Find(int ID)
        {
            string Title = "";
            float fees = 0;
            if (clsApplicationTypes.Find(ID, ref Title, ref fees))
            {
                return new clsApplicationType(ID, Title, fees);
            }
            else
            {
                return new clsApplicationType();
            }
        }
        static public clsApplicationType Find(string Title)
        {
            int ID = -1;
            float fees = 0;
            if (clsApplicationTypes.Find(ref ID, Title, ref fees))
            {
                return new clsApplicationType(ID, Title, fees);
            }
            else
            {
                return new clsApplicationType();
            }
        }
        public bool Update()
        {
            return ( clsApplicationTypes.Update(ID, Title, Fees) == -1 ? false : true);
        }

        static public DataTable GetList()
        {
            return clsApplicationTypes.GetList();
        }
    }
}
