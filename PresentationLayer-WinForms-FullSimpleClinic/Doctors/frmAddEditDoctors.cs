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

namespace PresentationLayer_WinForms_FullSimpleClinic.Doctors
{
    public partial class frmAddEditDoctors : Form
    {
        enum enMode { Add,Update}
        enMode mode;
        int DoctorID;
        clsDoctor doctor;

        public frmAddEditDoctors(int DoctorID)
        {
            InitializeComponent();
            if(DoctorID != -1)
            {
                this.DoctorID = DoctorID;
                _UpdateModeAppearance();
            }
            else
            {
                _AddModeAppearance();
            }
        }

        private void _AddModeAppearance()
        {
            lblMode.Text = "Add mode";
            mode = enMode.Add;
        }

        private void _UpdateModeAppearance()
        {
            lblMode.Text = "Update mode";
            mode = enMode.Update;
        }

        private void _LoadUpdateMode()
        {
            doctor = clsDoctor.Find(DoctorID);

            if(doctor == null)
            {
                MessageBox.Show("Test");
            }

            lblDoctorID.Text = doctor.DoctorID.ToString();
            txtDoctorName.Text = doctor.Name;
            txtDoctorPhone.Text = doctor.Phone;
            txtDoctorEmail.Text = doctor.Email;
            txtDoctorAddress.Text = doctor.Address;
            cbMaleFemale.SelectedItem = doctor.Gender;
            txtDoctorSpecialization.Text = doctor.Specialization;
        }

        private void _LoadAddMode()
        {
            _AddModeAppearance();
            cbMaleFemale.SelectedIndex = 0;
        }

        private void frmAddEditDoctors_Load(object sender, EventArgs e)
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

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            _AddModeAppearance();
        }


        private bool isValidated()
        {
            bool isValidated = true;

            if(txtDoctorName.Text == "")
            {
                errorProvider1.SetError(txtDoctorName, "Enter the name");
                isValidated = false;
            }

            if(txtDoctorPhone.Text == "")
            {
                errorProvider1.SetError(txtDoctorPhone, "Enter the name");
                isValidated = false;
            }

            if (txtDoctorAddress.Text == "")
            {
                errorProvider1.SetError(txtDoctorAddress, "Enter the name");
                isValidated = false;
            }
          
            if (txtDoctorSpecialization.Text == "")
            {
                errorProvider1.SetError(txtDoctorSpecialization, "Enter the name");
                isValidated = false;
            }

            return isValidated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!isValidated())
            {
                return;
            }

            if (mode == enMode.Add)
                doctor = new clsDoctor();
            doctor.Name = txtDoctorName.Text;
            doctor.Phone = txtDoctorPhone.Text;
            doctor.Address = txtDoctorAddress.Text;
            doctor.Email = txtDoctorEmail.Text;
            doctor.DateOfBirth = dateTimePickerDoctor.Value;
            doctor.Specialization = txtDoctorSpecialization.Text;

            if (doctor.Save())
            {
                MessageBox.Show("Saved successfully");
                
                    _UpdateModeAppearance();
                    chkAddMode.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
