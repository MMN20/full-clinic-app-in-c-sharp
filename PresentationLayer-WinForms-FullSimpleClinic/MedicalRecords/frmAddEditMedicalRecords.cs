using BusinessLayer_FullSimpleClinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_WinForms_FullSimpleClinic.MedicalRecords
{
    public partial class frmAddEditMedicalRecords : Form
    {
        enum enMode { Add,Update}
        enMode mode;
        int MedicalRecordID;
        int PatientID;
        clsMedicalRecord MR;
        clsPrescription prescription;
        public static int MR_ID = -1;

        public frmAddEditMedicalRecords(int MedicalRecordID, int PatientID)
        {

            InitializeComponent();
            if( MedicalRecordID != -1 )
            {
                mode = enMode.Update;
                this.MedicalRecordID = MedicalRecordID;
            }
            else
            {
                mode = enMode.Add;
            }
            this.PatientID = PatientID;

        }

        private void _LoadAddMode()
        {
            MR = new clsMedicalRecord();
            prescription = new clsPrescription();
            lblMedicalRecordID.Text = "???";
            lblMode.Text = "Add mode";
        }

        private void _LoadMedicalRecordData()
        {
            lblMedicalRecordID.Text = MedicalRecordID.ToString();
            lblMode.Text = "Update mode";
            txtDiagnosis.Text = MR.Diagnosis;
            txtVisitDescription.Text = MR.VisitDescription;
            txtAdditionalNotes.Text = MR.AdditionalNotes;
        }

        private void _LoadPrescriptionData()
        {
            txtMedicationName.Text = prescription.MedicationName;
            txtDosage.Text = prescription.Dosage;
            txtFrequency.Text = prescription.Frequency;
            dateTimeStartDate.Value = prescription.StartDate;
            dateTimeEndDate.Value = prescription.EndDate;
            txtSpecialInstructions.Text = prescription.SpecialInstructions;
        }

        private void _LoadUpdateMode()
        {
            MR = clsMedicalRecord.Find(MedicalRecordID);
            _LoadMedicalRecordData();
            prescription = clsPrescription.FindByMedicalRecordID(MR.ID);

            if( prescription != null )
            {
                chkEnable.Checked = true;
                _LoadPrescriptionData();
            }
            else
                prescription = new clsPrescription();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidated()
        {
            bool isValidated = true;   
            if(txtDiagnosis.Text == "")
            {
                errorProvider1.SetError(txtDiagnosis, "Must enter the diagnosis");
                isValidated = false;
            }
            
            if(chkEnable.Checked)
            {
                if(txtMedicationName.Text == "")
                {
                    errorProvider1.SetError(txtMedicationName, "Must enter the diagnosis");
                    isValidated = false;
                }
                if (txtDiagnosis.Text == "")
                {
                    errorProvider1.SetError(txtDiagnosis, "Must enter the diagnosis");
                    isValidated = false;
                }
                if(txtFrequency.Text == "")
                {
                    errorProvider1.SetError(txtFrequency, "Must enter the diagnosis");
                    isValidated = false;
                }
                
            }
            
            return isValidated;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!isValidated())
            {
                MessageBox.Show("Enter the information");
                return;
            }

            MR.Diagnosis = txtDiagnosis.Text;
            MR.VisitDescription = txtVisitDescription.Text;
            MR.AdditionalNotes = txtAdditionalNotes.Text;
            
           

           if(MR.Save())
            {
                MessageBox.Show("Saved");
                lblMode.Text = "Update mode";
                lblPatientID.Text = MR.PatientID.ToString();
                MR_ID = MR.ID;
            }

           if(chkEnable.Checked)
            {
                prescription.MedicalRecordID = MR.ID;
                prescription.MedicationName = txtMedicationName.Text;
                prescription.Dosage = txtDosage.Text;
                prescription.Frequency = txtFrequency.Text;
                prescription.StartDate = dateTimeStartDate.Value;
                prescription.EndDate = dateTimeEndDate.Value;
                prescription.SpecialInstructions = txtSpecialInstructions.Text;
                prescription.Save();
            }
           
            else if(prescription.ID != -1 && !chkEnable.Checked) // if I had the prescription and i deleted it by disabling the prescription check box
            {
                clsPrescription.Delete(prescription.ID);
            }


        }

        private void frmAddEditMedicalRecords_Load(object sender, EventArgs e)
        {
            if (mode == enMode.Add)
            {
                _LoadAddMode();
            }
            else
            {
                _LoadUpdateMode();
            }
            lblPatientID.Text = PatientID.ToString();
            MR.PatientID = PatientID;
        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            grpPrescription.Enabled = chkEnable.Checked;
        }
    }
}
