using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SaintAlbert
{
    public partial class DataController : Form
    {
        public DataTable dtPatient;
        public DataTable dtMedication;
        public DataTable dtPayment;
        public DataTable dtWard;
        public DataTable dtAdmission;
        public DataTable dtDoctor;
        public DataTable dtPrescription;
        public DataTable dtAllocation;
        public DataTable dtResearchProject;
        public DataTable dtResearchTopic;
        public DataTable dtLogin;
        public DataView patientView;
        public DataView medicationView;
        public DataView paymentView;
        public DataView wardView;
        public DataView admissionView;
        public DataView doctorView;
        public DataView prescriptionView;
        public DataView allocationView;
        public DataView researchProjectView;
        public DataView researchTopicView;
        public DataView loginView;
        public DataController()
        {
            InitializeComponent();
            dsSaintAlbert.EnforceConstraints = false;
            daAdmission.Fill(dsSaintAlbert);
            daAllocation.Fill(dsSaintAlbert);
            daDoctor.Fill(dsSaintAlbert);
            daMedication.Fill(dsSaintAlbert);
            daPatient.Fill(dsSaintAlbert);
            daPayment.Fill(dsSaintAlbert);
            daPrescription.Fill(dsSaintAlbert);
            daResearchProject.Fill(dsSaintAlbert);
            daResearchTopic.Fill(dsSaintAlbert);
            daWard.Fill(dsSaintAlbert);
            daLogin.Fill(dsSaintAlbert);
            dtAdmission = dsSaintAlbert.Tables["Admission"];
            dtWard = dsSaintAlbert.Tables["Ward"];
            dtAllocation = dsSaintAlbert.Tables["Allocation"];
            dtDoctor = dsSaintAlbert.Tables["Doctor"];
            dtMedication = dsSaintAlbert.Tables["Medication"];
            dtPatient = dsSaintAlbert.Tables["Patient"];
            dtPayment = dsSaintAlbert.Tables["Payment"];
            dtPrescription = dsSaintAlbert.Tables["Prescription"];
            dtResearchProject = dsSaintAlbert.Tables["ResearchProject"];
            dtResearchTopic = dsSaintAlbert.Tables["ResearchTopic"];
            dtLogin = dsSaintAlbert.Tables["Login"];
            patientView = new DataView(dtPatient);
            patientView.Sort = "PatientID";
            medicationView = new DataView(dtMedication);
            medicationView.Sort = "MedicationID";
            paymentView = new DataView(dtPayment);
            paymentView.Sort = "PaymentCode";
            wardView = new DataView(dtWard);
            wardView.Sort = "WardID";
            doctorView = new DataView(dtDoctor);
            doctorView.Sort = "DoctorID";
            researchTopicView = new DataView(dtResearchTopic);
            researchTopicView.Sort = "ResearchTopicID";
            admissionView = new DataView(dtAdmission);
            admissionView.Sort = "AdmissionID";
            prescriptionView = new DataView(dtPrescription);
            prescriptionView.Sort = "AdmissionID,MedicationID";
            researchProjectView = new DataView(dtResearchProject);
            researchProjectView.Sort = "DoctorID,ResearchTopicID";
            allocationView = new DataView(dtAllocation);
            allocationView.Sort = "DoctorID,AdmissionID";
            loginView = new DataView(dtLogin);
            loginView.Sort = "LoginID";
            dsSaintAlbert.EnforceConstraints = true;
        }

        private void DataController_Load(object sender, EventArgs e)
        {

        }

        private void daPayment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnSaintAlbert);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["PaymentCode"] = newID;
            }
        }
        public void UpdatePayment()
        {
            daPayment.Update(dsSaintAlbert, "Payment");
        }
        public void UpdateResearchTopic()
        {
            daResearchTopic.Update(dsSaintAlbert, "ResearchTopic");
        }
        public void UpdatePatient()
        {
            daPatient.Update(dsSaintAlbert, "Patient");
        }

        private void daPatient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnSaintAlbert);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["PatientID"] = newID;
            }
        }
    }
}
