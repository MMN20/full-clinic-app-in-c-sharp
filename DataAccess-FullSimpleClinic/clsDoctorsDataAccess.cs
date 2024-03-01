using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_FullSimpleClinic
{
    public class clsDoctorsDataAccess
    {
        public static int AddDoctor(int PersonID,string Specialization)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into Doctors values (@PersonID,@Specialization); select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Specialization", Specialization);
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

        public static bool UpdateDoctor(int ID, int PersonID, string Specialization)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Doctors set PersonID = @PersonID,Specialization = @Specialization  where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Specialization", Specialization);
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

        public static bool FindByID(int ID, ref int PersonID,ref string Specialization)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Doctors where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            bool isFound = false;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    Specialization = (string)reader["Specialization"];
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

        public static bool FindByPersonID(ref int ID, int PersonID,ref string Specialization)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Doctors where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            bool isFound = false;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    Specialization = (string)reader["Specialization"];

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

        public static bool DeleteByID(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Doctors where ID = @ID";
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

        public static bool DeleteByPersonID(int PersonID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Doctors where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllDoctors()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from " +
                "Doctors inner join Persons on Doctors.PersonID = Persons.ID;";
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

        public static List<string> GetAllDoctorsNames()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select Name from " +
                "Doctors inner join Persons on Doctors.PersonID = Persons.ID;";
            SqlCommand cmd = new SqlCommand(query, con);

           List<string> names = new List<string>();

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
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
            return names;
        }

        public static bool isDoctorHaveAppointments(int DoctorID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Appointments where DoctorID = @DoctorID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

            bool isFound = false;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

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


    }
}
