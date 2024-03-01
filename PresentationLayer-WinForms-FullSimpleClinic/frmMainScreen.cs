using PresentationLayer_WinForms_FullSimpleClinic.Appointments;
using PresentationLayer_WinForms_FullSimpleClinic.Doctors;
using PresentationLayer_WinForms_FullSimpleClinic.MedicalRecords;
using PresentationLayer_WinForms_FullSimpleClinic.Others;
using PresentationLayer_WinForms_FullSimpleClinic.Patients;
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

namespace PresentationLayer_WinForms_FullSimpleClinic
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            instance = this;
        }

        public static frmMainScreen instance;


        // Forms
        frmAppointmentsScreen frmAppointments = new frmAppointmentsScreen();
        frmPatientsScreen frmPatients = new frmPatientsScreen();
        frmDoctorsScreen frmDoctors = new frmDoctorsScreen();
        frmMedicalRecordsScreen frmMedicalRecord = new frmMedicalRecordsScreen();
        frmPaymentsScreen frmPayments = new frmPaymentsScreen();
        frmOthersScreen frmOthers = new frmOthersScreen();
        // Forms



        private void _PutFormOnPanel(Form form)
        {
            pnlCont.Controls.Clear();
            form.TopLevel = false;
            pnlCont.Controls.Add(form);
            form.Show();

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmAppointments);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmPatients);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmDoctors);
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmAppointments);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmMedicalRecord);
        }

        private void btnPayments_Click_1(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmPayments);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            _PutFormOnPanel(frmOthers);
        }
    }
}
