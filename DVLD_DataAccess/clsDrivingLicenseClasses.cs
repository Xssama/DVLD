using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsDrivingLicenseClasses
    {
        public static bool Find(int ID, ref string ClassName,ref string ClassDes, ref short MinimumAllowedAge, ref short DefaultValidityLength, ref float Fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from LicenseClasses where LicenseClassID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ClassName = (string)reader["ClassName"];
                    ClassDes = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
                    Fees = Convert.ToSingle(reader["ClassFees"]);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool Find(ref int ID, string ClassName, ref string ClassDes, ref short MinimumAllowedAge, ref short DefaultValidityLength, ref float Fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from LicenseClasses where ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = Convert.ToInt32(reader["LicenseClassID"]);
                    ClassDes = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
                    Fees = Convert.ToSingle(reader["ClassFees"]);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from LicenseClasses";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        static public int Update(int id, string ClassName,string ClassDes, short MiniAgeAllowed, short DefaultValidityLength, float fees)
        {
            int EffectedRows = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[LicenseClasses]
                                  SET [ClassName] = @ClassName
                                     ,[ClassDescription] = @ClassDes
                                     ,[MinimumAllowedAge] = @MiniAgeAllowed
                                     ,[DefaultValidityLength] = @DefaultValidityLength
                                     ,[ClassFees] = @fees
                                WHERE LicenseClassID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDes", ClassDes);
            command.Parameters.AddWithValue("@MiniAgeAllowed", MiniAgeAllowed);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                int Effected = command.ExecuteNonQuery();
                if (Effected > 0)
                {
                    EffectedRows = Effected;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return EffectedRows;
        }
    }
}
