using BusinessLayer_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentaionLayer_SimpleClinic_Console
{
    internal class Program
    {

        // Patient
        static void testAddPatient()
        {

            clsPatient patient = new clsPatient();
            patient.Name = "Test";
            patient.Address = "baghdad";
            patient.Phone = "871263";
            patient.Gender = "M";
            patient.Email = "Test";
            patient.DateOfBirth = DateTime.Now;
            if(patient.Save())
                Console.WriteLine( "Saved" );

        }

        static void testUpdatePatient()
        {
            clsPatient patient = clsPatient.Find(1);
            patient.Name = "Mustafa";
            patient.Email= "toofi@gmail.com";
            patient.Address = "Saydiya";
            patient.DateOfBirth = new DateTime(2000, 6, 18);
            patient.Phone = "0750670";
            if(patient.Save() )
                Console.WriteLine("Updated");
        }

        static void testDeletePatient()
        {
            if(clsPatient.Delete(4))
                Console.WriteLine("deleted");
        }
        // Patient


        // Doctor
        static void testAddDoctor()
        {
            clsDoctor doc = new clsDoctor()
            {
                Name = "MMN",
                Address = "Baghdad",
                DateOfBirth = DateTime.Now,
                Gender = "M",
                Phone = "918273",
                Specialization = "TOMATO"
            };

            if(doc.Save() )
                Console.WriteLine("Added");

        }

        static void testUpdateDoctor()
        {
            
            clsDoctor doc = clsDoctor.Find(15);
            doc.DateOfBirth = DateTime.Now;
            doc.Name = "TEEEEEEEEEEEEEEST";
            if(doc.Save())
            {
                Console.WriteLine("asdadasd");
            }
            
        }

        static void testDeleteDoctor()
        {
            if(clsDoctor.Delete(3))
                Console.WriteLine("deleted");
        }
        
        static void testGetAllDoctors()
        {
            DataTable dt = clsDoctor.GetAllDorctors();

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3] + "\t" + row[4] + "\t" + row[5] + "\t" + row[6] + "\t" + row[7] + "\t" + row[8] + "\n" );
            }

        }
        // Doctor


        // Appointments
        static void testAddAppointment()
        {
            clsAppointment app = new clsAppointment() { MedicalRecordID = null, dateTime = DateTime.Now, DoctorID = 1, PatientID = 1, PaymentID = null, StatusID = 1 };
            if(app.Save())
                Console.WriteLine("Added");
            app.dateTime = new DateTime(2000, 6, 18);
            app.MedicalRecordID = 11;
            app.Save();
        }

        static void testDeleteAppointment()
        {
            if(clsAppointment.Delete(1))  
                Console.WriteLine("deleted");  
        } 

        static void testUpdateAppointment()
        {
            clsAppointment app = clsAppointment.Find(6);
            app.PatientID = 11;
            app.DoctorID = 11;
            app.PatientID = 11
;           app.dateTime =   DateTime.Now;
            app.MedicalRecordID = 11;
            app.StatusID = 11;
            app.Save();
        }

        static void testGetAllAppointments()
        {
            DataTable dt = clsAppointment.GetAllAppointments();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3] + "\t" + row[4] + "\t" + row[5] + "\t" + row[6] + "\n");
            }

        }
        // Appointments

        

        // AppoStatus
        static void testAddStatus()
        {
            clsAppoStatus s = new clsAppoStatus();
            s.Name = "Test";
            s.Description = "teeeeeeeeeeeeeeest";
            if(s.Save())
                Console.WriteLine("Saved");
        }

        static void testUpdateStatus()
        {
            clsAppoStatus s = clsAppoStatus.Find(1);
            s.Name = "Arrived";
            if(s.Save() )
                Console.WriteLine("Updated");
        }

        static void testDeleteByIDStatus()
        {
            if(clsAppoStatus.Delete("test"))
                Console.WriteLine("Deleted");
        }
        // AppoStatus


        // Payments
        static void testAddPayment()
        {
            clsPayment p = new clsPayment();
            p.Date = DateTime.Now;
            p.AmountPaid = 30000;
            p.PaymentMehtod = "Cash";
            if(p.Save())
                Console.WriteLine("Added");
        }

        static void testUpdatePayment()
        {
            clsPayment p = clsPayment.Find(1);
            p.AmountPaid = 999999;
            p.AdditionalNotes = "This is from Allah";
            p.PaymentMehtod = "Gold";
            if (p.Save())
                Console.WriteLine("Updated");
        }

        static void testDeletePayment()
        {
            if(clsPayment.Delete(2))
                Console.WriteLine("Deleted");
        }

        static void testGetAllPayments()
        {
            DataTable dt = clsPayment.GetAllPayments();

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]+"\n");
            }
        }
        // Payments


        // MedicalRecords
        static void testAddMedicalRecord()
        {
            clsMedicalRecord m = new clsMedicalRecord();
            m.Diagnosis = "ma be she";
            if(m.Save())
                Console.WriteLine("Added");
        }

        static void testUpdateMedicalRecord()
        {
            clsMedicalRecord m = clsMedicalRecord.Find(1);
            m.Diagnosis = "طلع مريض";
            m.Save();
        }

        static void testDeleteMedicalRecord()
        {
            if(clsMedicalRecord.Delete(1))
                Console.WriteLine("Deleted");
        }
        // MedicalRecords


        // Prescription
        static void testAddPrescription()
        {
            clsPrescription p =new clsPrescription() {MedicalRecordID = 1,Dosage = "asd",EndDate = DateTime.Now.AddDays(4) ,StartDate = DateTime.Now,Frequency = "asd"
            ,MedicationName = "asd",SpecialInstructions = "asd"};
            if(p.Save())
                Console.WriteLine("Added");

        }
        static void testUpdatePrescription()
        {
            clsPrescription p = clsPrescription.Find(1);
            p.Dosage = "Every day";
            if(p.Save())
                Console.WriteLine("Update");
        }
        static void testDeletePrescription()
        {
            if(clsPrescription.Delete(1))
                Console.WriteLine("Deleted");
        }



        static void Main(string[] args)
        {
            //  testAddStatus();

            testUpdateDoctor();

             Console.ReadKey();

        }
    }
}
