using BusinessLayer_FullSimpleClinic;
using PresentationLayer_WinForms_FullSimpleClinic.Appointments;
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

namespace PresentationLayer_WinForms_FullSimpleClinic.Doctors
{
    public partial class frmDoctorsScreen : frmSideForms
    {
 
      
        

        public frmDoctorsScreen()
        {
            InitializeComponent();
        }

        private void _RefreshTable()
        {
            dataGridView.DataSource = clsDoctor.GetAllDorctors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditDoctors frm = new frmAddEditDoctors(-1);
            frm.Text = "Add Doctor";
            frm.ShowDialog();
            _RefreshTable();
        }

        private void frmDoctorsScreen_Load(object sender, EventArgs e)
        {
            _RefreshTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                frmAddEditDoctors frm = new frmAddEditDoctors(id);
                frm.Text = "Update Doctor";
                frm.ShowDialog();
                _RefreshTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                if(clsDoctor.isDoctorHaveAppointments(id))
                {
                    if (MessageBox.Show($"This doctor is already have appointment(s)\nDo you want to delete it and its appointments too?", "", MessageBoxButtons.YesNo) ==
                         DialogResult.Yes)
                    {
                        if(clsAppointment.DeleteByDoctorID(id) && clsDoctor.Delete(id))
                            MessageBox.Show("Deleted successfully");

                        frmAppointmentsScreen frm = (frmAppointmentsScreen)Application.OpenForms["frmAppointmentsScreen"]; // to refresh the appointments table
                        frm.RefreshTable();
                    }
                    
                }
                else
                {
                    if (MessageBox.Show($"are you sure you want to delete doctor with id:{id}?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        clsDoctor.Delete(id);
                    }


                }

                _RefreshTable();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshTable();
        }
    }
}
