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

namespace PresentationLayer_WinForms_FullSimpleClinic.Patients
{
    public partial class frmAddEditPatient : Form
    {
        enum enMode { Add,Update}
        enMode mode;
        int PatientID;
        clsPatient patient;

        public frmAddEditPatient(int PatientID)
        {
            InitializeComponent();
            if(PatientID != -1)
            {
                this.PatientID = PatientID;
                _LoadUpdateAppearance();
            }
            else
            {
                _AddModeAppearance();
            }
        }

        private void _AddModeAppearance()
        {
            mode = enMode.Add;
            lblMode.Text = "Add mode";
            lblPatientID.Text = "???";
        }

        private void _LoadUpdateAppearance()
        {
            lblMode.Text = "Update mode";
            mode = enMode.Update;
        }

        private void _LoadAddMode()
        {
            _AddModeAppearance();
        }

        private void _LoadUpdateMode()
        {
            _LoadUpdateAppearance();
            patient = clsPatient.Find(PatientID);
            lblPatientID.Text = patient.PatientID.ToString();
            txtPatientName.Text = patient.Name;
            txtPatientEmail.Text = patient.Email;
            txtPatientAddress .Text = patient.Address;
            txtPatientPhone.Text = patient.Phone;
            cbMaleFemale.SelectedItem = patient.Gender;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            if(mode == enMode.Add)
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

            if (txtPatientName.Text == "")
            {
                errorProvider1.SetError(txtPatientName, "Enter a name");
                isValidated = false;
            }

            if(txtPatientEmail.Text == "")
            {
                errorProvider1.SetError(txtPatientEmail, "Enter an Email");
                isValidated = false;
            }
            
            if (txtPatientAddress.Text == "")
            {
                errorProvider1.SetError(txtPatientAddress, "Enter an address");
                isValidated = false;
            }

            if (txtPatientPhone.Text == "")
            {
                errorProvider1.SetError(txtPatientPhone, "Enter the phone");
                isValidated = false;
            }

            if(cbMaleFemale.SelectedItem.ToString() != "M" && cbMaleFemale.SelectedItem.ToString() != "F")
            {
                errorProvider1.SetError(txtPatientPhone, "Choose a gender");
                isValidated = false;
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
                patient = new clsPatient();
            patient.Name = txtPatientName.Text;
            patient.Email = txtPatientEmail.Text;
            patient.Address = txtPatientAddress.Text;
            patient.Phone = txtPatientPhone.Text;
            patient.DateOfBirth = dateTimePickerPatient.Value.Date;
            patient.Gender = cbMaleFemale.SelectedItem.ToString();
            if(patient.Save())
            {
                MessageBox.Show("Patient Saved Successfully");
                lblPatientID.Text = patient.ID.ToString();

              

                chkAddMode.Checked = false;
                chkAddMode.Visible = true;
            }
        }

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddMode.Checked)
            {
                _AddModeAppearance(); 
            }
            else
            {
                _LoadUpdateAppearance();
                lblPatientID.Text = patient.ID.ToString();
            }
        }
    }
}
