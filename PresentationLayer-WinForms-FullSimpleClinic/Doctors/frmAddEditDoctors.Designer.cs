namespace PresentationLayer_WinForms_FullSimpleClinic.Doctors
{
    partial class frmAddEditDoctors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditDoctors));
            this.chkAddMode = new System.Windows.Forms.CheckBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDoctorAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerDoctor = new System.Windows.Forms.DateTimePicker();
            this.txtDoctorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbMaleFemale = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDoctorPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDoctorSpecialization = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAddMode
            // 
            this.chkAddMode.AutoSize = true;
            this.chkAddMode.Location = new System.Drawing.Point(201, 439);
            this.chkAddMode.Name = "chkAddMode";
            this.chkAddMode.Size = new System.Drawing.Size(103, 20);
            this.chkAddMode.TabIndex = 44;
            this.chkAddMode.Text = "Save as new";
            this.chkAddMode.UseVisualStyleBackColor = true;
            this.chkAddMode.Visible = false;
            this.chkAddMode.CheckedChanged += new System.EventHandler(this.chkAddMode_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Maroon;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Black;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(16, 467);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 33);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnSave.ActiveForecolor = System.Drawing.Color.Black;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.Black;
            this.btnSave.IdleLineColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(201, 467);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 33);
            this.btnSave.TabIndex = 43;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDoctorAddress
            // 
            this.txtDoctorAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoctorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorAddress.HintText = "";
            this.txtDoctorAddress.isPassword = false;
            this.txtDoctorAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorAddress.LineThickness = 3;
            this.txtDoctorAddress.Location = new System.Drawing.Point(159, 338);
            this.txtDoctorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorAddress.Name = "txtDoctorAddress";
            this.txtDoctorAddress.Size = new System.Drawing.Size(187, 29);
            this.txtDoctorAddress.TabIndex = 39;
            this.txtDoctorAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 31;
            this.label16.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Phone Number";
            // 
            // dateTimePickerDoctor
            // 
            this.dateTimePickerDoctor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDoctor.Location = new System.Drawing.Point(160, 185);
            this.dateTimePickerDoctor.Name = "dateTimePickerDoctor";
            this.dateTimePickerDoctor.Size = new System.Drawing.Size(117, 22);
            this.dateTimePickerDoctor.TabIndex = 41;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorName.HintText = "";
            this.txtDoctorName.isPassword = false;
            this.txtDoctorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineThickness = 3;
            this.txtDoctorName.Location = new System.Drawing.Point(160, 133);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(186, 29);
            this.txtDoctorName.TabIndex = 38;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoctorEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorEmail.HintText = "";
            this.txtDoctorEmail.isPassword = false;
            this.txtDoctorEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorEmail.LineThickness = 3;
            this.txtDoctorEmail.Location = new System.Drawing.Point(160, 297);
            this.txtDoctorEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(186, 29);
            this.txtDoctorEmail.TabIndex = 37;
            this.txtDoctorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbMaleFemale
            // 
            this.cbMaleFemale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaleFemale.FormattingEnabled = true;
            this.cbMaleFemale.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbMaleFemale.Location = new System.Drawing.Point(161, 225);
            this.cbMaleFemale.Name = "cbMaleFemale";
            this.cbMaleFemale.Size = new System.Drawing.Size(39, 24);
            this.cbMaleFemale.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 18);
            this.label15.TabIndex = 35;
            this.label15.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Name";
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoctorPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorPhone.HintText = "";
            this.txtDoctorPhone.isPassword = false;
            this.txtDoctorPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorPhone.LineThickness = 3;
            this.txtDoctorPhone.Location = new System.Drawing.Point(160, 256);
            this.txtDoctorPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.Size = new System.Drawing.Size(186, 29);
            this.txtDoctorPhone.TabIndex = 36;
            this.txtDoctorPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(156, 54);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(46, 18);
            this.lblMode.TabIndex = 30;
            this.lblMode.Text = "Mode";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(157, 103);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(22, 18);
            this.lblDoctorID.TabIndex = 29;
            this.lblDoctorID.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Doctor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date of birth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Gender";
            // 
            // txtDoctorSpecialization
            // 
            this.txtDoctorSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorSpecialization.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoctorSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorSpecialization.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorSpecialization.HintText = "";
            this.txtDoctorSpecialization.isPassword = false;
            this.txtDoctorSpecialization.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorSpecialization.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorSpecialization.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorSpecialization.LineThickness = 3;
            this.txtDoctorSpecialization.Location = new System.Drawing.Point(160, 384);
            this.txtDoctorSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorSpecialization.Name = "txtDoctorSpecialization";
            this.txtDoctorSpecialization.Size = new System.Drawing.Size(187, 29);
            this.txtDoctorSpecialization.TabIndex = 39;
            this.txtDoctorSpecialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Specialization";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 554);
            this.Controls.Add(this.chkAddMode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDoctorSpecialization);
            this.Controls.Add(this.txtDoctorAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePickerDoctor);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtDoctorEmail);
            this.Controls.Add(this.cbMaleFemale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDoctorPhone);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditDoctors";
            this.Load += new System.EventHandler(this.frmAddEditDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAddMode;
        public Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorEmail;
        private System.Windows.Forms.ComboBox cbMaleFemale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorPhone;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}