using BusinessLayer_FullSimpleClinic;
using PresentationLayer_WinForms_FullSimpleClinic.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_WinForms_FullSimpleClinic.Appointments
{

      //// Loading patient data to the form
    //        lblPatientID.Text = patient.ID.ToString();
    //        txtPatientName.Text = patient.Name;

    //        if (patient.DateOfBirth != DateTime.MinValue)
    //            dateTimePickerPatient.Value = patient.DateOfBirth;
    //        else
    //            dateTimePickerPatient.Value = new DateTime(2000, 1, 1);

    //cbMaleFemale.SelectedItem = patient.Gender;
    //        txtPatientPhone.Text = patient.Phone;
    //        txtPatientEmail.Text = patient.Email;
    //        txtPatientAddress.Text = patient.Address;

    public partial class frmAddEditAppointment : Form
    {
        enum enMode { Add,Update}
        enMode mode;
        int AppID;
        clsAppointment appointment;
        clsPatient patient;
        clsDoctor doctor = null;
        clsPayment payment = null;



        public frmAddEditAppointment(int AppID)
        {
            InitializeComponent();
            
            if(AppID != -1)
            {
                this.AppID = AppID;
                mode = enMode.Update;
            }
            else
            {
                mode = enMode.Add;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _AddModeAppearance()
        {
            lblMode.Text = "Add Mode";
            chkPatientExists.Checked = false;
            chkPatientExists.Enabled = true;
        }

        private void _UpdateModeAppearance()
        {
            lblMode.Text = "Update Mode";
            chkPatientExists.Enabled = false;
        }

        private void _LoadAllStatus()
        {
            List<string> names =  clsAppoStatus.GetAllNames();
            foreach(string name in names)
            {
               
                cbStatus.Items.Add(name);
            }

        }

        private void _LoadAllDoctorNamesInCB()
        {
           
            
        }

        private void _LoadAddMode()
        {
            _AddModeAppearance();
            cbMaleFemale.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void _LoadAppointmentData()
        {
            // Loading appiontment data to the form
            lblAppID.Text = appointment.ID.ToString();
            dateTimePickerAppointment.Value = appointment.dateTime;
            cbStatus.SelectedItem = clsAppoStatus.GetStatusName(appointment.StatusID);
        }

        private void _LoadPatientData()
        {
            // Loading patient data to the form
            lblPatientID.Text = patient.PatientID.ToString();
            txtPatientName.Text = patient.Name;

            if (patient.DateOfBirth != DateTime.MinValue)
                dateTimePickerPatient.Value = patient.DateOfBirth;
            else
                dateTimePickerPatient.Value = new DateTime(2000, 1, 1);

            cbMaleFemale.SelectedItem = patient.Gender;
            txtPatientPhone.Text = patient.Phone;
            txtPatientEmail.Text = patient.Email;
            txtPatientAddress.Text = patient.Address;
        }

       

        private void _LoadDoctorData()
        {
            // Loading Doctor data to the form
            nudDoctorID.Value = doctor.DoctorID;
            txtDoctorName.Text = doctor.Name;
            lblDateOfBirthDoctor.Text = doctor.DateOfBirth.ToString("yyyy/MM/dd");
            lblDoctorGender.Text = doctor.Gender;
            lblDoctorPhoneNumber.Text = doctor.Phone;
            txtDoctorSpecialization.Text = doctor.Specialization;
        }

        private void _LoadPaymentData()
        {
            chkEnablePayment.Checked = true;
            lblPaymentID.Text = payment.ID.ToString();
            txtAmountPaid.Text = payment.AmountPaid.ToString();
            txtPaymentMethod.Text = payment.PaymentMehtod;
            txtPaymentAdditionalNotes.Text = payment.AdditionalNotes;
        }

        private void _LoadUpdateMode()
        {
            _UpdateModeAppearance();
            appointment = clsAppointment.Find(AppID);
            if (appointment == null)
            {
                MessageBox.Show("Test");
            }

            patient = clsPatient.Find(appointment.PatientID);
            doctor = clsDoctor.Find(appointment.DoctorID);
            if (appointment.PaymentID != null)
                payment = clsPayment.Find((int)appointment.PaymentID);

            _LoadAppointmentData(); // Appointment
            _LoadPatientData(); // Patient
            _LoadDoctorData();  //Doctor
            
            if(payment != null)
                _LoadPaymentData(); // Payment
            else
                chkEnablePayment.Checked = false;

        }
        
        private void frmAddEditAppointment_Load(object sender, EventArgs e)
        {
            _LoadAllStatus();  
            _LoadAllDoctorNamesInCB();  
            
            if (mode == enMode.Add)
            {
                _LoadAddMode();
            }
            else
            {
                _LoadUpdateMode();
            }

             
        }

        private bool _isEveryThingValidated()
        {
            bool isValidated = true;
            if(txtPatientName.Text == "")
            {
                isValidated = false;
                errorProvider1.SetError(txtPatientName, "Fill");
            }

            if(cbMaleFemale.SelectedItem.ToString() != "M" && cbMaleFemale.SelectedItem.ToString() != "F")
            {
                isValidated = false;
                errorProvider1.SetError(cbMaleFemale, "Must choose");
            }

            if(txtPatientPhone.Text == "")
            {
                isValidated = false;
                errorProvider1.SetError(txtPatientPhone, "Fill");
            }

            if(txtPatientEmail.Text == "")
            {
                isValidated = false;
                errorProvider1.SetError(txtPatientEmail, "Fill");
            }


            if(txtDoctorName.Text == "")
            {
                isValidated = false;
                errorProvider1.SetError(nudDoctorID, "Must choose a doctor");
            }
            if(chkEnablePayment.Checked)
            {
                if (txtAmountPaid.Text == "")
                {
                    isValidated = false;
                    errorProvider1.SetError(txtAmountPaid, "Enter the price");
                }

            }
           

            return isValidated;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(!_isEveryThingValidated())
            {
                MessageBox.Show("You didn't provide all the informations");
                return;
            }

            if (mode == enMode.Add)
            {
                appointment = new clsAppointment();
                // if the patient is already exist in patients table then dont duplicate it

                if(!chkPatientExists.Checked)
                    patient = new clsPatient();
                else
                    patient = clsPatient.Find(int.Parse(lblPatientID.Text));

            
                if(chkEnablePayment.Checked)
                {
                    payment = new clsPayment();
                }
            }

            if (!chkPatientExists.Checked)
            {
                patient.Name = txtPatientName.Text;
                patient.DateOfBirth = dateTimePickerPatient.Value.Date;
                patient.Gender = cbMaleFemale.SelectedItem.ToString();
                patient.Phone = txtPatientPhone.Text;
                patient.Email = txtPatientEmail.Text;
                patient.Address = txtPatientAddress.Text;
                patient.Save();
               
            }

            bool isPaymentDeletedDuringUpdate = false;
            int payment_id = 0;
            if (chkEnablePayment.Checked)
            {
                if(payment == null) // in case its Update mode and the payment is not initialized
                    payment = new clsPayment();
                payment.Date = dateTimePickerPaymentDate.Value.Date;/////////////////////
                payment.PaymentMehtod = txtPaymentMethod.Text; 
                if (decimal.TryParse(txtAmountPaid.Text, out decimal result))
                {
                    payment.AmountPaid = result;
                }
                else
                {
                    errorProvider1.SetError(txtAmountPaid, "Enter a valid Amount");
                    MessageBox.Show("Enter a valid Amount");
                    return;
                }
                payment.AdditionalNotes = txtPaymentAdditionalNotes.Text;
                payment.Save();
               
            }
            else
            {
                if(payment != null) // in case we are Updating and we deleted the payment from a certain appointment 
                {
                    isPaymentDeletedDuringUpdate = true;
                    payment_id = payment.ID;
                }
                payment = null;
            }
            
            appointment.dateTime = dateTimePickerAppointment.Value.Date;
            appointment.StatusID = clsAppoStatus.getStatusID(cbStatus.SelectedItem.ToString());
            appointment.PatientID = patient.PatientID;
            appointment.DoctorID = doctor.DoctorID;
           

            if (payment != null)
                appointment.PaymentID = payment.ID;
            else
            appointment.PaymentID = null;

            if(appointment.Save())
            {
                MessageBox.Show("Appointment Saved");
                lblPatientID.Text = patient.PatientID.ToString();
            }

            if(isPaymentDeletedDuringUpdate) // we must delete the appointment reference first to aviod the conflict error 
                clsPayment.Delete(payment_id);

            frmPaymentsScreen.instance.RefreshTable();
        }

        private void chkEnablePayment_CheckedChanged(object sender, EventArgs e)
        {
            PaymentCard.Enabled = chkEnablePayment.Checked;

        }

        private void chkPatientExists_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosePatient.Enabled = chkPatientExists.Checked;
            pnlPatientData.Enabled = !chkPatientExists.Checked;
            if(!chkPatientExists.Checked)
            {
                lblPatientID.Text = "???"; 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void nudDoctorID_ValueChanged(object sender, EventArgs e)
        {
            doctor = clsDoctor.Find((int)nudDoctorID.Value);
            if (doctor != null)
            {
                _LoadDoctorData();
            }
        }

        private void btnChoosePatient_Click(object sender, EventArgs e)
        {
             frmChoosePatient frm = new frmChoosePatient();
             if(frm.ShowDialog() == DialogResult.OK)
            {
                 clsPatient patient = clsPatient.Find(frm.PatientID);

                 lblPatientID.Text = patient.PatientID.ToString();
                 txtPatientName.Text = patient.Name;

                 if (patient.DateOfBirth != DateTime.MinValue)
                     dateTimePickerPatient.Value = patient.DateOfBirth;
                 else
                     dateTimePickerPatient.Value = new DateTime(2000, 1, 1);

                 cbMaleFemale.SelectedItem = patient.Gender;
                 txtPatientPhone.Text = patient.Phone;
                 txtPatientEmail.Text = patient.Email;
                 txtPatientAddress.Text = patient.Address;
            
            }
        }
    }
}
