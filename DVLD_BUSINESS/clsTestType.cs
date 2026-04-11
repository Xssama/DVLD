using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BUSINESS
{
    public class clsTestType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public float Fees { get; set; }
        public clsTestType()
        {
            ID = -1;
            Title = "";
            Description = "";
            Fees = 0;
        }
        private clsTestType(int id, string title,string description, float fees)
        {
            ID = id;
            Title = title;
            Description = description;
            Fees = fees;
        }

        static public clsTestType Find(int ID)
        {
            string title = "";
            string descirption = "";
            float fees = 0;
            if (clsTestTypes.Find(ID, ref title,ref descirption, ref fees))
            {
                return new clsTestType(ID, title, descirption, fees);
            }
            else
            {
                return new clsTestType();
            }
        }

        public bool Update()
        {
            return (clsTestTypes.Update(ID, Title,Description, Fees) == -1 ? false : true);
        }

        static public DataTable GetList()
        {
            return clsTestTypes.GetList();
        }

}
}
