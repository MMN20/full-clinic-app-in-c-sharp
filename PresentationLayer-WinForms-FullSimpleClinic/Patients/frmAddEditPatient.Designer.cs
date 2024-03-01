namespace PresentationLayer_WinForms_FullSimpleClinic.Patients
{
    partial class frmAddEditPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPatient));
            this.dateTimePickerPatient = new System.Windows.Forms.DateTimePicker();
            this.txtPatientAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPatientEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPatientName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPatientPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbMaleFemale = new System.Windows.Forms.ComboBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMode = new System.Windows.Forms.Label();
            this.chkAddMode = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerPatient
            // 
            this.dateTimePickerPatient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPatient.Location = new System.Drawing.Point(163, 168);
            this.dateTimePickerPatient.Name = "dateTimePickerPatient";
            this.dateTimePickerPatient.Size = new System.Drawing.Size(117, 22);
            this.dateTimePickerPatient.TabIndex = 23;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientAddress.HintText = "";
            this.txtPatientAddress.isPassword = false;
            this.txtPatientAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientAddress.LineThickness = 3;
            this.txtPatientAddress.Location = new System.Drawing.Point(162, 321);
            this.txtPatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(187, 29);
            this.txtPatientAddress.TabIndex = 21;
            this.txtPatientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientEmail
            // 
            this.txtPatientEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientEmail.HintText = "";
            this.txtPatientEmail.isPassword = false;
            this.txtPatientEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientEmail.LineThickness = 3;
            this.txtPatientEmail.Location = new System.Drawing.Point(163, 280);
            this.txtPatientEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientEmail.Name = "txtPatientEmail";
            this.txtPatientEmail.Size = new System.Drawing.Size(186, 29);
            this.txtPatientEmail.TabIndex = 21;
            this.txtPatientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientName.HintText = "";
            this.txtPatientName.isPassword = false;
            this.txtPatientName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientName.LineThickness = 3;
            this.txtPatientName.Location = new System.Drawing.Point(163, 116);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(186, 29);
            this.txtPatientName.TabIndex = 21;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientPhone.HintText = "";
            this.txtPatientPhone.isPassword = false;
            this.txtPatientPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientPhone.LineThickness = 3;
            this.txtPatientPhone.Location = new System.Drawing.Point(163, 239);
            this.txtPatientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(186, 29);
            this.txtPatientPhone.TabIndex = 21;
            this.txtPatientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbMaleFemale
            // 
            this.cbMaleFemale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaleFemale.FormattingEnabled = true;
            this.cbMaleFemale.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbMaleFemale.Location = new System.Drawing.Point(164, 208);
            this.cbMaleFemale.Name = "cbMaleFemale";
            this.cbMaleFemale.Size = new System.Drawing.Size(39, 24);
            this.cbMaleFemale.TabIndex = 22;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(160, 86);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(22, 18);
            this.lblPatientID.TabIndex = 20;
            this.lblPatientID.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 20;
            this.label16.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Phone Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date of birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Patient ID";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Maroon;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancel.BackColor = System.Drawing.Color.White;
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
            this.btnCancel.Location = new System.Drawing.Point(19, 450);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 33);
            this.btnCancel.TabIndex = 24;
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
            this.btnSave.BackColor = System.Drawing.Color.White;
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
            this.btnSave.Location = new System.Drawing.Point(204, 450);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 33);
            this.btnSave.TabIndex = 25;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(159, 37);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(46, 18);
            this.lblMode.TabIndex = 20;
            this.lblMode.Text = "Mode";
            // 
            // chkAddMode
            // 
            this.chkAddMode.AutoSize = true;
            this.chkAddMode.Location = new System.Drawing.Point(204, 422);
            this.chkAddMode.Name = "chkAddMode";
            this.chkAddMode.Size = new System.Drawing.Size(103, 20);
            this.chkAddMode.TabIndex = 26;
            this.chkAddMode.Text = "Save as new";
            this.chkAddMode.UseVisualStyleBackColor = true;
            this.chkAddMode.Visible = false;
            this.chkAddMode.CheckedChanged += new System.EventHandler(this.chkAddMode_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 554);
            this.Controls.Add(this.chkAddMode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePickerPatient);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPatientEmail);
            this.Controls.Add(this.cbMaleFemale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPatientPhone);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPatient";
            this.Load += new System.EventHandler(this.frmAddEditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPatient;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientPhone;
        private System.Windows.Forms.ComboBox cbMaleFemale;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        public Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox chkAddMode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}