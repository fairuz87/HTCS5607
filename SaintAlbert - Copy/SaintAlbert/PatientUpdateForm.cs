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
    public partial class PatientUpdateForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmPatient;
        private int patientID;
        public PatientUpdateForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadPatients();
            BindControls();
        }
        private void loadPatients()
        {
            foreach (DataRow drPatient in DC.dtPatient.Rows)
            {
                ListViewItem item = new ListViewItem(drPatient["PatientID"].ToString());
                item.SubItems.Add(drPatient["LastName"].ToString());
                item.SubItems.Add(drPatient["FirstName"].ToString());
                lstPatients.Items.Add(item);
            }
        }
        public void BindControls()
        {
            cmPatient = (CurrencyManager)this.BindingContext[DC.dsSaintAlbert, "Patient"];
        }


        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPatientID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtInsuranceCode.Text = "";
            if (lstPatients.SelectedItems.Count > 0)
            {
                ListViewItem item = lstPatients.SelectedItems[0];
                txtPatientID.Text = item.SubItems[0].Text;
                txtLastName.Text = item.SubItems[1].Text;
                txtFirstName.Text = item.SubItems[2].Text;
                string selectedItem = item.SubItems[0].Text;
                patientID = Convert.ToInt32(selectedItem);
                cmPatient.Position = DC.patientView.Find(patientID);
                DataRow drPatient = DC.dtPatient.Rows[cmPatient.Position];
                txtStreetAddress.Text = drPatient["StreetAddress"].ToString();
                txtSuburb.Text = drPatient["Suburb"].ToString();
                txtCity.Text = drPatient["City"].ToString();
                txtPhoneNumber.Text = drPatient["PhoneNumber"].ToString();
                txtInsuranceCode.Text = drPatient["InsuranceCode"].ToString();
                txtEmailAddress.Text = drPatient["EmailAddress"].ToString();

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            txtPatientID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtInsuranceCode.Text = "";
            this.Hide();
            frmMenu.Show();
            if (lstPatients.SelectedItems.Count > 0)
                for (int i = 0; i < lstPatients.SelectedItems.Count; i++)
                {
                    lstPatients.SelectedItems[i].Selected = false;
                }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            DataRow updatePatientRow = DC.dtPatient.Rows[cmPatient.Position];
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmailAddress.Text.Length > 0)

            {

                if (!rEMail.IsMatch(txtEmailAddress.Text))

                {

                    MessageBox.Show("Email address is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtEmailAddress.SelectAll();
                    return;

                }

            }
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtStreetAddress.Text == "" || txtSuburb.Text == "" || txtCity.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || txtInsuranceCode.Text == "" || lstPatients.SelectedItems.Count < 0)
            {
                MessageBox.Show("Please fill in the fields correctly", "Error");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update the patient?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    updatePatientRow["LastName"] = txtLastName.Text;
                    updatePatientRow["FirstName"] = txtFirstName.Text;
                    updatePatientRow["StreetAddress"] = txtStreetAddress.Text;
                    updatePatientRow["Suburb"] = txtSuburb.Text;
                    updatePatientRow["City"] = txtCity.Text;
                    updatePatientRow["EmailAddress"] = txtEmailAddress.Text;
                    updatePatientRow["PhoneNumber"] = txtPhoneNumber.Text;
                    updatePatientRow["InsuranceCode"] = txtInsuranceCode.Text;
                    {
                        lstPatients.SelectedItems[0].SubItems[1].Text = txtLastName.Text;
                        lstPatients.SelectedItems[0].SubItems[2].Text = txtFirstName.Text;
                    }
                    cmPatient.EndCurrentEdit();
                    DC.UpdatePatient();
                    CustomMsgBox.Show("Patient updated successfully", "Update Patient", "OK");
                    System.Threading.Thread.Sleep(800);
                    DialogResult dialogAgain = MessageBox.Show("Update another research topic?", "Update", MessageBoxButtons.YesNo);
                    if (dialogAgain == DialogResult.Yes)
                    {
                        txtPatientID.Text = "";
                        txtLastName.Text = "";
                        txtFirstName.Text = "";
                        txtStreetAddress.Text = "";
                        txtSuburb.Text = "";
                        txtCity.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmailAddress.Text = "";
                        txtInsuranceCode.Text = "";
                        if (lstPatients.SelectedItems.Count > 0)
                            for (int i = 0; i < lstPatients.SelectedItems.Count; i++)
                            {
                                lstPatients.SelectedItems[i].Selected = false;
                            }
                    }
                    else if (dialogAgain == DialogResult.No)
                    {
                        txtPatientID.Text = "";
                        txtLastName.Text = "";
                        txtFirstName.Text = "";
                        txtStreetAddress.Text = "";
                        txtSuburb.Text = "";
                        txtCity.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmailAddress.Text = "";
                        txtInsuranceCode.Text = "";
                        if (lstPatients.SelectedItems.Count > 0)
                            for (int i = 0; i < lstPatients.SelectedItems.Count; i++)
                            {
                                lstPatients.SelectedItems[i].Selected = false;
                            }
                        this.Hide();
                        frmMenu.Show();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    txtPatientID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtStreetAddress.Text = "";
                    txtSuburb.Text = "";
                    txtCity.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmailAddress.Text = "";
                    txtInsuranceCode.Text = "";
                    if (lstPatients.SelectedItems.Count > 0)
                        for (int i = 0; i < lstPatients.SelectedItems.Count; i++)
                        {
                            lstPatients.SelectedItems[i].Selected = false;
                        }
                    this.Hide();
                    frmMenu.Show();
                }
            }
        }
    }
}
