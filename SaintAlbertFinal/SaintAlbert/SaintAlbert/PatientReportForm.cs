using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintAlbert
{
    public partial class PatientReportForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;

        public PatientReportForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string patientText = "";
            txtPatients.Text = "";
            patientText += String.Format("{0,60}", "Patients Report" + "\r\n\r\n");

            foreach (DataRow drPatient in DC.dtPatient.Rows)
            {
                patientText += String.Format("{0,-13}{1,-1}{2,-1}{3,-1} ", "Patient Name: ", drPatient["LastName"], ", " ,drPatient["FirstName"]);
                patientText += String.Format(" {0,45}{1,1}{2,1}", "Patient ID: ", drPatient["PatientID"], "\r\n\r\n");
                patientText += String.Format("{0,15}{1,-1}{2,-1}{3,-1}{4,-1}{5,-1}", "Address: ", drPatient["StreetAddress"], ", " ,drPatient["Suburb"],", ", drPatient["City"]);
                patientText += String.Format("{0,30}{1,1}{2,1}", "Phone Number: ", drPatient["PhoneNumber"], "\r\n\r\n");
                patientText += String.Format("{0,21}{1,-1}", "Email Address: ", drPatient["EmailAddress"]); 
                patientText += String.Format("{0,39}{1,1}{2,1}", "Insurance Code: ", drPatient["InsuranceCode"], "\r\n\r\n");
                DataRow[] drAdmissions = drPatient.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
                foreach (DataRow drAdmission in drAdmissions)
                {
                    if (drAdmission["AdmissionStatus"].ToString() == "Completed" )
                    {
                        int numberOfCompletedAdmissions = 0;
                        numberOfCompletedAdmissions++;
                        patientText += "Completed Admissions: " + numberOfCompletedAdmissions.ToString() + "\r\n\r\n";
                        patientText += "Current Admissions: 0" + "\r\n\r\n\r\n\r\n";
                    }                
                    else if (drAdmission["AdmissionStatus"].ToString() == "Current")
                    {
                        int numberOfCurrentAdmissions = 0;
                        numberOfCurrentAdmissions++;
                        patientText += "Completed Admissions: 0" + "\r\n\r\n";
                        patientText += "Current Admissions: " + numberOfCurrentAdmissions.ToString() + "\r\n\r\n\r\n\r\n";
                    }
                    else
                    {
                        patientText += "This patient has no current or completed admission" + "\r\n\r\n\r\n\r\n";
                    }
                }
            }
            patientText += "\n\n\n\n";
            txtPatients.Text += patientText;
            patientText = "";
            txtPatients.SelectionStart = 41;
            txtPatients.SelectionLength = "Patients Report".Length - 0;
            txtPatients.SelectionFont = new Font("Courier New", 14, FontStyle.Underline);
            txtPatients.SelectionLength = 41;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
