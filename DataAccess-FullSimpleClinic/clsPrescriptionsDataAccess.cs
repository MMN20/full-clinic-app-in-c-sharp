using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_FullSimpleClinic
{
    public class clsPrescriptionsDataAccess
    {

        public static int AddPrescription(int MedicalRecordID, string MedicationName,string Dosage,string Frequency,DateTime StartDate,DateTime EndDate,
            string SpecialInstructions)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into Prescriptions values (@MedicalRecordID,@MedicationName,@Dosage,@Frequency,@StartDate,@EndDate,@SpecialInstructions);" +
                " select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);

            if (SpecialInstructions != "")
                cmd.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            else
                cmd.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);

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

        public static bool UpdatePrescription(int ID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate,
            string SpecialInstructions)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Prescriptions set  MedicalRecordID = @MedicalRecordID,MedicationName = @MedicationName,Dosage = @Dosage," +
                "Frequency = @Frequency,StartDate = @StartDate,EndDate = @EndDate,SpecialInstructions = @SpecialInstructions " +
                "where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);

            if (SpecialInstructions != "")
                cmd.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            else
                cmd.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);

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

        public static bool FindByID(int ID,ref int MedicalRecordID,ref string MedicationName,ref string Dosage,ref string Frequency,ref DateTime StartDate,ref DateTime EndDate,
           ref string SpecialInstructions)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Prescriptions where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            bool isFound = false;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (string)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];

                    if (reader["SpecialInstructions"] != DBNull.Value)
                        SpecialInstructions = (string)reader["SpecialInstructions"];
                    else
                        SpecialInstructions = "";
                    
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

        public static bool FindByMedicalRecordID(ref int ID,  int MedicalRecordID, ref string MedicationName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime EndDate,
          ref string SpecialInstructions)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Prescriptions where MedicalRecordID = @MedicalRecordID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

            bool isFound = false;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (string)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];

                    if (reader["SpecialInstructions"] != DBNull.Value)
                        SpecialInstructions = (string)reader["SpecialInstructions"];
                    else
                        SpecialInstructions = "";

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

        public static DataTable GetAllPrescriptions()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Prescriptions ";
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

        public static bool DeleteByID(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Prescriptions where ID = @ID";
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

        public static bool DeleteByMedicalRecordID(int MedicalRecordID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Prescriptions where MedicalRecordID = @MedicalRecordID";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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
