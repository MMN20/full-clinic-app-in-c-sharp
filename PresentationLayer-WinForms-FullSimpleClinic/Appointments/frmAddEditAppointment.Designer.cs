namespace PresentationLayer_WinForms_FullSimpleClinic.Appointments
{
    partial class frmAddEditAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAppointment));
            this.CardAppointment = new Bunifu.Framework.UI.BunifuCards();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblAppID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnChoosePatient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPatientData = new System.Windows.Forms.Panel();
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
            this.chkPatientExists = new System.Windows.Forms.CheckBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentCard = new Bunifu.Framework.UI.BunifuCards();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPaymentAdditionalNotes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDoctorPhone = new Bunifu.Framework.UI.BunifuCards();
            this.nudDoctorID = new System.Windows.Forms.NumericUpDown();
            this.txtDoctorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorSpecialization = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDoctorPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDateOfBirthDoctor = new System.Windows.Forms.Label();
            this.lblDoctorGender = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.chkEnablePayment = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CardAppointment.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlPatientData.SuspendLayout();
            this.PaymentCard.SuspendLayout();
            this.txtDoctorPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoctorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardAppointment
            // 
            this.CardAppointment.BackColor = System.Drawing.Color.White;
            this.CardAppointment.BorderRadius = 5;
            this.CardAppointment.BottomSahddow = true;
            this.CardAppointment.color = System.Drawing.Color.Tomato;
            this.CardAppointment.Controls.Add(this.cbStatus);
            this.CardAppointment.Controls.Add(this.dateTimePickerAppointment);
            this.CardAppointment.Controls.Add(this.lblAppID);
            this.CardAppointment.Controls.Add(this.label10);
            this.CardAppointment.Controls.Add(this.label8);
            this.CardAppointment.Controls.Add(this.label6);
            this.CardAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CardAppointment.LeftSahddow = false;
            this.CardAppointment.Location = new System.Drawing.Point(512, 419);
            this.CardAppointment.Name = "CardAppointment";
            this.CardAppointment.RightSahddow = true;
            this.CardAppointment.ShadowDepth = 20;
            this.CardAppointment.Size = new System.Drawing.Size(288, 156);
            this.CardAppointment.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(90, 87);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(181, 28);
            this.cbStatus.TabIndex = 22;
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(90, 52);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(181, 26);
            this.dateTimePickerAppointment.TabIndex = 21;
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAppID.Location = new System.Drawing.Point(97, 21);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(36, 20);
            this.lblAppID.TabIndex = 20;
            this.lblAppID.Text = "???";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "DateTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Lime;
            this.bunifuCards2.Controls.Add(this.btnChoosePatient);
            this.bunifuCards2.Controls.Add(this.pnlPatientData);
            this.bunifuCards2.Controls.Add(this.chkPatientExists);
            this.bunifuCards2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(42, 79);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(758, 311);
            this.bunifuCards2.TabIndex = 2;
            // 
            // btnChoosePatient
            // 
            this.btnChoosePatient.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnChoosePatient.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChoosePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoosePatient.BorderRadius = 0;
            this.btnChoosePatient.ButtonText = "Choose";
            this.btnChoosePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePatient.DisabledColor = System.Drawing.Color.Gray;
            this.btnChoosePatient.Enabled = false;
            this.btnChoosePatient.ForeColor = System.Drawing.Color.Black;
            this.btnChoosePatient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChoosePatient.Iconimage = null;
            this.btnChoosePatient.Iconimage_right = null;
            this.btnChoosePatient.Iconimage_right_Selected = null;
            this.btnChoosePatient.Iconimage_Selected = null;
            this.btnChoosePatient.IconMarginLeft = 0;
            this.btnChoosePatient.IconMarginRight = 0;
            this.btnChoosePatient.IconRightVisible = true;
            this.btnChoosePatient.IconRightZoom = 0D;
            this.btnChoosePatient.IconVisible = true;
            this.btnChoosePatient.IconZoom = 90D;
            this.btnChoosePatient.IsTab = false;
            this.btnChoosePatient.Location = new System.Drawing.Point(525, 67);
            this.btnChoosePatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoosePatient.Name = "btnChoosePatient";
            this.btnChoosePatient.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnChoosePatient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChoosePatient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChoosePatient.selected = false;
            this.btnChoosePatient.Size = new System.Drawing.Size(167, 29);
            this.btnChoosePatient.TabIndex = 27;
            this.btnChoosePatient.Text = "Choose";
            this.btnChoosePatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChoosePatient.Textcolor = System.Drawing.Color.White;
            this.btnChoosePatient.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePatient.Click += new System.EventHandler(this.btnChoosePatient_Click);
            // 
            // pnlPatientData
            // 
            this.pnlPatientData.Controls.Add(this.dateTimePickerPatient);
            this.pnlPatientData.Controls.Add(this.txtPatientAddress);
            this.pnlPatientData.Controls.Add(this.txtPatientEmail);
            this.pnlPatientData.Controls.Add(this.txtPatientName);
            this.pnlPatientData.Controls.Add(this.txtPatientPhone);
            this.pnlPatientData.Controls.Add(this.cbMaleFemale);
            this.pnlPatientData.Controls.Add(this.lblPatientID);
            this.pnlPatientData.Controls.Add(this.label16);
            this.pnlPatientData.Controls.Add(this.label15);
            this.pnlPatientData.Controls.Add(this.label14);
            this.pnlPatientData.Controls.Add(this.label13);
            this.pnlPatientData.Controls.Add(this.label7);
            this.pnlPatientData.Controls.Add(this.label11);
            this.pnlPatientData.Controls.Add(this.label9);
            this.pnlPatientData.Location = new System.Drawing.Point(13, 16);
            this.pnlPatientData.Name = "pnlPatientData";
            this.pnlPatientData.Size = new System.Drawing.Size(441, 292);
            this.pnlPatientData.TabIndex = 26;
            // 
            // dateTimePickerPatient
            // 
            this.dateTimePickerPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerPatient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPatient.Location = new System.Drawing.Point(157, 74);
            this.dateTimePickerPatient.Name = "dateTimePickerPatient";
            this.dateTimePickerPatient.Size = new System.Drawing.Size(151, 26);
            this.dateTimePickerPatient.TabIndex = 23;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientAddress.HintText = "";
            this.txtPatientAddress.isPassword = false;
            this.txtPatientAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientAddress.LineThickness = 4;
            this.txtPatientAddress.Location = new System.Drawing.Point(160, 242);
            this.txtPatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(265, 29);
            this.txtPatientAddress.TabIndex = 21;
            this.txtPatientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientEmail
            // 
            this.txtPatientEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientEmail.HintText = "";
            this.txtPatientEmail.isPassword = false;
            this.txtPatientEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientEmail.LineThickness = 4;
            this.txtPatientEmail.Location = new System.Drawing.Point(157, 191);
            this.txtPatientEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientEmail.Name = "txtPatientEmail";
            this.txtPatientEmail.Size = new System.Drawing.Size(265, 41);
            this.txtPatientEmail.TabIndex = 21;
            this.txtPatientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientName.HintText = "";
            this.txtPatientName.isPassword = false;
            this.txtPatientName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientName.LineThickness = 1;
            this.txtPatientName.Location = new System.Drawing.Point(157, 23);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(265, 29);
            this.txtPatientName.TabIndex = 21;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientPhone.HintText = "";
            this.txtPatientPhone.isPassword = false;
            this.txtPatientPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPatientPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatientPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPatientPhone.LineThickness = 4;
            this.txtPatientPhone.Location = new System.Drawing.Point(157, 154);
            this.txtPatientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(265, 29);
            this.txtPatientPhone.TabIndex = 21;
            this.txtPatientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbMaleFemale
            // 
            this.cbMaleFemale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaleFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMaleFemale.FormattingEnabled = true;
            this.cbMaleFemale.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbMaleFemale.Location = new System.Drawing.Point(157, 119);
            this.cbMaleFemale.Name = "cbMaleFemale";
            this.cbMaleFemale.Size = new System.Drawing.Size(60, 28);
            this.cbMaleFemale.TabIndex = 22;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientID.Location = new System.Drawing.Point(153, 3);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(26, 20);
            this.lblPatientID.TabIndex = 20;
            this.lblPatientID.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 20;
            this.label16.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Phone Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date of birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID";
            // 
            // chkPatientExists
            // 
            this.chkPatientExists.AutoSize = true;
            this.chkPatientExists.Location = new System.Drawing.Point(525, 16);
            this.chkPatientExists.Name = "chkPatientExists";
            this.chkPatientExists.Size = new System.Drawing.Size(116, 24);
            this.chkPatientExists.TabIndex = 22;
            this.chkPatientExists.Text = "Patient Exist";
            this.chkPatientExists.UseVisualStyleBackColor = true;
            this.chkPatientExists.CheckedChanged += new System.EventHandler(this.chkPatientExists_CheckedChanged);
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
            this.btnCancel.Location = new System.Drawing.Point(504, 674);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(704, 674);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 39);
            this.btnSave.TabIndex = 19;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(508, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Appointment Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patient Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(827, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Doctor Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(38, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Payment Info";
            // 
            // PaymentCard
            // 
            this.PaymentCard.BackColor = System.Drawing.Color.White;
            this.PaymentCard.BorderRadius = 5;
            this.PaymentCard.BottomSahddow = true;
            this.PaymentCard.color = System.Drawing.Color.Gold;
            this.PaymentCard.Controls.Add(this.dateTimePickerPaymentDate);
            this.PaymentCard.Controls.Add(this.label25);
            this.PaymentCard.Controls.Add(this.txtPaymentAdditionalNotes);
            this.PaymentCard.Controls.Add(this.label24);
            this.PaymentCard.Controls.Add(this.txtAmountPaid);
            this.PaymentCard.Controls.Add(this.label12);
            this.PaymentCard.Controls.Add(this.txtPaymentMethod);
            this.PaymentCard.Controls.Add(this.label20);
            this.PaymentCard.Controls.Add(this.lblPaymentID);
            this.PaymentCard.Controls.Add(this.label21);
            this.PaymentCard.Enabled = false;
            this.PaymentCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PaymentCard.LeftSahddow = false;
            this.PaymentCard.Location = new System.Drawing.Point(42, 419);
            this.PaymentCard.Name = "PaymentCard";
            this.PaymentCard.RightSahddow = true;
            this.PaymentCard.ShadowDepth = 20;
            this.PaymentCard.Size = new System.Drawing.Size(454, 216);
            this.PaymentCard.TabIndex = 2;
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(143, 54);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(181, 26);
            this.dateTimePickerPaymentDate.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(10, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 18);
            this.label25.TabIndex = 20;
            this.label25.Text = "AdditionalNotes";
            // 
            // txtPaymentAdditionalNotes
            // 
            this.txtPaymentAdditionalNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentAdditionalNotes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaymentAdditionalNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaymentAdditionalNotes.HintForeColor = System.Drawing.Color.Empty;
            this.txtPaymentAdditionalNotes.HintText = "";
            this.txtPaymentAdditionalNotes.isPassword = false;
            this.txtPaymentAdditionalNotes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPaymentAdditionalNotes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPaymentAdditionalNotes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPaymentAdditionalNotes.LineThickness = 3;
            this.txtPaymentAdditionalNotes.Location = new System.Drawing.Point(143, 154);
            this.txtPaymentAdditionalNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAdditionalNotes.Name = "txtPaymentAdditionalNotes";
            this.txtPaymentAdditionalNotes.Size = new System.Drawing.Size(295, 29);
            this.txtPaymentAdditionalNotes.TabIndex = 21;
            this.txtPaymentAdditionalNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 18);
            this.label24.TabIndex = 20;
            this.label24.Text = "AmountPaid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountPaid.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmountPaid.HintText = "";
            this.txtAmountPaid.isPassword = false;
            this.txtAmountPaid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAmountPaid.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAmountPaid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAmountPaid.LineThickness = 3;
            this.txtAmountPaid.Location = new System.Drawing.Point(143, 118);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(295, 29);
            this.txtAmountPaid.TabIndex = 21;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Method";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaymentMethod.HintForeColor = System.Drawing.Color.Empty;
            this.txtPaymentMethod.HintText = "";
            this.txtPaymentMethod.isPassword = false;
            this.txtPaymentMethod.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPaymentMethod.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPaymentMethod.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPaymentMethod.LineThickness = 3;
            this.txtPaymentMethod.Location = new System.Drawing.Point(143, 81);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(295, 29);
            this.txtPaymentMethod.TabIndex = 21;
            this.txtPaymentMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 18);
            this.label20.TabIndex = 20;
            this.label20.Text = "Date";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(140, 21);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(22, 18);
            this.lblPaymentID.TabIndex = 20;
            this.lblPaymentID.Text = "ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "ID";
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.BackColor = System.Drawing.Color.White;
            this.txtDoctorPhone.BorderRadius = 5;
            this.txtDoctorPhone.BottomSahddow = true;
            this.txtDoctorPhone.color = System.Drawing.Color.Lime;
            this.txtDoctorPhone.Controls.Add(this.nudDoctorID);
            this.txtDoctorPhone.Controls.Add(this.txtDoctorName);
            this.txtDoctorPhone.Controls.Add(this.txtDoctorSpecialization);
            this.txtDoctorPhone.Controls.Add(this.lblDoctorPhoneNumber);
            this.txtDoctorPhone.Controls.Add(this.lblDateOfBirthDoctor);
            this.txtDoctorPhone.Controls.Add(this.lblDoctorGender);
            this.txtDoctorPhone.Controls.Add(this.label22);
            this.txtDoctorPhone.Controls.Add(this.label27);
            this.txtDoctorPhone.Controls.Add(this.label28);
            this.txtDoctorPhone.Controls.Add(this.label29);
            this.txtDoctorPhone.Controls.Add(this.label30);
            this.txtDoctorPhone.Controls.Add(this.label31);
            this.txtDoctorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDoctorPhone.LeftSahddow = false;
            this.txtDoctorPhone.Location = new System.Drawing.Point(831, 79);
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.RightSahddow = true;
            this.txtDoctorPhone.ShadowDepth = 20;
            this.txtDoctorPhone.Size = new System.Drawing.Size(566, 311);
            this.txtDoctorPhone.TabIndex = 2;
            // 
            // nudDoctorID
            // 
            this.nudDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDoctorID.Location = new System.Drawing.Point(160, 61);
            this.nudDoctorID.Name = "nudDoctorID";
            this.nudDoctorID.Size = new System.Drawing.Size(52, 26);
            this.nudDoctorID.TabIndex = 23;
            this.nudDoctorID.ValueChanged += new System.EventHandler(this.nudDoctorID_ValueChanged);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorName.HintText = "";
            this.txtDoctorName.isPassword = false;
            this.txtDoctorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineThickness = 1;
            this.txtDoctorName.Location = new System.Drawing.Point(159, 85);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(254, 29);
            this.txtDoctorName.TabIndex = 21;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoctorSpecialization
            // 
            this.txtDoctorSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorSpecialization.Enabled = false;
            this.txtDoctorSpecialization.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorSpecialization.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorSpecialization.HintText = "";
            this.txtDoctorSpecialization.isPassword = false;
            this.txtDoctorSpecialization.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorSpecialization.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorSpecialization.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorSpecialization.LineThickness = 4;
            this.txtDoctorSpecialization.Location = new System.Drawing.Point(159, 220);
            this.txtDoctorSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorSpecialization.Name = "txtDoctorSpecialization";
            this.txtDoctorSpecialization.Size = new System.Drawing.Size(254, 38);
            this.txtDoctorSpecialization.TabIndex = 21;
            this.txtDoctorSpecialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDoctorPhoneNumber
            // 
            this.lblDoctorPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDoctorPhoneNumber.Enabled = false;
            this.lblDoctorPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDoctorPhoneNumber.HintForeColor = System.Drawing.Color.Empty;
            this.lblDoctorPhoneNumber.HintText = "";
            this.lblDoctorPhoneNumber.isPassword = false;
            this.lblDoctorPhoneNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.lblDoctorPhoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.lblDoctorPhoneNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lblDoctorPhoneNumber.LineThickness = 4;
            this.lblDoctorPhoneNumber.Location = new System.Drawing.Point(160, 185);
            this.lblDoctorPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblDoctorPhoneNumber.Name = "lblDoctorPhoneNumber";
            this.lblDoctorPhoneNumber.Size = new System.Drawing.Size(253, 29);
            this.lblDoctorPhoneNumber.TabIndex = 21;
            this.lblDoctorPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDateOfBirthDoctor
            // 
            this.lblDateOfBirthDoctor.AutoSize = true;
            this.lblDateOfBirthDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateOfBirthDoctor.Location = new System.Drawing.Point(156, 129);
            this.lblDateOfBirthDoctor.Name = "lblDateOfBirthDoctor";
            this.lblDateOfBirthDoctor.Size = new System.Drawing.Size(36, 20);
            this.lblDateOfBirthDoctor.TabIndex = 20;
            this.lblDateOfBirthDoctor.Text = "dob";
            // 
            // lblDoctorGender
            // 
            this.lblDoctorGender.AutoSize = true;
            this.lblDoctorGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorGender.Location = new System.Drawing.Point(156, 162);
            this.lblDoctorGender.Name = "lblDoctorGender";
            this.lblDoctorGender.Size = new System.Drawing.Size(22, 18);
            this.lblDoctorGender.TabIndex = 20;
            this.lblDoctorGender.Text = "ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 18);
            this.label22.TabIndex = 20;
            this.label22.Text = "Specialization";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(12, 195);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 18);
            this.label27.TabIndex = 20;
            this.label27.Text = "Phone Number";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 162);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 18);
            this.label28.TabIndex = 20;
            this.label28.Text = "Gender";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 129);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 18);
            this.label29.TabIndex = 20;
            this.label29.Text = "Date of birth";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 18);
            this.label30.TabIndex = 20;
            this.label30.Text = "Name";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 61);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 18);
            this.label31.TabIndex = 20;
            this.label31.Text = "ID";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMode.Location = new System.Drawing.Point(634, 25);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(49, 20);
            this.lblMode.TabIndex = 21;
            this.lblMode.Text = "Mode";
            // 
            // chkEnablePayment
            // 
            this.chkEnablePayment.AutoSize = true;
            this.chkEnablePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEnablePayment.Location = new System.Drawing.Point(185, 395);
            this.chkEnablePayment.Name = "chkEnablePayment";
            this.chkEnablePayment.Size = new System.Drawing.Size(78, 24);
            this.chkEnablePayment.TabIndex = 22;
            this.chkEnablePayment.Text = "Enable";
            this.chkEnablePayment.UseVisualStyleBackColor = true;
            this.chkEnablePayment.CheckedChanged += new System.EventHandler(this.chkEnablePayment_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 800);
            this.Controls.Add(this.chkEnablePayment);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDoctorPhone);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.PaymentCard);
            this.Controls.Add(this.CardAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Appointment";
            this.Load += new System.EventHandler(this.frmAddEditAppointment_Load);
            this.CardAppointment.ResumeLayout(false);
            this.CardAppointment.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.pnlPatientData.ResumeLayout(false);
            this.pnlPatientData.PerformLayout();
            this.PaymentCard.ResumeLayout(false);
            this.PaymentCard.PerformLayout();
            this.txtDoctorPhone.ResumeLayout(false);
            this.txtDoctorPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoctorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards CardAppointment;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        public Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMaleFemale;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientPhone;
        private Bunifu.Framework.UI.BunifuCards PaymentCard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuCards txtDoctorPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lblDoctorPhoneNumber;
        private System.Windows.Forms.Label lblDateOfBirthDoctor;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPatient;
        private System.Windows.Forms.Label lblDoctorGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorSpecialization;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.Label label25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaymentAdditionalNotes;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmountPaid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaymentMethod;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox chkEnablePayment;
        private System.Windows.Forms.CheckBox chkPatientExists;
        private System.Windows.Forms.Panel pnlPatientData;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudDoctorID;
        private Bunifu.Framework.UI.BunifuFlatButton btnChoosePatient;
    }
}