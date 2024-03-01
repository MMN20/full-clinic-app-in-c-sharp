using DataAccess_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FullSimpleClinic
{
    public class clsPayment
    {
        enum enMode { Add,Update}
        enMode mode;

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMehtod { get; set; }
        public decimal AmountPaid { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPayment()
        {
            ID = -1;
            Date = DateTime.Now;
            PaymentMehtod = "";
            AmountPaid = 0;
            AdditionalNotes = "";
            mode = enMode.Add;
        }

        private clsPayment(int ID,DateTime Date,string PaymentMethod,decimal AmountPaid,string AdditionalNotes)
        {
            this.ID = ID;
            this.Date = Date;
            this.PaymentMehtod = PaymentMethod;
            this.AmountPaid = AmountPaid;
            this.AdditionalNotes = AdditionalNotes;
            mode = enMode.Update;
        }

        private bool _AddPayment()
        {
            this.ID = clsPaymentsDataAccess.AddPayment(this.Date,this.PaymentMehtod,this.AmountPaid,this.AdditionalNotes);
            return this.ID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsDataAccess.UpdatePayment(this.ID, this.Date, this.PaymentMehtod, this.AmountPaid, this.AdditionalNotes);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    {
                        if(_AddPayment())
                        {
                            mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return _UpdatePayment();
                    }
            }
            return false;
        }

        public static bool Delete(int id)
        {
            return clsPaymentsDataAccess.Delete(id);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentsDataAccess.GetAllPayments();
        }

        public static clsPayment Find(int id)
        {
            DateTime date = DateTime.Now;
            string paymentMethod = "", addiotnalNotes = "";
            decimal amountPaid = 0; 
            if(clsPaymentsDataAccess.FindByID(id,ref date,ref paymentMethod,ref amountPaid,ref addiotnalNotes))
            {
                return new clsPayment(id,date,paymentMethod,amountPaid,addiotnalNotes);
            }
            return null;
        }



    }
}
