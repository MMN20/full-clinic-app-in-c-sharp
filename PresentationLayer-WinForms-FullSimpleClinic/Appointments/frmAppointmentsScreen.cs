using BusinessLayer_FullSimpleClinic;
using PresentationLayer_WinForms_FullSimpleClinic.MedicalRecords;
using PresentationLayer_WinForms_FullSimpleClinic.Patients;
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
    public partial class frmAppointmentsScreen : frmSideForms
    {
        public frmAppointmentsScreen()
        {
            InitializeComponent();
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = clsAppointment.GetAllAppointments();
        }

        private void frmAppointmentsScreen_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

     
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditAppointment frm = new frmAddEditAppointment(-1);
            frm.Text = "Add Appointment";
            frm.ShowDialog();
            RefreshTable();

            frmMedicalRecordsScreen frm2 = (frmMedicalRecordsScreen)Application.OpenForms["frmMedicalRecordsScreen"]; // to refresh the Medical records table
            if (frm2 != null)
                frm2.RefreshTable();

            frmPatientsScreen frm3 = (frmPatientsScreen)Application.OpenForms["frmPatientsScreen"];
            if(frm3 != null)
                frm3.RefreshTable();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
               int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                frmAddEditAppointment frm = new frmAddEditAppointment(id);
                frm.Text = "Update Appointment";
                frm.ShowDialog();
                RefreshTable();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                if(MessageBox.Show($"Are you want to delete appointment with id:{id}","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsAppointment.Delete(id);
                RefreshTable();
                }
            }
        }

        private void btnAddToMedicalRecord_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int PatientID = (int)dataGridView.CurrentRow.Cells[1].Value;
                frmAddEditMedicalRecords frm = new frmAddEditMedicalRecords(-1, PatientID);
                frm.ShowDialog();
                
                // to update the appointment with the new Medical Record Id
                int AppointmentID = (int)dataGridView.CurrentRow.Cells[0].Value;
                if(frmAddEditMedicalRecords.MR_ID != -1)
                {
                    clsAppointment app = clsAppointment.Find(AppointmentID);
                    app.MedicalRecordID = frmAddEditMedicalRecords.MR_ID;
                    app.Save();
                    RefreshTable();
                }

                frmMedicalRecordsScreen MRForm = (frmMedicalRecordsScreen)Application.OpenForms["frmMedicalRecordsScreen"];
                if(MRForm != null)
                    MRForm.RefreshTable();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
