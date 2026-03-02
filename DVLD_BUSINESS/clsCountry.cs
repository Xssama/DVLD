using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BUSINESS
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        
        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            
        }
        clsCountry(int Countryid, string CountryName)
        {
            this.CountryID = Countryid;
            this.CountryName = CountryName;
            
        }


        public static bool IsExist(int CountryID)
        {
            return clsCountriesData.IsExist(CountryID);
        }

        public static bool IsExist(string CountryName)
        {
            return clsCountriesData.IsExist(CountryName);
        }


        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
             
            if (clsCountriesData.Find(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return new clsCountry();
            }
        }

        public static clsCountry Find(string CountryName)
        {
           
            int CountryID = -1;
            if (clsCountriesData.Find(ref CountryID, CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return new clsCountry();
            }
        }
        
        static public DataTable GetList()
        {
            return clsCountriesData.GetList();
        }

    }
}
