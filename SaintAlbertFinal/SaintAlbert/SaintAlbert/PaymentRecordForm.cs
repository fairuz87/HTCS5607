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
    public partial class PaymentRecordForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmPatient;
        private int ptID;
        private int admissionID;



        public PaymentRecordForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadPatients();
            BindControls();
        }

        private void BindControls()
        {
            cmPatient = (CurrencyManager)this.BindingContext[DC.dsSaintAlbert, "Patient"];
        }

        private void loadPatients()
        {
            string patientText = "";

            foreach (DataRow drPatient in DC.dtPatient.Rows)
            {
                DataRow[] drAdmissions = drPatient.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
                foreach (DataRow drAdmission in drAdmissions)
                    if (drAdmission["AdmissionStatus"].ToString() == "Billed")
                    {
                        patientText = drPatient["PatientID"] + ", ";
                        patientText += drPatient["LastName"] + ", ";
                        patientText += drPatient["FirstName"];
                        cboPatient.Items.Add(patientText);
                    }
            }
        }
        private void PaymentRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            lstBilledAdmissions.Items.Clear();
            txtPatientID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
        }

        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            String patientText = cboPatient.SelectedItem.ToString();

            string del = ",";
            string[] temp = patientText.Split(del.ToCharArray());

            ptID = Convert.ToInt32(temp[0]);
            txtPatientID.Text = ptID.ToString();
            txtLastName.Text = temp[1].ToString();
            txtFirstName.Text = temp[2].ToString();
            cmPatient.Position = DC.patientView.Find(ptID);
            DataRow drPatient = DC.dtPatient.Rows[cmPatient.Position];
            DataRow[] drAdmissions = drPatient.GetChildRows(DC.dtPatient.ChildRelations["PATIENT_ADMISSION"]);
            foreach (DataRow drAdmission in drAdmissions)
            {
                lstBilledAdmissions.Items.Clear();
                ListViewItem item = new ListViewItem(drAdmission["AdmissionID"].ToString());
                item.SubItems.Add(drAdmission["AdmissionDescription"].ToString());

                lstBilledAdmissions.Items.Add(item);
            }

        }

        private void lstBilledAdmissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = lstBilledAdmissions.Items[0].Text;
            admissionID = Convert.ToInt32(selectedItem);
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(nudAmount.Value);
            DataRow newPaymentRow = DC.dtPayment.NewRow();
            if (a < 10.0m || a > 10000.0m)
            {
                MessageBox.Show("The amount must be between $10.00 to $10,000", "Error");
                return;
            }
            else if (nudAmount.Text == "" || lstBilledAdmissions.SelectedItems.Count < 0)
            {
                MessageBox.Show("One or more input is either incorrect or missing", "Error");
                return;
            }
            else
            {
                DateTime now = DateTime.Now;
                newPaymentRow["AdmissionID"] = admissionID;
                newPaymentRow["PaymentAmount"] = nudAmount.Value;
                newPaymentRow["PaymentDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                DC.dtPayment.Rows.Add(newPaymentRow);
                DC.UpdatePayment();
                CustomMsgBox.Show("Payment recorded successfully", "Record Payment", "OK");
                int index = cboPatient.SelectedIndex;
                cboPatient.Items.RemoveAt(index);
                nudAmount.Text = "";
                lstBilledAdmissions.Items.Clear();
                txtPatientID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
            }
        }

        private void btnRecordAnother_Click(object sender, EventArgs e)
        {
            lstBilledAdmissions.Items.Clear();
            txtPatientID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cboPatient.Focus();
        }
    }
}