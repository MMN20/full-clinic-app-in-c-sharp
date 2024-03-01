using BusinessLayer_FullSimpleClinic;
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

namespace PresentationLayer_WinForms_FullSimpleClinic.Others
{
    public partial class frmStatussesScreen : frmSideForms
    {
        public frmStatussesScreen()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dataGridView.DataSource = clsAppoStatus.GetAllStatusses();
        }

        private void frmStatussesScreen_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStatus frm = new frmAddEditStatus(-1);
            frm.Text = "Add mode";
            frm.ShowDialog();
            RefreshTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int StatusID = (int)dataGridView.CurrentRow.Cells[0].Value;
                frmAddEditStatus frm = new frmAddEditStatus(StatusID);
                frm.Text = "Update mode";
                frm.ShowDialog();
                RefreshTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this status?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int StatusID = (int)dataGridView.CurrentRow.Cells[0].Value;
                   
                    if(clsAppoStatus.Delete(StatusID))
                    {
                        MessageBox.Show("Deleted successfully");

                        RefreshTable();
                    }
                    else
                    {
                        MessageBox.Show("The status has not been deleted, Delete the appointments that is assoiciated with it");
                    }
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
