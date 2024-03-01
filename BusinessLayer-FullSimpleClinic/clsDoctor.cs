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
    public class clsDoctor : clsPerson
    {

        public int DoctorID { get; set; }
        public string Specialization { get; set; }

        public clsDoctor()
        {
            DoctorID = -1;
            Specialization = "";
        }

        private clsDoctor(int doctorID, int PersonID, string specialization, string Name, DateTime DateOfBirth, string Gender, 
            string Phone, string Email, string Address)
        {
            this.DoctorID = doctorID;
            this.Specialization = specialization;
            this.ID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            mode = enMode.Update;
        }

        public new static clsDoctor Find(int id)
        {
            string specialization = "", name = "", gender = "",
            phone = "", email = "", address = "";

            int personID = -1;
            DateTime DateOfBirth = DateTime.MinValue;

            if(clsDoctorsDataAccess.FindByID(id,ref personID,ref specialization))
            {
                if(clsPersonDataAccess.FindByID(personID, ref name,ref DateOfBirth,ref gender,ref phone,ref email,ref address))
                {
                    return new clsDoctor(id, personID, specialization, name, DateOfBirth, gender, phone, email, address);
                }
            }

            return null;
        }

        private bool _AddDoctor()
        {   
            if(base.Save())
            {

            this.DoctorID = clsDoctorsDataAccess.AddDoctor(this.ID, this.Specialization);   
            return this.ID != -1;    
            }
            return false;
        }   

        private bool _UpdateDoctor()
        {
            base.Save();
            return clsDoctorsDataAccess.UpdateDoctor(this.DoctorID,this.ID,this.Specialization);
        }

        public new bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        return _AddDoctor();
                    }
                case enMode.Update:
                    {
                        return _UpdateDoctor();
                    }
            }
            return false;
        }

        public static new bool Delete(int id)
        {
            clsDoctor doc = clsDoctor.Find(id);
            if(doc != null)
            {
                if( clsDoctorsDataAccess.DeleteByID(id) && clsPersonDataAccess.Delete(doc.ID))
                    return true;
            }
            return false;
        }

        public new static clsDoctor Find(string name)
        {
            clsPerson person = clsPerson.Find(name);

            string specialization = "";

            int doctorID = -1;
            DateTime dateOfBirth = DateTime.MinValue;

            if (person != null)
            {
                if(clsDoctorsDataAccess.FindByPersonID(ref doctorID,person.ID,ref specialization))
                {
                    return new clsDoctor(doctorID, person.ID, specialization, name, person.DateOfBirth, person.Gender, person.Phone, person.Email, person.Address);
                }
            }
            return null;
        }

        public static DataTable GetAllDorctors()
        {
            return clsDoctorsDataAccess.GetAllDoctors();
        }

        public static List<string> GetAllDoctorsNames()
        {
            return clsDoctorsDataAccess.GetAllDoctorsNames();
        }

        public static bool isDoctorHaveAppointments(int DoctorID)
        {
            return clsDoctorsDataAccess.isDoctorHaveAppointments(DoctorID);
        }

    }
}
