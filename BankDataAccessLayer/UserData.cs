using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BankDataAccessLayer;

namespace DataAccessLAyer
{
    public class clsUserData
    {
        static public int AddNewUser(string UserName, string Password, int Permissions)
        {
            int CurrentID;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "INSERT INTO [dbo].[Users]\r\n  " +
                "         ([UserName]\r\n           " +
                ",[Password]\r\n          " +
                " ,[Permissions])\r\n    " +
                " VALUES\r\n       " +
                "    (@UserName,@Password,@Permissions)"
                + "\nselect SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    CurrentID = ID;
                else
                    CurrentID = -1;


            }
            catch (Exception ex)
            {
                // msj = ex.Message;
                CurrentID = -1;
            }
            finally { connection.Close(); }
            return CurrentID;
        }
        static public bool UpdateUser(int UserID, string UserName, string Password, int Permissions)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "UPDATE [dbo].[Users]\r\n   SET" +
                " [UserName] = @UserName\r\n  " +
                "    ,[Password] = @Password\r\n  " +
                "    ,[Permissions] = @Permissions\r\n" +
                " WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                res = command.ExecuteNonQuery() > 0;


            }
            catch (Exception ex)
            {
                // msj = ex.Message;
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool DeleteUser(string Username)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string query = "DELETE FROM [dbo].[Users]\r\n      WHERE Users.UserName = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            try
            {
                connection.Open();
                res = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public DataTable UsersList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string query = "SELECT UserID, Username, Permissions FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally { connection.Close(); }
            return dt;
        }

        static public bool FindByUserName(string UserName,ref int UserID, ref string Password, ref int Permissions)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "SELECT *FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = Convert.ToInt16(reader["UserID"]);
                    Password = (string)reader["Password"];
                    Permissions = Convert.ToInt16(reader["Permissions"]);
                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool FindByUserNameAndPassword(string UserName, string Password, ref int UserID, ref int Permissions)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "SELECT *FROM Users WHERE UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    UserID = (int)reader["UserID"];
                    Permissions = (int)reader["Permissions"];
                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool isExist(string UserName, string Password)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "SELECT isFound=1 FROM Users WHERE UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            bool isFound = false;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = result != null;
            }
            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool isExist(string UserName)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);
            string Query = "SELECT isFound=1 FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            bool isFound = false;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = result != null;
            }
            catch (Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
