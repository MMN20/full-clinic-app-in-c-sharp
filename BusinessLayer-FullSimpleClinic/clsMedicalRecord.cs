using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsMedicalRecord
    {
        enum enMode { Add,Update}
        enMode mode;

        public int ID { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }
        public int PatientID { get; set; }


        public clsMedicalRecord()
        {
            ID = -1;
            VisitDescription = "";
            Diagnosis = "";
            AdditionalNotes = "";
            PatientID = -1;
            mode = enMode.Add;

        }

        private clsMedicalRecord(int ID,string VisitDescription,string Diagnosis,string AdditionalNotes,int PatientID)
        {
            this.ID = ID;
            this.VisitDescription = VisitDescription;
            this.Diagnosis = Diagnosis;
            this.AdditionalNotes = AdditionalNotes;
            this.PatientID = PatientID;
            mode = enMode.Update;
        }

        public static clsMedicalRecord Find(int id)
        {
            string visitDescription = "", diagnosis = "", additionalNotes = "";
            int patientID = -1;
            if(clsMedicalRecordsDataAccess.FindByID(id,ref visitDescription,ref diagnosis,ref additionalNotes,ref patientID))
            {
                return new clsMedicalRecord(id, visitDescription, diagnosis, additionalNotes,patientID);
            }
            return null;
        }

        public static bool Delete(int id)
        {
            return clsMedicalRecordsDataAccess.Delete(id);
        }

        private bool _AddMedicalRecord()
        {
            this.ID = clsMedicalRecordsDataAccess.AddMedicalRecord(VisitDescription,Diagnosis,AdditionalNotes,PatientID);
            return this.ID != -1;
        }

        private bool _UpdateMedicalRecord()
        {
            return clsMedicalRecordsDataAccess.UpdateMedicalRecord(ID,VisitDescription,Diagnosis,AdditionalNotes,PatientID);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddMedicalRecord())
                        {
                        mode = enMode.Update;
                        return true;
                        }
                    }
                    return false;
                case enMode.Update:
                    {
                        return _UpdateMedicalRecord();
                    }
            }
            return false;
        }

        public static DataTable GetAllMedicalRecords()
        {
            return clsMedicalRecordsDataAccess.GetAllMedicalRecords();
        }

        public static bool DeleteByPatientID(int patientID)
        {
            // this will delete all the prescriptions associated with the Medical Records of the patientID
            return clsMedicalRecordsDataAccess.DeleteByPatientID(patientID);
        }

        

    }
}
