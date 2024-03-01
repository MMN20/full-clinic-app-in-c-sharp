using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsPrescription
    {
        enum enMode { Add,Update}
        enMode mode;

        public int ID { get; set; }
        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage {  get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }



        public clsPrescription()
        {
            this.ID = -1;
            this.MedicalRecordID = -1;
            this.MedicationName = "";
            this.Dosage = "";
            this.Frequency = "";
            this.StartDate = DateTime.Now; 
            this.EndDate = DateTime.Now;
            this.SpecialInstructions = "";
            mode = enMode.Add;
        }

        private clsPrescription(int ID,int MedicalRecordID,string MedicationName, string Dosage,string Frequency,DateTime StartDate,DateTime EndDate,string SpecialInstructions)
        {
            this.ID=ID;
            this.MedicalRecordID=MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
            mode = enMode.Update;
        }

        private bool _AddPrescription()
        {
            this.ID = clsPrescriptionsDataAccess.AddPrescription(MedicalRecordID,MedicationName,Dosage,Frequency,StartDate,EndDate,SpecialInstructions);
            return this.ID != -1;
        }

        private bool _UpdatePrescription()
        {
            return clsPrescriptionsDataAccess.UpdatePrescription(ID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddPrescription())
                        {
                            mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                  return _UpdatePrescription();
            }
            return false;   
        }

        public static clsPrescription Find(int id)
        {
            int medicalRecordID = 0;
            string medicationName = "", dosage = "", frequency = "", specialInstructions = "";
            DateTime startDate = DateTime.Now, endDate = DateTime.Now;

            if(clsPrescriptionsDataAccess.FindByID(id,ref medicalRecordID,ref medicationName,ref dosage,ref frequency,ref startDate,ref endDate,ref specialInstructions))
            {
                return new clsPrescription(id, medicalRecordID, medicationName, dosage, frequency, startDate, endDate, specialInstructions);
            }
            return null;
        }

        public static clsPrescription FindByMedicalRecordID(int medicalRecordID)
        {
            int id = 0;
            string medicationName = "", dosage = "", frequency = "", specialInstructions = "";
            DateTime startDate = DateTime.Now, endDate = DateTime.Now;

            if (clsPrescriptionsDataAccess.FindByMedicalRecordID(ref id, medicalRecordID, ref medicationName, ref dosage, ref frequency, ref startDate, ref endDate, ref specialInstructions))
            {
                return new clsPrescription(id, medicalRecordID, medicationName, dosage, frequency, startDate, endDate, specialInstructions);
            }
            return null;
        }


        public static bool Delete(int id)
        {
            return clsPrescriptionsDataAccess.DeleteByID(id);
        }

        public static bool DeleteByMedicalRecordID(int medicalRecordID)
        {
            return clsPrescriptionsDataAccess.DeleteByMedicalRecordID(medicalRecordID);
        }

        public static DataTable GetAllPrescriptions()
        {
          return  clsPrescriptionsDataAccess.GetAllPrescriptions();
        }

        
    }
}
