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

namespace PresentationLayer_WinForms_FullSimpleClinic.Appointments
{
    public partial class frmChoosePatient : Form
    {
        public int PatientID {  get; set; }

        public frmChoosePatient()
        {
            InitializeComponent();
        }


        private void _RefreshTable()
        {
            dataGridView.DataSource = clsPatient.GetAppPatients();
        }

        private void frmChoosePatient_Load(object sender, EventArgs e)
        {
            _RefreshTable();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DataGridViewCellEventArgs
        // DataGridViewCellMouseEventArgs

        private void dataGridView_RowOrCellDoubleClick(object sender, EventArgs e)
        {
            btnChoose.PerformClick();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            PatientID = (int)dataGridView.CurrentRow.Cells[0].Value;


        }
    }
}
