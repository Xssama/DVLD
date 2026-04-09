using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLD_DataAccess;

namespace DVLD_BUSINESS
{
    internal class ApplicationType
    {
        public int ID { get; set; }
        public string Title{ get; set; }
        public float Fees { get; set; }
        public ApplicationType()
        {
            ID = -1;
            Title = "";
            Fees = 0;
        }
        private ApplicationType(int id, string title, float fees)
        {
            ID = id;
            Title = title;
            Fees = fees;
        }

        public bool Update()
        {
            return ( clsApplicationTypes.Update(ID, Title, Fees) == -1 ? false : true);
        }

        public DataTable GetList()
        {
            return clsApplicationTypes.GetList();
        }
    }
}
