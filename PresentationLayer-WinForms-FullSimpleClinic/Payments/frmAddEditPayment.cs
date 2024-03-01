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
    public partial class frmAddEditPayment : Form
    {
        enum enMode { Add,Update}
        enMode mode;

        int PaymentID;
        clsPayment payment;

        public frmAddEditPayment(int PaymentID)
        {
            InitializeComponent();

            if(PaymentID != -1)
            {
               this.PaymentID = PaymentID;
                mode = enMode.Update;
            }
            else
            {
                mode = enMode.Add;
            }
        }

        private void _LoadAddMode()
        {
            lblMode.Text = "Add mode";
            payment = new clsPayment();
        }

        private void _LoadUpdateMode()
        {
            lblMode.Text = "Update mode";
            payment = clsPayment.Find(PaymentID);
            dateTimePayment.Value = payment.Date;
            txtPaymentMethod.Text = payment.PaymentMehtod;
            txtAmountPaid.Text = payment.AmountPaid.ToString();
            txtAdditionalNotes.Text = payment.AdditionalNotes;
        }

        private bool isValidated()
        {
            bool isValidated = true;
            
            if(txtAmountPaid.Text == "")
            {
                errorProvider1.SetError(txtAmountPaid, "Please enter the price");
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

            payment.Date = dateTimePayment.Value;
            payment.PaymentMehtod = txtPaymentMethod.Text;
            
            if(decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid) )
            {
                payment.AmountPaid = amountPaid;
            }
            else
            {
                MessageBox.Show("Please enter a valid Amount!");
                return;
            }
            payment.AdditionalNotes = txtAdditionalNotes.Text;

            if(payment.Save())
            {
                MessageBox.Show("Saved Successfully");
                mode = enMode.Update;
                lblMode.Text = "Update mode";
            }

        }

        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            if(mode == enMode.Update)
            {
                _LoadUpdateMode();
            }
            else
            {
                _LoadAddMode();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
