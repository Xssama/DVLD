using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
        ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate,
        ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    // Safely handle nullable Release columns
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = DateTime.MaxValue; // Placeholder for null

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;
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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate,
            ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate,
            ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Gets the most recent detain record for this license if there are multiple
            string Query = "SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = DateTime.MaxValue;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;
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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO DetainedLicenses 
                             (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)                  
                         VALUES 
                             (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);                  
                         SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            // Handle possible null values for the Release fields
            if (!IsReleased)
            {
                Command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);
                Command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [dbo].[DetainedLicenses]               
                         SET [LicenseID] = @LicenseID                  
                            ,[DetainDate] = @DetainDate
                            ,[FineFees] = @FineFees
                            ,[CreatedByUserID] = @CreatedByUserID
                            ,[IsReleased] = @IsReleased
                            ,[ReleaseDate] = @ReleaseDate
                            ,[ReleasedByUserID] = @ReleasedByUserID
                            ,[ReleaseApplicationID] = @ReleaseApplicationID
                         WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            // Handle possible null values for the Release fields
            if (!IsReleased)
            {
                Command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);
                Command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from DetainedLicenses_View";

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
    }
}
