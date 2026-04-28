using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsLoginRegisterData
    {
        static public DataTable LoginRegistersList()
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"SELECT      LoginRegisters.Date, Users.UserName, Users.Password, Users.Permissions
                             FROM         LoginRegisters INNER JOIN
                             Users ON LoginRegisters.UserID = Users.UserID";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable LoginRegisters = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    LoginRegisters.Load(reader);

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

            return LoginRegisters;

        }

        static public int AddLoginRegister(DateTime date, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataParameters.ConnectionString);

            string query = @"insert into LoginRegisters
                             values(@date, @UserID)
                             select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("date", date);
            command.Parameters.AddWithValue("UserID", UserID);

            int LoginRegisterID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                LoginRegisterID = Convert.ToInt16(result);
            }

            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return LoginRegisterID;

        }


    }

     

}
