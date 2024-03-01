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

namespace PresentationLayer_WinForms_FullSimpleClinic.Others
{
    public partial class frmAddEditStatus : Form
    {
        enum enMode { Add, Update }
        enMode mode;
        int statusID;
        clsAppoStatus status;

        public frmAddEditStatus(int statusID)
        {
            InitializeComponent();
            if (statusID != -1)
            {
                this.statusID =   statusID ;
                mode = enMode.Update;
            }
            else
            {
                mode = enMode.Add;
            }
        }

        private void _LoadUpdateMode()
        {
            status = clsAppoStatus.Find(statusID);
            txtName.Text = status.Name;
            txtDescription.Text = status.Description;
        }

        private void frmAddEditStatus_Load(object sender, EventArgs e)
        {
            if(mode == enMode.Update)
            {
                _LoadUpdateMode();
            }

        }

        private bool isValidated()
        {
            bool isValidated = true;

            if(txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Enter the name");
                isValidated = false;
            }
            if(txtDescription.Text == "")
            {
                errorProvider1.SetError(txtDescription, "Enter the description");
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
                status = new clsAppoStatus();

            status.Name = txtName.Text;
            status.Description = txtDescription.Text;

            if(status.Save())
            {
                MessageBox.Show("Saved Successfully");
                if(mode == enMode.Add)
                {
                    txtDescription.Text = "";
                    txtName.Text = "";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
