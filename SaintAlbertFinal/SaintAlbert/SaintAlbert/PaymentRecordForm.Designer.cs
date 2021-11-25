
namespace SaintAlbert
{
    partial class PaymentRecordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBilledAdmissions = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.cboPatient = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstBilledAdmissions = new System.Windows.Forms.ListView();
            this.colAdmissionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecordAnother = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Payment";
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.Location = new System.Drawing.Point(156, 220);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(96, 25);
            this.lblPatients.TabIndex = 1;
            this.lblPatients.Text = "Patients:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(141, 258);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(111, 25);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(131, 291);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(131, 326);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblBilledAdmissions
            // 
            this.lblBilledAdmissions.AutoSize = true;
            this.lblBilledAdmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilledAdmissions.Location = new System.Drawing.Point(66, 361);
            this.lblBilledAdmissions.Name = "lblBilledAdmissions";
            this.lblBilledAdmissions.Size = new System.Drawing.Size(187, 25);
            this.lblBilledAdmissions.TabIndex = 5;
            this.lblBilledAdmissions.Text = "Billed Admissions:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(163, 621);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.BackColor = System.Drawing.Color.White;
            this.btnRecordPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordPayment.Location = new System.Drawing.Point(59, 738);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(197, 61);
            this.btnRecordPayment.TabIndex = 7;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = false;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(363, 735);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 61);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(265, 256);
            this.txtPatientID.MaxLength = 8;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(100, 29);
            this.txtPatientID.TabIndex = 9;
            // 
            // cboPatient
            // 
            this.cboPatient.FormattingEnabled = true;
            this.cboPatient.Location = new System.Drawing.Point(265, 218);
            this.cboPatient.MaxLength = 40;
            this.cboPatient.Name = "cboPatient";
            this.cboPatient.Size = new System.Drawing.Size(533, 32);
            this.cboPatient.TabIndex = 10;
            this.cboPatient.SelectedIndexChanged += new System.EventHandler(this.cboPatient_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(265, 291);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(333, 29);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(265, 326);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(333, 29);
            this.txtFirstName.TabIndex = 12;
            // 
            // lstBilledAdmissions
            // 
            this.lstBilledAdmissions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstBilledAdmissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAdmissionID,
            this.colDescription});
            this.lstBilledAdmissions.FullRowSelect = true;
            this.lstBilledAdmissions.GridLines = true;
            this.lstBilledAdmissions.HideSelection = false;
            this.lstBilledAdmissions.Location = new System.Drawing.Point(265, 361);
            this.lstBilledAdmissions.MultiSelect = false;
            this.lstBilledAdmissions.Name = "lstBilledAdmissions";
            this.lstBilledAdmissions.Size = new System.Drawing.Size(496, 252);
            this.lstBilledAdmissions.TabIndex = 15;
            this.lstBilledAdmissions.UseCompatibleStateImageBehavior = false;
            this.lstBilledAdmissions.View = System.Windows.Forms.View.Details;
            this.lstBilledAdmissions.SelectedIndexChanged += new System.EventHandler(this.lstBilledAdmissions_SelectedIndexChanged);
            // 
            // colAdmissionID
            // 
            this.colAdmissionID.Text = "Admission ID";
            this.colAdmissionID.Width = 138;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 320;
            // 
            // nudAmount
            // 
            this.nudAmount.AllowDrop = true;
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAmount.Location = new System.Drawing.Point(294, 622);
            this.nudAmount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 29);
            this.nudAmount.TabIndex = 16;
            this.nudAmount.ThousandsSeparator = true;
            this.nudAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "$";
            // 
            // btnRecordAnother
            // 
            this.btnRecordAnother.BackColor = System.Drawing.Color.White;
            this.btnRecordAnother.Location = new System.Drawing.Point(650, 733);
            this.btnRecordAnother.Name = "btnRecordAnother";
            this.btnRecordAnother.Size = new System.Drawing.Size(264, 66);
            this.btnRecordAnother.TabIndex = 18;
            this.btnRecordAnother.Text = "Record Another Payment";
            this.btnRecordAnother.UseVisualStyleBackColor = false;
            this.btnRecordAnother.Click += new System.EventHandler(this.btnRecordAnother_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(112, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Required *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(251, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(246, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(246, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(309, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 83);
            this.panel1.TabIndex = 44;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SaintAlbert.Properties.Resources.Blue_and_Cyan_Modern_Icons_General_Hospital_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(255, -150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 351);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // PaymentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(984, 831);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRecordAnother);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lstBilledAdmissions);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cboPatient);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBilledAdmissions);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentRecordForm";
            this.Text = "Record Payments";
            this.Load += new System.EventHandler(this.PaymentRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBilledAdmissions;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.ComboBox cboPatient;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListView lstBilledAdmissions;
        private System.Windows.Forms.ColumnHeader colAdmissionID;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordAnother;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}