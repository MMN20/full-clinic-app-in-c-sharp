using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsPatient : clsPerson
    {
        public int PatientID { get; set; }

        public clsPatient() : base()
        {
            PatientID = -1;
        }

        private clsPatient(int PatientID,int PersonID, string Name, DateTime DateOfBirth, string Gender, string Phone, string Email, string Address)
        {
            this.PatientID = PatientID;
            this.ID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            mode = enMode.Update;
        }

        private bool _AddPatient()
        {
            if(base.Save())
            {
             this.PatientID = clsPatientsDataAccess.AddPatient(ID);
             return this.PatientID != -1;
            }
            return false;
        }

        private bool _UpdatePatient()
        {
            return base.Save();
        }

        public new bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        return _AddPatient();
                    }
                case enMode.Update:
                    {
                        return _UpdatePatient() ;
                    }
            }
            return false;
        }

        public new static clsPatient Find(int id)
        {
                
            int PersonID = -1;
            string name = "", gender = "", phone = "", email = "", address = "";
            DateTime dateOfBirth = DateTime.MinValue;

            if(clsPatientsDataAccess.FindByID(id,ref PersonID))
            {
                if(clsPersonDataAccess.FindByID(PersonID,ref name,ref dateOfBirth,ref gender,ref phone,ref email,ref address))
                {
                    return new clsPatient(id,PersonID,name,dateOfBirth,gender,phone,email,address);
                }
            }
            return null;
                
        }

        public static clsPatient FindByName(string name)
        {
            int id = -1;   
         
            clsPerson person = clsPerson.Find(name);
            
            if(person != null)
            {
                if (clsPatientsDataAccess.FindByPersonID(ref id, person.ID))
                {
                    return new clsPatient(id,person.ID,name,person.DateOfBirth, person.Gender, person.Phone, person.Email, person.Address);
                }
            }
            
            return null;

        }

        public static new bool Delete(int id) 
        {  
            clsPatient patient = Find(id); 
            
            if(patient != null) 
            { 
                return (clsPatientsDataAccess.DeleteByID(id) && clsPersonDataAccess.Delete(patient.ID)); 
            } 
            return false; 
        } 

        public static DataTable GetAppPatients()
        {
            return clsPatientsDataAccess.GetAllDoctors();
        }

        public static bool isPatientHaveAppointments(int patientID)
        {
            return clsPatientsDataAccess.isPersonHaveAppointments(patientID);
        }
    }
}
