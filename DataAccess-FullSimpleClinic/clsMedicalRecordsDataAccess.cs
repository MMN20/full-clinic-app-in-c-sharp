using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_FullSimpleClinic
{
    public class clsMedicalRecordsDataAccess
    {
        public static int AddMedicalRecord( string VisitDescription, string Diagnosis, string AdditionalNotes,int PatientID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into MedicalRecords values (@VisitDescription,@Diagnosis,@AdditionalNotes,@PatientID); select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);



            if (VisitDescription != "")
                cmd.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            else
                cmd.Parameters.AddWithValue("@VisitDescription", DBNull.Value);

            cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

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

        public static bool UpdateMedicalRecord(int ID, string VisitDescription, string Diagnosis, string AdditionalNotes,int PatientID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update MedicalRecords set VisitDescription = @VisitDescription,Diagnosis = @Diagnosis, AdditionalNotes = @AdditionalNotes where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

 
            if (VisitDescription != "")
                cmd.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            else
                cmd.Parameters.AddWithValue("@VisitDescription", DBNull.Value);

            cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

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

        public static bool FindByID(int ID,ref string VisitDescription,ref string Diagnosis,ref string AdditionalNotes,ref int PatientID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from MedicalRecords where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@ID", ID);
 
            if (VisitDescription != "")
                cmd.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            else
                cmd.Parameters.AddWithValue("@VisitDescription", DBNull.Value);

            cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);

            if (AdditionalNotes != "")
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

            bool isFound = false;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    if (reader["VisitDescription"] != DBNull.Value)
                        VisitDescription = (string)reader["VisitDescription"];
                    else
                        VisitDescription = "";

                    Diagnosis = (string)reader["Diagnosis"];

                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";

                    PatientID = (int)reader["PatientID"];
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

        public static DataTable GetAllMedicalRecords()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from MedicalRecords";
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
            string query = "delete MedicalRecords where ID = @ID";
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

        public static bool DeleteByPatientID(int PatientID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Prescriptions where MedicalRecordID in (\r\nselect ID from MedicalRecords where PatientID = @PatientID);" +
                " delete MedicalRecords where PatientID = @PatientID;";
            
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);


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
