using System.Data;
using Microsoft.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        static public bool Find(int PersonID,ref string NationalNo,ref string FirstName,ref string SecondName,ref string ThirdName,
                           ref string LastName,ref DateTime DateOfBirth,ref short Gendor,ref string Address,ref string Phone,ref string Email,ref int NationalityCountryID,ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    isFound = true;
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName= (string)reader["ThirdName"];
                    LastName= (string)reader["LastName"];
                    DateOfBirth= (DateTime)reader["DateOfBirth"];
                    Gendor= Convert.ToInt16( reader["Gendor"]);
                    Address= (string)reader["Address"];
                    Email= (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID= (int)reader["NationalityCountryID"];
                    ImagePath= (string)reader["ImagePath"];

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

        static public bool Find(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName,
                           ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToInt16(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = (string)reader["ImagePath"];

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

        static public bool IsExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from People 
                                where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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

        static public bool IsExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from People 
                                where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
        static public bool AddNewPerson(ref int PersonID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,DateTime DateOfBirth,
                                      string Address, short Gendor, string Email,string Phone, int NationalityCountryID,string ImagePath  )
        {
            bool isPersonAdded = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into People 
                                (NationalNo , FirstName , SecondName , ThirdName , LastName ,
                                    DateOfBirth , Address, Gendor , Email, Phone , NationalityCountryID, ImagePath )
                        values (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
                            @DateOfBirth, @Address, @Gendor, @Email, @Phone, @NationalityCountryID, @ImagePath);
                        SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == null || ImagePath == "")
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            try
            {
                Connection.Open();
                var Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString() , out int PersonIDreturned))
                {
                    isPersonAdded = true;
                    PersonID = PersonIDreturned;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return isPersonAdded;

        }
        static public int UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
                            string LastName, DateTime DateOfBirth, short Gendor, string Address, string Email, string Phone,  int NationalityCountryID, string ImagePath)
        {
            int RowsEffected= -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [dbo].[People]
                     SET [NationalNo] = @NationalNo
                        ,[FirstName] = @FirstName
                        ,[SecondName] = @SecondName
                        ,[ThirdName] = @ThirdName
                        ,[LastName] = @LastName
                        ,[DateOfBirth] = @DateOfBirth
                        ,[Gendor] = @Gendor
                        ,[Address] = @Address
                        ,[Phone] = @Phone
                        ,[Email] = @Email
                        ,[NationalityCountryID] = @NationalityCountryID
                        ,[ImagePath] = @ImagePath
                         WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == null || ImagePath == "")
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

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
            return RowsEffected;
        }

        static public int DeletePerson(int PersonID)
        {
            int RowsEffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete from [dbo].[People]
                         WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
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
        static public DataTable GetList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from People";
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
        public static DataTable GetListForShow()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, case
                    when Gendor = 0 then 'Male'
                    when Gendor = 1 then 'Female'
                    end as Gendor, Address ,CountryName as Nationality, Phone, Email from People
                                    inner join Countries on NationalityCountryID = CountryID";
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
