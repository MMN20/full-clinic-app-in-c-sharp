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
    public partial class frmMedicalRecordsScreen : Form
    {

        public frmMedicalRecordsScreen()
        {
            InitializeComponent();
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = clsMedicalRecord.GetAllMedicalRecords();
        }

        private void frmMedicalRecordsScreen_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int MedicalRecordID = (int)dataGridView.CurrentRow.Cells[0].Value;
                int PatientID = (int)dataGridView.CurrentRow.Cells["PatientID"].Value;
                frmAddEditMedicalRecords frm = new frmAddEditMedicalRecords(MedicalRecordID,PatientID);
                frm.Text = "Update Medical Record";
                frm.ShowDialog();
                RefreshTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Deleting a medical record will delete the appointment that is\nassociated with it, If you want to update the medical record\n" +
                    "then update it from the appointments screen, Are you sure?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                int MedicalRecordID = (int)dataGridView.CurrentRow.Cells[0].Value;
                clsAppointment.DeleteByMedicalRecordID(MedicalRecordID);
                
                if(clsMedicalRecord.Delete(MedicalRecordID))
                     MessageBox.Show("Deleted");

                RefreshTable();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
