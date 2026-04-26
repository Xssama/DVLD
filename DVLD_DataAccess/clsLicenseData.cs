using DVLD_DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref float PaidFees,
            ref bool IsActive, ref short IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    // Safely handle nullable Notes column
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt16(reader["IssueReason"]);
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

        public static bool isLicenseLinkedToInternationalLicense(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from InternationalLicenses
                    where IssuedUsingLocalLicenseID = @LicenseID and IsActive = 1";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    
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

        public static bool isLicenseDetained(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select top 1 * from DetainedLicenses DL
                    where DL.LicenseID = @LicenseID and DL.IsReleased = 0";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isFound = true;

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
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
            bool IsActive, short IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Licenses 
                             (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)                  
                         VALUES 
                             (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);                  
                         SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            // Handle possible null value for Notes
            if (string.IsNullOrEmpty(Notes))
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
            bool IsActive, short IssueReason, int CreatedByUserID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [dbo].[Licenses]               
                         SET [ApplicationID] = @ApplicationID                  
                            ,[DriverID] = @DriverID
                            ,[LicenseClass] = @LicenseClass
                            ,[IssueDate] = @IssueDate
                            ,[ExpirationDate] = @ExpirationDate
                            ,[Notes] = @Notes
                            ,[PaidFees] = @PaidFees
                            ,[IsActive] = @IsActive
                            ,[IssueReason] = @IssueReason
                            ,[CreatedByUserID] = @CreatedByUserID
                         WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            // Handle possible null value for Notes
            if (string.IsNullOrEmpty(Notes))
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();
                RowsEffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return (RowsEffected > 0);
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses";

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
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool DeleteLicense(int LicenseID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"DELETE FROM [dbo].[Licenses] WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static DataTable GetAllPersonLicenses(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select Licenses.LicenseID, licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive from Licenses
                                inner join Drivers on Drivers.DriverID = Licenses.DriverID
                                inner join LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClass
                                inner join People on People.PersonID = Drivers.PersonID
                                where People.PersonID = @PersonID;
                                ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                IDataReader reader = Command.ExecuteReader();
                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                // Log Exception
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

    }
}