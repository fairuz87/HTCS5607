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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (frmPatientReport == null)
            {
                frmPatientReport = new PatientReportForm(DC, this);
            }
            frmPatientReport.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
