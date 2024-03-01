using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess_FullSimpleClinic
{
    public class clsPersonDataAccess
    {
        public static int AddPerson(string Name,DateTime DateOfBirth,string Gender,string Phone,string Email,string Address)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into Persons values (@Name,@DateOfBirth,@Gender,@Phone,@Email,@Address);" +
                "select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            if(DateOfBirth !=  DateTime.MinValue)
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            else
                cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);

            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            
            if(Email != "")
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            cmd.Parameters.AddWithValue("@Address", Address);
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

        public static bool UpdatePerson(int ID, string Name, DateTime DateOfBirth, string Gender, string Phone, string Email, string Address)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Persons set Name = @Name,DateOfBirth= @DateOfBirth,Gender = @Gender, Phone = @Phone,Email = @Email,Address = @Address " +
                "where ID = @ID";
               
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            if (DateOfBirth != DateTime.MinValue)
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            else
                cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            
            cmd.Parameters.AddWithValue("@Address", Address);
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

        public static bool FindByID(int ID,ref string Name,ref DateTime DateOfBirth,ref string Gender,ref string Phone,ref string Email,ref string Address)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Persons where ID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            bool isFound = false;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read()) 
                {
                    Name = (string)reader["Name"];
                    
                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                    else
                        DateOfBirth = DateTime.MinValue;

                    Gender = (string)reader["Gender"];

                    
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    Address = (string)reader["Address"];

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

        public static bool FindByName(ref int ID,  string Name, ref DateTime DateOfBirth, ref string Gender, ref string Phone, ref string Email, ref string Address)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Persons where Name = @Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", Name);

            bool isFound = false;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];

                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                    else
                        DateOfBirth = DateTime.MinValue;

                    Gender = (string)reader["Gender"];


                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    Address = (string)reader["Address"];

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

        public static bool Delete(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Persons where ID = @ID";

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

        public static bool Delete(string Name)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Persons where Name = @Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", Name);
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

        public static DataTable GetAllPersons()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Persons";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);

            
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
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


    }
}
