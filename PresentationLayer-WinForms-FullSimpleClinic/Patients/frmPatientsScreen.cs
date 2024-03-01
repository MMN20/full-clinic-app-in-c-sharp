using BusinessLayer_FullSimpleClinic;
using PresentationLayer_WinForms_FullSimpleClinic.Appointments;
using PresentationLayer_WinForms_FullSimpleClinic.MedicalRecords;
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
    public partial class frmPatientsScreen : frmSideForms
    {
        public frmPatientsScreen()
        {
            InitializeComponent();
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = clsPatient.GetAppPatients();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frm = new frmAddEditPatient(-1);
            frm.Text = "Add Patient";
            frm.ShowDialog();
            RefreshTable();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                frmAddEditPatient frm = new frmAddEditPatient(id);
                frm.Text = "Update Patient";
                frm.ShowDialog();
                RefreshTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)   
        {   
            if (dataGridView.SelectedRows.Count > 0)   
            {
                int id = (int)dataGridView.CurrentRow.Cells[0].Value;
            
                    if (MessageBox.Show("This patient may have appointment(s) And/OR Medical Records\nand they will be deleted as well, Are you sure?","",MessageBoxButtons.YesNo) == 
                        DialogResult.Yes)
                    {
                    clsAppointment.DeleteByPatientID(id);
                    clsMedicalRecord.DeleteByPatientID(id);
                    if(clsPatient.Delete(id))
                    {
                            MessageBox.Show("Deleted successfully");
                    }
                        

                        frmAppointmentsScreen frm = (frmAppointmentsScreen)Application.OpenForms["frmAppointmentsScreen"]; // to refresh the appointments table
                        frm.RefreshTable();

                    frmMedicalRecordsScreen frm2 = (frmMedicalRecordsScreen)Application.OpenForms["frmMedicalRecordsScreen"]; // to refresh the Medical records table
                    if(frm2 != null)
                        frm2.RefreshTable();

                    }
                
                RefreshTable();
            }
        }

        private void frmPatientsScreen_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
