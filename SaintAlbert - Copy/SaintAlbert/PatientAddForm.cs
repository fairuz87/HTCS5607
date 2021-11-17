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
    public partial class PatientAddForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;

        public PatientAddForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void PatientAddForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
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

            if ((txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (txtLastName.Text == "") || (txtFirstName.Text == "") || (txtCity.Text == "") || (txtPhoneNumber.Text == "") || (txtInsuranceCode.Text == "") || (txtEmailAddress.Text == ""))
            {
                MessageBox.Show("Please fill in the fields correctly", "Error");
                return;
            }

            else
            {
                DataRow newPatientRow = DC.dtPatient.NewRow();
                newPatientRow["LastName"] = txtLastName.Text;
                newPatientRow["FirstName"] = txtFirstName.Text;
                newPatientRow["StreetAddress"] = txtStreetAddress.Text;
                newPatientRow["Suburb"] = txtSuburb.Text;
                newPatientRow["City"] = txtCity.Text;
                newPatientRow["PhoneNumber"] = txtPhoneNumber.Text;
                newPatientRow["InsuranceCode"] = txtInsuranceCode.Text;
                newPatientRow["EmailAddress"] = txtEmailAddress.Text;
                DC.dsSaintAlbert.Tables["Patient"].Rows.Add(newPatientRow);
                DC.UpdatePatient();
                CustomMsgBox.Show("Patient added successfully", "Add Patient", "OK");
                System.Threading.Thread.Sleep(800);
                DialogResult dialogResult = MessageBox.Show("Delete another patient?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtStreetAddress.Text = "";
                    txtSuburb.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtCity.Text = "";
                    txtPhoneNumber.Text = "";
                    txtInsuranceCode.Text = "";
                    txtEmailAddress.Text = "";
                }
                else if(dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                    txtStreetAddress.Text = "";
                    txtSuburb.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtCity.Text = "";
                    txtPhoneNumber.Text = "";
                    txtInsuranceCode.Text = "";
                    txtEmailAddress.Text = "";
                }

                txtStreetAddress.Text = "";
                txtSuburb.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtCity.Text = "";
                txtPhoneNumber.Text = "";
                txtInsuranceCode.Text = "";
                txtEmailAddress.Text = "";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtCity.Text = "";
            txtPhoneNumber.Text = "";
            txtInsuranceCode.Text = "";
            txtEmailAddress.Text = "";
        }
    }
}
