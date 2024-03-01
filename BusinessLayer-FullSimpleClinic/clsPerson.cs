using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsPerson
    {
        protected enum enMode { Add,Update}
        protected enMode mode;

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }



        public clsPerson()
        {
            ID = -1;
            Name = "";
            DateOfBirth = DateTime.MinValue;
            Gender = "F";
            Phone = "";
            Email = "";
            Address = "";
            mode = enMode.Add;
           
        }

        private clsPerson(int ID,string Name,DateTime DateOfBirth,string Gender,string Phone,string Email,string Address)
        {
             this.ID = ID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            mode = enMode.Update;
        }

        private bool _AddPerson()
        {
            this.ID = clsPersonDataAccess.AddPerson(this.Name, this.DateOfBirth, this.Gender,this.Phone,this.Email,this.Address);
            return this.ID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.ID,Name,this.DateOfBirth,this.Gender,Phone,this.Email,this.Address);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddPerson())
                        {
                            mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return _UpdatePerson();
                    }
            }
            return false;
        }

        public static clsPerson Find(int id)
        {
            string name = "", gender = "", Phone = "", email = "", address = "";
            DateTime dateOfBirth = DateTime.MinValue;
            if(clsPersonDataAccess.FindByID(id,ref name,ref dateOfBirth,ref gender,ref Phone,ref email,ref address))
            {
                return new clsPerson(id,name,dateOfBirth,gender,Phone,email,address);
            }
            return null;

        }

        public static clsPerson Find(string name)
        {
            int id = -1;
            string  gender = "", Phone = "", email = "", address = "";
            DateTime dateOfBirth = DateTime.MinValue;
            if (clsPersonDataAccess.FindByName(ref id, name, ref dateOfBirth, ref gender, ref Phone, ref email, ref address))
            {
                return new clsPerson(id, name, dateOfBirth, gender, Phone, email, address);
            }
            return null;
        }

        public static bool Delete(int id)
        {
            return clsPersonDataAccess.Delete(id);
        }

        public static bool Delete(string name)
        {
            return clsPersonDataAccess.Delete(name);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccess.GetAllPersons();
        }


    }
}
