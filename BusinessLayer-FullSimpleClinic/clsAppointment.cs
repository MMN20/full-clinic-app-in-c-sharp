using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsAppointment
    {
        enum enMode { Add,Update}
        enMode mode;
         
        public int ID { get; set; }
        public int PatientID { get; set; }

        public int DoctorID { get; set; }
        
        public DateTime dateTime { get; set; }
        
        public byte StatusID { get; set; }
        
        public int? MedicalRecordID { get; set; }
        
        public int? PaymentID { get; set; }

        public clsAppointment()
        {
            ID = -1;
            PatientID = -1;
            DoctorID = -1;
            dateTime = DateTime.MinValue;
            StatusID = 1;
            MedicalRecordID = null;
            PaymentID = null;
            mode = enMode.Add;
        }

        private clsAppointment(int ID, int PatientID, int DoctorID, DateTime dateTime, byte StatusID, int? MedicalRecordID, int? PaymentID)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.dateTime = dateTime;
            this.StatusID = StatusID;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
            mode = enMode.Update;
        }

        private bool _AddAppointment()
        {
            this.ID = clsAppointmentsDataAccess.AddAppointment(PatientID,DoctorID,dateTime,StatusID,MedicalRecordID,PaymentID);
            return this.ID != -1;
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentsDataAccess.UpdateAppointment(ID, PatientID,DoctorID ,dateTime, StatusID,  MedicalRecordID, PaymentID);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddAppointment())
                        {
                            mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                   return _UpdateAppointment();
            }
            return false;
        }
        
        public static bool Delete(int id)
        {
            return clsAppointmentsDataAccess.Delete(id);
        }

        public static clsAppointment Find(int id)
        {
            int patientID = -1, doctorID = -1;
            byte statusID = 0;
            int? medicalRecord = null, paymentID = null;
            
            DateTime date = DateTime.MinValue;

            if(clsAppointmentsDataAccess.FindByID(id,ref patientID,ref doctorID,ref date,ref statusID,ref medicalRecord,ref paymentID))
            {
                return new clsAppointment(id,patientID,doctorID,date,statusID,medicalRecord,paymentID);
            }
            return null;
        }

        public static DataTable GetAllAppointments()
        {
            return clsAppointmentsDataAccess.GetAllAppointments();
        }

        public static bool DeleteByPatientID(int PatientID)
        {
            return clsAppointmentsDataAccess.DeleteByPatientID(PatientID);
        }

        public static bool DeleteByDoctorID(int DoctorID)
        {
            return clsAppointmentsDataAccess.DeleteByDoctorID(DoctorID);
        }

        public static bool DeleteByMedicalRecordID(int medicalRecordID)
        {
            return clsAppointmentsDataAccess.DeleteByMedicalRecordID(medicalRecordID);
        }

        public static bool DeleteByPaymentID(int paymentID)
        {
            return clsAppointmentsDataAccess.DeleteByPaymentID(paymentID);
        }
    }
}
