using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsAppoStatus
    {
        enum enMode { Add,Update}
        enMode mode;

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public clsAppoStatus()
        {
            ID = -1;
            Name = "";
            Description = "";
            mode = enMode.Add;
        }

        private clsAppoStatus(int id,string name,string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            mode = enMode.Update;
        }

        public static clsAppoStatus Find(int id)
        {
            string name = "", description = "";
            if(clsAppoStatusDataAccess.FindByID(id,ref name,ref description))
            {
                return new clsAppoStatus(id,name,description);  
            }
            return null;
        }

        private bool _AddStatus()
        {
            this.ID = clsAppoStatusDataAccess.AddStatus(Name,Description);
            return this.ID != -1;
        }

        private bool _UpdateStatus()
        {
            return clsAppoStatusDataAccess.UpdateStatus(ID,Name,Description);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddStatus())
                        {
                            mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateStatus();
                    }
            }
            return false;
        }

        public static bool Delete(int id)
        {
            return clsAppoStatusDataAccess.DeleteByID(id);
        }

        public static bool Delete(string Name)
        {
            return clsAppoStatusDataAccess.DeleteByName(Name);
        }
        
        public static List<string> GetAllNames()
        {
            return clsAppoStatusDataAccess.GetAllStatusNames();
        }

        public static DataTable GetAllStatusses()
        {
            return clsAppoStatusDataAccess.GetAllStatusses();
        }

        public static string GetStatusName(short statusID)
        {
            return clsAppoStatusDataAccess.GetStatusName(statusID);
        }

        public static byte getStatusID(string statusName)
        {
            int id = -1;
            string desc = "";
            clsAppoStatusDataAccess.FindByName(ref id, statusName, ref desc);
              return (byte)id;
        }


    }
}
