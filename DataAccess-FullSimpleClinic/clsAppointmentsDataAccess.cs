using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_FullSimpleClinic
{
    public class clsAppointmentsDataAccess
    {
        public static int AddAppointment(int PatientID,int DoctorID,DateTime dateTime, byte StatusID,int? MedicalRecordID,int? PaymentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "insert into Appointments values (@PatientID,@DoctorID,@dateTime,@StatusID,@MedicalRecordID,@PaymentID);" +
                "select scope_identity();";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@StatusID", StatusID);
           
             
            if (MedicalRecordID != null)
                cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                cmd.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

            if (PaymentID != null)
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);


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

        public static bool UpdateAppointment(int ID, int PatientID, int DoctorID, DateTime dateTime, byte StatusID, int? MedicalRecordID, int? PaymentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Appointments set PatientID = @PatientID,DoctorID = @DoctorID,dateTime = @dateTime,StatusID = @StatusID," +
                " MedicalRecordID = @MedicalRecordID,PaymentID = @PaymentID where ID = @ID;";
                
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@StatusID", StatusID);


            if (MedicalRecordID != null)
                cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                cmd.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

            if (PaymentID != null)
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);

            int affectedRows  = 0;

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

        public static bool FindByID(int ID,ref int PatientID,ref int DoctorID,ref DateTime dateTime,ref byte StatusID,
            ref int? MedicalRecordID,ref int? PaymentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Appointments where ID = @ID;";
                
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            bool isFound = false;

            try
            {
                con.Open() ;
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    PatientID = (int)reader["PatientID"];
                    DoctorID = (int)reader["DoctorID"];
                    dateTime = (DateTime)reader["DateTime"];
                    StatusID = (byte)reader["StatusID"];

                    if (reader["MedicalRecordID"] != DBNull.Value)    
                        MedicalRecordID = (int)reader["MedicalRecordID"];    
                    else    
                        MedicalRecordID = null;


                    if (reader["PaymentID"] != DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PaymentID = null;
                    isFound = true;

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
            finally
            {
                con.Close( );
            }
            return isFound;

        }

        public static bool Delete(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Appointments where ID = @ID;";
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

        public static DataTable GetAllAppointments()
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Appointments";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);


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

        public static bool DeleteByPatientID(int PatientID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Appointments where PatientID = @PatientID;";
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

        public static bool DeleteByDoctorID(int DoctorID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Appointments where DoctorID = @DoctorID;";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
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
            string query = "delete Appointments where MedicalRecordID = @MedicalRecordID;";
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

        public static bool DeleteByPaymentID(int PaymentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete Appointments where PaymentID = @PaymentID;";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
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
