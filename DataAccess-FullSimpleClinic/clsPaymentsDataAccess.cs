using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_FullSimpleClinic
{
    public class clsPaymentsDataAccess
    {
        public static int AddPayment(DateTime date,string PaymentMethod,decimal AmountPaid,string AdditionalNotes)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into Payments values (@date,@PaymentMethod,@AmountPaid,@AdditionalNotes); select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@date", date);


            if(PaymentMethod != "")
                cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            else
                cmd.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);

            cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);
 

            int id = -1;
            try
            {
                con.Open();

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = int.Parse(result.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public static bool UpdatePayment(int ID, DateTime date, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Payments set Date = @date,PaymentMethod = @PaymentMethod,AmountPaid = @AmountPaid,AdditionalNotes = @AdditionalNotes where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.Parameters.AddWithValue("@date", date);

            if (PaymentMethod != "")
                cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            else
                cmd.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);

            cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);


            int affectedRows = 0;
            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return affectedRows > 0;
        }

        public static bool FindByID(int ID,ref DateTime date,ref string PaymentMethod,ref decimal AmountPaid,ref string AdditionalNotes)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Payments where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@date", date);

            if (PaymentMethod != "")
                cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            else
                cmd.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);

            cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);


            bool isFound = false;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    date = (DateTime)reader["Date"];
                    
                    if (reader["PaymentMethod"] != DBNull.Value)
                        PaymentMethod = (string)reader["PaymentMethod"];
                    else
                        PaymentMethod = "";

                    AmountPaid = (decimal)reader["AmountPaid"];

                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";

                    isFound = true;

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return isFound;

        }

        public static DataTable GetAllPayments()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Payments";
            SqlCommand cmd = new SqlCommand(query, con);

            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
               
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static bool Delete(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Payments where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);


            int affectedRows = 0;
            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return affectedRows > 0;
        }



    }
}
