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

namespace PresentationLayer_WinForms_FullSimpleClinic.Payments
{
    public partial class frmPaymentsScreen : frmSideForms
    {
        public frmPaymentsScreen()
        {
            InitializeComponent();
            instance = this;
        }
        public static frmPaymentsScreen instance;
        public void RefreshTable()
        {
           dataGridView.DataSource = clsPayment.GetAllPayments();
        }

        private void frmPaymentsScreen_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPayment frm = new frmAddEditPayment(-1);
            frm.Text = "Add Payment";
            frm.ShowDialog();
            RefreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deleting a payment will delete the appointment that is\nassociated with it, If you want to update the payment then\n" +
                    " update it from the appointments screen, Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int PaymentID = (int)dataGridView.CurrentRow.Cells[0].Value;
                    clsAppointment.DeleteByPaymentID(PaymentID);

                    if (clsPayment.Delete(PaymentID))
                        MessageBox.Show("Deleted");

                    RefreshTable();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                    int PaymentID = (int)dataGridView.CurrentRow.Cells[0].Value;
                    frmAddEditPayment frm = new frmAddEditPayment(PaymentID);
                    frm.Text = "Update Payment";
                    frm.ShowDialog();
                    RefreshTable();
            }
        }
    }
}
