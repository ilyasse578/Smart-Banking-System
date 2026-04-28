using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsTransactionData
    {
        static public DataTable TransactionsList()
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = "select * from Transactions";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dtTransactions = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTransactions.Load(reader);
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

            return dtTransactions;

        }

        static public bool FindByTransactionID(int TransactionID, ref int ClientID, ref int UserID, ref int TransactionTypeID, ref decimal Amount)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"select * from Transactions
                             where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;

                    ClientID = Convert.ToInt16(reader["ClientID"]);
                    UserID = Convert.ToInt16(reader["UserID"]);
                    TransactionTypeID = Convert.ToInt16(reader["TransactionTypeID"]);
                    Amount = Convert.ToDecimal(reader["Amount"]);
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

        static public bool FindByClientID(int ClientID, ref int TransactionID, ref int UserID, ref int TransactionTypeID, ref decimal Amount)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"SELECT      Transactions.*
                             FROM         Clients INNER JOIN
                                                Transactions ON Clients.ClientID = Transactions.ClientID
                             where Clients.ClientID = @ClientID";

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

                    TransactionID = Convert.ToInt16(reader["TransactionID"]);
                    UserID = Convert.ToInt16(reader["UserID"]);
                    TransactionTypeID = Convert.ToInt16(reader["TransactionTypeID"]);
                    Amount = Convert.ToDecimal(reader["Amount"]);
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

        static public bool FindByUserID(int UserID, ref int TransactionID, ref int ClientID, ref int TransactionTypeID, ref decimal Amount)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"SELECT      Transactions.*
                             FROM         Users INNER JOIN
                                                Transactions ON Users.UserID = Transactions.UserID
                             WHERE Users.UserID =@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;

                    TransactionID = Convert.ToInt16(reader["TransactionID"]);
                    ClientID = Convert.ToInt16(reader["ClientID"]);
                    TransactionTypeID = Convert.ToInt16(reader["TransactionTypeID"]);
                    Amount = Convert.ToDecimal(reader["Amount"]);
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

        static public int AddNewTransaction(int ClientID, int UserID, int TransactionTypeID, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"insert into Transactions
                             values(@ClientID, @UserID, @TransactionTypeID, @Amount)
                             select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);

            int NewTransactionID = -1;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                NewTransactionID = Convert.ToInt16(result);

            }

            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return NewTransactionID;


        }

        static public bool UpdateTransaction(int ClientID, int UserID, int TransactionTypeID, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"UPDATE Transactions
                             SET ClientID = @ClientID,
                                 UserID = @UserID,
                                 TransactionTypeID = @TransactionTypeID,
                                 Amount = @Amount ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close() ;
            }

            return rowsAffected > 0;

        }

        static public bool Delete(int TransactionID)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"Delete from Transactions
                             where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch( Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;

        }

    }
}
