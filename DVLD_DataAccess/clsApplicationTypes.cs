using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsApplicationTypes
    {
        public static DataTable GetList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationTypes";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader != null)
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

        static public int Update(int id, string Title, float fees )
        {
            int EffectedRows = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE ApplicationTypes
                            SET ApplicationTypeTitle = @title
                            ,ApplicationFees = @fees
                        WHERE ApplicationTypeID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@fees", fees);

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
