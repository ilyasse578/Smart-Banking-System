using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsCurrencyData
    {
        static public DataTable CurrenciesList()
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = "select * from Currencies";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dtCurrencies = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtCurrencies.Load(reader);
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

            return dtCurrencies;

        }

        static public bool Find(string CurrencyCode, ref int CurrencyID, ref string Country, ref string CurrencyName, ref decimal rate)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"select * from Currencies
                             where CurrencyCode = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    CurrencyID = Convert.ToInt16(reader["CurrencyID"]);
                    Country = (string)reader["Country"];
                    CurrencyName = (string)reader["CurrencyName"];
                    rate = Convert.ToDecimal(reader["Rate"]);
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
    }
}
