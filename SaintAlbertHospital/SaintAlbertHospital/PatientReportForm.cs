using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintAlbertHospital
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

        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }

        private void PatientReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string patientText = "";
            txtPatients.Text = "";

            foreach (DataRow drPatient in DC.dtPatient.Rows)
            {
                patientText += "Patient Name: " + drPatient["LastName"] + ", " + drPatient["FirstName"] + "Patient ID: ".PadRight(100) + drPatient["PatientID"] + "\n";
                patientText += (Indent(3) + "Address: " + drPatient["StreetAddress"] + ", " + drPatient["Suburb"] + ", " + drPatient["City"] + "Phone Number: ".PadRight(100) + drPatient["PhoneNumber"] + "\n");
                patientText += (Indent(3) + "Email Address: " + drPatient["EmailAddress"] + "Insurance Code: ".PadRight(100) + drPatient["InsuranceCode"] + "\n");
                DataRow[] drAdmissions = drPatient.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
                if (drAdmissions.Length == 0)
                {
                    patientText += "This patient has no admission history";
                }
                else
                {
                    foreach (DataRow drAdmission in drAdmissions)
                    {
                        int numberOfClosedAdmissions = dtAdmission.Select("Status = 'Y'").Length;
                    }
                }
        }
    }
}
