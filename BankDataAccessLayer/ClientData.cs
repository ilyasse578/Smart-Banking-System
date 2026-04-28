using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsClientData
    {
        static public DataTable ClientsList()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = "select * from Clients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtClients.Load(reader);
                }

                reader.Close();

            }

            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return dtClients;

        }

        static public bool FindByID(int ClientID, ref string AccountNumber, ref string PinCode, ref string FirstName, ref string LastName,
                                                       ref string Phone, ref string Email, ref decimal Balance)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"select * from Clients
                             where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Balance = Convert.ToDecimal(reader["Balance"]);
                }

                reader.Close();
            
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

        static public bool FindByAccountNumber(string AccountNumber, ref int ClientID, ref string PinCode, ref string FirstName, ref string LastName, ref string Phone,
                                    ref string Email, ref decimal Balance)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"select * from Clients
                             where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;

                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Balance = Convert.ToDecimal(reader["Balance"]);
                }

                reader.Close();

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

        static public bool IsClientExist(string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"select isfound=1 from Clients
                             where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            object result = null;

            try
            {
                connection.Open();

                result = command.ExecuteScalar();
            }

            catch (Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return result != null;

        }

        static public int AddNewClient(string AccountNumber, string PinCode, string FirstName, string LastName, string Phone,string Email, decimal Balance)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"INSERT INTO Clients
                             values (@AccountNumber, @PinCode, @FirstName, @LastName, @Phone, @Email, @Balance)
                             select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Balance", Balance);

            int NewClientID = -1;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                NewClientID = Convert.ToInt16(result);

            }

            catch(Exception ex)
            {
                //error message
            }

            finally

            {
                connection.Close();
            }

            return NewClientID;

        }

        static public bool UpdateClient(int ClientID, string AccountNumber, string PinCode, string FirstName, string LastName, string Phone, string Email, decimal Balance)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"UPDATE Clients
                             SET AccountNumber = @AccountNumber,
                                 PinCode = @PinCode,
                                 FirstName = @FirstName,
                                 LastName = @LastName,
                                 Phone = @Phone,
                                 Email = @Email,
                                 Balance = @Balance
                             WHERE ClientID = @ClientID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Balance", Balance);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                
            }

            catch(SqlException ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        static public bool DeleteClient(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"delete from Clients
                             where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        static public DataTable BalancesList()
        {
            DataTable dtBalances = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = "select AccountNumber,FirstName, LastName, Balance from Clients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtBalances.Load(reader);
                }

                reader.Close();

            }

            catch (Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return dtBalances;

        }

        static public decimal TotalBalances()
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = "select sum(Balance) from Clients";

            SqlCommand command = new SqlCommand(query, connection);

            decimal totalBalances = 0;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result !=null)
                {
                    totalBalances = Convert.ToDecimal(result);
                }
              
            }

            catch(Exception ex)
            {
                //errooro message
            }

            finally
            {
                connection.Close();

            }

            return totalBalances;

        }

    }
}
