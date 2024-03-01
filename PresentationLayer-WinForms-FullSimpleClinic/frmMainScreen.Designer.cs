namespace PresentationLayer_WinForms_FullSimpleClinic
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAppointments = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPatients = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDoctors = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSettings = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPayments = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOthers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.pnlSidePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(189, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(1324, 100);
            this.pnlTopPanel.TabIndex = 0;
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSidePanel.Controls.Add(this.panel4);
            this.pnlSidePanel.Controls.Add(this.flowLayoutPanel1);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(189, 753);
            this.pnlSidePanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 653);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 100);
            this.panel4.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAppointments);
            this.flowLayoutPanel1.Controls.Add(this.btnPatients);
            this.flowLayoutPanel1.Controls.Add(this.btnDoctors);
            this.flowLayoutPanel1.Controls.Add(this.btnSettings);
            this.flowLayoutPanel1.Controls.Add(this.btnPayments);
            this.flowLayoutPanel1.Controls.Add(this.btnOthers);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 155);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(187, 311);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAppointments
            // 
            this.btnAppointments.ActiveBorderThickness = 1;
            this.btnAppointments.ActiveCornerRadius = 20;
            this.btnAppointments.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnAppointments.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAppointments.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnAppointments.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppointments.BackgroundImage")));
            this.btnAppointments.ButtonText = "Appointments";
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAppointments.IdleBorderThickness = 1;
            this.btnAppointments.IdleCornerRadius = 20;
            this.btnAppointments.IdleFillColor = System.Drawing.Color.White;
            this.btnAppointments.IdleForecolor = System.Drawing.Color.Black;
            this.btnAppointments.IdleLineColor = System.Drawing.Color.Black;
            this.btnAppointments.Location = new System.Drawing.Point(4, 5);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(179, 39);
            this.btnAppointments.TabIndex = 3;
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.ActiveBorderThickness = 1;
            this.btnPatients.ActiveCornerRadius = 20;
            this.btnPatients.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnPatients.ActiveForecolor = System.Drawing.Color.Black;
            this.btnPatients.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnPatients.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPatients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatients.BackgroundImage")));
            this.btnPatients.ButtonText = "Patients";
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPatients.IdleBorderThickness = 1;
            this.btnPatients.IdleCornerRadius = 20;
            this.btnPatients.IdleFillColor = System.Drawing.Color.White;
            this.btnPatients.IdleForecolor = System.Drawing.Color.Black;
            this.btnPatients.IdleLineColor = System.Drawing.Color.Black;
            this.btnPatients.Location = new System.Drawing.Point(4, 54);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(179, 39);
            this.btnPatients.TabIndex = 3;
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.ActiveBorderThickness = 1;
            this.btnDoctors.ActiveCornerRadius = 20;
            this.btnDoctors.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnDoctors.ActiveForecolor = System.Drawing.Color.Black;
            this.btnDoctors.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnDoctors.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDoctors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctors.BackgroundImage")));
            this.btnDoctors.ButtonText = "Doctors";
            this.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDoctors.IdleBorderThickness = 1;
            this.btnDoctors.IdleCornerRadius = 20;
            this.btnDoctors.IdleFillColor = System.Drawing.Color.White;
            this.btnDoctors.IdleForecolor = System.Drawing.Color.Black;
            this.btnDoctors.IdleLineColor = System.Drawing.Color.Black;
            this.btnDoctors.Location = new System.Drawing.Point(4, 103);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(179, 39);
            this.btnDoctors.TabIndex = 3;
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveBorderThickness = 1;
            this.btnSettings.ActiveCornerRadius = 20;
            this.btnSettings.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnSettings.ActiveForecolor = System.Drawing.Color.Black;
            this.btnSettings.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.ButtonText = "Medical Records";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSettings.IdleBorderThickness = 1;
            this.btnSettings.IdleCornerRadius = 20;
            this.btnSettings.IdleFillColor = System.Drawing.Color.White;
            this.btnSettings.IdleForecolor = System.Drawing.Color.Black;
            this.btnSettings.IdleLineColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(4, 152);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(179, 39);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.ActiveBorderThickness = 1;
            this.btnPayments.ActiveCornerRadius = 20;
            this.btnPayments.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnPayments.ActiveForecolor = System.Drawing.Color.Black;
            this.btnPayments.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnPayments.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPayments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayments.BackgroundImage")));
            this.btnPayments.ButtonText = "Payments";
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPayments.IdleBorderThickness = 1;
            this.btnPayments.IdleCornerRadius = 20;
            this.btnPayments.IdleFillColor = System.Drawing.Color.White;
            this.btnPayments.IdleForecolor = System.Drawing.Color.Black;
            this.btnPayments.IdleLineColor = System.Drawing.Color.Black;
            this.btnPayments.Location = new System.Drawing.Point(4, 201);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(179, 39);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click_1);
            // 
            // btnOthers
            // 
            this.btnOthers.ActiveBorderThickness = 1;
            this.btnOthers.ActiveCornerRadius = 20;
            this.btnOthers.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnOthers.ActiveForecolor = System.Drawing.Color.Black;
            this.btnOthers.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnOthers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOthers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOthers.BackgroundImage")));
            this.btnOthers.ButtonText = "Others";
            this.btnOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOthers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOthers.IdleBorderThickness = 1;
            this.btnOthers.IdleCornerRadius = 20;
            this.btnOthers.IdleFillColor = System.Drawing.Color.White;
            this.btnOthers.IdleForecolor = System.Drawing.Color.Black;
            this.btnOthers.IdleLineColor = System.Drawing.Color.Black;
            this.btnOthers.Location = new System.Drawing.Point(4, 250);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(179, 39);
            this.btnOthers.TabIndex = 5;
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // pnlCont
            // 
            this.pnlCont.BackColor = System.Drawing.Color.White;
            this.pnlCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCont.Location = new System.Drawing.Point(189, 100);
            this.pnlCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(1324, 653);
            this.pnlCont.TabIndex = 0;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 753);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.pnlTopPanel);
            this.Controls.Add(this.pnlSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlSidePanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCont;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAppointments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPatients;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDoctors;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSettings;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPayments;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOthers;
        public System.Windows.Forms.Panel pnlTopPanel;
        public System.Windows.Forms.Panel pnlSidePanel;
    }
}

