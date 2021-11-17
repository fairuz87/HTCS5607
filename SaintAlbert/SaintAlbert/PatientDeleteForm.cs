using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using messageButton;

namespace SaintAlbert
{
    public partial class PatientDeleteForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmPatient;
        private int patientID;
        public PatientDeleteForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadPatient();
            BindControls();
        }
        private void loadPatient()
        {
            string patientText = "";

            foreach (DataRow drPatient in DC.dtPatient.Rows)
            {
                DataRow[] drAdmissions = drPatient.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
                if (drAdmissions.Length == 0)
                {
                    patientText = drPatient["PatientID"] + ", ";
                    patientText += drPatient["LastName"] + ", ";
                    patientText += drPatient["FirstName"];
                    cboPatients.Items.Add(patientText);
                }
            }
        }
        private void BindControls()
        {
            cmPatient = (CurrencyManager)this.BindingContext[DC.dsSaintAlbert, "Patient"];
        }


        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            {
                DataRow deletePatientRow = DC.dtPatient.Rows[cmPatient.Position];
                DataRow[] drAdmissions = deletePatientRow.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
                if (drAdmissions.Length == 0)
                {
                    while (cboPatients.SelectedItem != null)
                    {
                        cboPatients.Items.Remove(cboPatients.SelectedItem);
                    }
                    deletePatientRow.Delete();
                    DC.UpdatePatient();
                    CustomMsgBox.Show("Patient deleted successfully", "Delete Patient", "OK");
                    System.Threading.Thread.Sleep(800);
                    DialogResult dialogResult = MessageBox.Show("Delete another patient?", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txtPatientID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtStreetAddress.Text = "";
                        txtSuburb.Text = "";
                        txtCity.Text = "";
                        txtPhoneNumber.Text = "";
                        cboPatients.Text = "";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                        frmMenu.Show();
                        txtPatientID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtStreetAddress.Text = "";
                        txtSuburb.Text = "";
                        txtCity.Text = "";
                        txtPhoneNumber.Text = "";
                        cboPatients.Text = "";
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtPatientID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            cboPatients.Text = "";
        }

        private void cboPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            String patientText = cboPatients.SelectedItem.ToString();

            string del = ",";
            string[] temp = patientText.Split(del.ToCharArray());
            patientID = Convert.ToInt32(temp[0]);
            txtPatientID.Text = patientID.ToString();
            txtLastName.Text = temp[1].ToString();
            txtFirstName.Text = temp[2].ToString();
            cmPatient.Position = DC.patientView.Find(patientID);
            DataRow drPatient = DC.dtPatient.Rows[cmPatient.Position];
            txtStreetAddress.Text = drPatient["StreetAddress"].ToString();
            txtSuburb.Text = drPatient["Suburb"].ToString();
            txtCity.Text = drPatient["City"].ToString();
            txtPhoneNumber.Text = drPatient["PhoneNumber"].ToString();
        }
    }
}
