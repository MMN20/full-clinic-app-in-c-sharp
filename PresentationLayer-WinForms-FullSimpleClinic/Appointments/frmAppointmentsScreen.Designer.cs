namespace PresentationLayer_WinForms_FullSimpleClinic.Appointments
{
    partial class frmAppointmentsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentsScreen));
            this.btnAddToMedicalRecord = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label1
            // 
            this.label1.Text = "Appointments";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddToMedicalRecord
            // 
            this.btnAddToMedicalRecord.ActiveBorderThickness = 1;
            this.btnAddToMedicalRecord.ActiveCornerRadius = 20;
            this.btnAddToMedicalRecord.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnAddToMedicalRecord.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAddToMedicalRecord.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnAddToMedicalRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddToMedicalRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToMedicalRecord.BackgroundImage")));
            this.btnAddToMedicalRecord.ButtonText = "Add to Medical Record";
            this.btnAddToMedicalRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToMedicalRecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToMedicalRecord.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddToMedicalRecord.IdleBorderThickness = 1;
            this.btnAddToMedicalRecord.IdleCornerRadius = 20;
            this.btnAddToMedicalRecord.IdleFillColor = System.Drawing.Color.White;
            this.btnAddToMedicalRecord.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddToMedicalRecord.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddToMedicalRecord.Location = new System.Drawing.Point(53, 77);
            this.btnAddToMedicalRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToMedicalRecord.Name = "btnAddToMedicalRecord";
            this.btnAddToMedicalRecord.Size = new System.Drawing.Size(275, 44);
            this.btnAddToMedicalRecord.TabIndex = 21;
            this.btnAddToMedicalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToMedicalRecord.Click += new System.EventHandler(this.btnAddToMedicalRecord_Click);
            // 
            // frmAppointmentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 653);
            this.Controls.Add(this.btnAddToMedicalRecord);
            this.Name = "frmAppointmentsScreen";
            this.Text = "frmAppointmentsScreen";
            this.Load += new System.EventHandler(this.frmAppointmentsScreen_Load);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAddToMedicalRecord, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddToMedicalRecord;
    }
}