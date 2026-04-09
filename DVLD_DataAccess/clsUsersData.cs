using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsUsersData
    {
        static public bool Find(int UserID, ref string UserName, ref int PersonID, ref string Password, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    isActive = (bool)reader["isActive"];

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

        static public bool Find(ref int UserID, string UserName, ref string Password, ref int PersonID, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Users where UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    isActive = (bool)reader["isActive"];

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
        public static bool isPersonLinkedTouser(int Personid)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Users where PersonID = @Personid";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Personid", Personid);
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

            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        static public bool IsExist(int UserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from Users 
                                where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool IsExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from Users 
                                where UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        static public bool AddNewUser(ref int UserID, string UserName, string Password, int PersonID, bool isActive)
        {
            bool isUserAdded = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Users 
                                (PersonID, UserName , Password ,  isActive )
                        values ( @PersonID, @UserName, @Password, @isActive);
                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@isActive", isActive);
            try
            {
                Connection.Open();
                var Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int UserIDreturned))
                {
                    isUserAdded = true;
                    UserID = UserIDreturned;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return isUserAdded;

        }
        static public int UpdateUser(int UserID, string UserName, string Password,int PersonID, bool isActive)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [dbo].[Users]
                     SET [UserName] = @UserName
                        ,[Password] = @Password
                        ,[PersonID] = @PersonID
                        ,[isActive] = @isActive
                         WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@isActive", isActive);
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
            return RowsEffected;
        }
        static public int DeleteUser(int UserID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete from [dbo].[Users]
                         WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
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
            return RowsEffected;
        }
        static public DataTable GetList(bool forShow = false)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "";
            if (forShow)
            {
                 query = @"select UserID, Users.PersonID,(FirstName + ' ' + SecondName + ' '+ ThirdName + ' ' + LastName) as FullName , UserName, IsActive from users
                                inner join People on People.PersonID = Users.PersonID";

            }
            else
            {
                query = "Select * from Users";
            }
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
    }
}
