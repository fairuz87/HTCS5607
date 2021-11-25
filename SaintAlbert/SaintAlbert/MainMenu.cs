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
    public partial class MainMenu : Form
    {
        private DataController DC;
        private PatientAddForm frmPatientAdd;
        private PatientUpdateForm frmPatientUpdate;
        private PatientDeleteForm frmPatientDelete;
        private PatientReportForm frmPatientReport;
        private PaymentRecordForm frmPaymentRecord;
        private ResearchTopicAddForm frmResearchTopicAdd;
        private ResearchTopicUpdateForm frmResearchTopicUpdate;
        private ResearchTopicDeleteForm frmResearchTopicDelete;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPatientsReport_Click(object sender, EventArgs e)
        {
            if (frmPatientReport == null)
            {
                frmPatientReport = new PatientReportForm(DC, this);
            }
            frmPatientReport.ShowDialog();
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            if (frmPaymentRecord == null)
            {
                frmPaymentRecord = new PaymentRecordForm(DC, this);
            }
            frmPaymentRecord.ShowDialog();

        }

        private void btnDeleteResearchTopic_Click(object sender, EventArgs e)
        {
            if (frmResearchTopicDelete == null)
            {
                frmResearchTopicDelete = new ResearchTopicDeleteForm(DC, this);
            }
            frmResearchTopicDelete.ShowDialog();

        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (frmPatientDelete == null)
            {
                frmPatientDelete = new PatientDeleteForm(DC, this);
            }
            frmPatientDelete.ShowDialog();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (frmPatientAdd == null)
            {
                frmPatientAdd = new PatientAddForm(DC, this);
            }
            frmPatientAdd.ShowDialog();
        }

        private void btnUpdateResearchTopic_Click(object sender, EventArgs e)
        {
            if (frmResearchTopicUpdate == null)
            {
                frmResearchTopicUpdate = new ResearchTopicUpdateForm(DC, this);
            }
            frmResearchTopicUpdate.ShowDialog();

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (frmPatientUpdate == null)
            {
                frmPatientUpdate = new PatientUpdateForm(DC, this);
            }
            frmPatientUpdate.ShowDialog();
        }

        private void btnAddResearchTopic_Click(object sender, EventArgs e)
        {
            if (frmResearchTopicAdd == null)
            {
                frmResearchTopicAdd = new ResearchTopicAddForm(DC, this);
            }
            frmResearchTopicAdd.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
