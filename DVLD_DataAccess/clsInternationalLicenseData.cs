using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {
        public static bool GetInternationalLicenseInfoByID(int InternationalLicenseID, ref int ApplicationID,
        ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
        ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
            }
            catch (Exception ex)
            {
                // Log exception here
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO InternationalLicenses 
                             (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)                  
                         VALUES 
                             (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);                  
                         SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Log Exception
            }
            finally
            {
                Connection.Close();
            }
            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [dbo].[InternationalLicenses]               
                         SET [ApplicationID] = @ApplicationID                  
                            ,[DriverID] = @DriverID
                            ,[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID
                            ,[IssueDate] = @IssueDate
                            ,[ExpirationDate] = @ExpirationDate
                            ,[IsActive] = @IsActive
                            ,[CreatedByUserID] = @CreatedByUserID
                         WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                RowsEffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log Exception
            }
            finally
            {
                Connection.Close();
            }
            return (RowsEffected > 0);
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"DELETE FROM [dbo].[InternationalLicenses] WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                Connection.Open();
                RowsEffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log Exception
            }
            finally
            {
                Connection.Close();
            }
            return (RowsEffected > 0);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                // Log Exception
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
