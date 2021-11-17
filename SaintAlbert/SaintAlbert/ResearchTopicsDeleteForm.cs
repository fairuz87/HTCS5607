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
    public partial class ResearchTopicDeleteForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmResearchTopic;
        private int researchTopicID;

        public ResearchTopicDeleteForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadResearchTopic();
            BindControls();
        }
        private void loadResearchTopic()
        {
            string researchTopicText = "";

            foreach (DataRow drResearchTopic in DC.dtResearchTopic.Rows)
            {
                DataRow[] drResearchProjects = drResearchTopic.GetChildRows(DC.dtResearchTopic.ChildRelations["RESEARCHTOPIC_RESEARCHPROJECT"]);
                if (drResearchProjects.Length == 0)
                {
                    researchTopicText = drResearchTopic["ResearchTopicID"] + ",";
                    researchTopicText += drResearchTopic["ResearchTopicDescription"];
                    cboResearchTopics.Items.Add(researchTopicText);
                }
            }
        }
        private void BindControls()
        {
            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsSaintAlbert, "ResearchTopic"];
        }
        private void cboResearchTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            String researchTopicText = cboResearchTopics.SelectedItem.ToString();

            string del = ",";
            string[] temp = researchTopicText.Split(del.ToCharArray());
            researchTopicID = Convert.ToInt32(temp[0]);
            txtResearchTopicID.Text = researchTopicID.ToString();
            txtDescription.Text = temp[1].ToString();
            cmResearchTopic.Position = DC.researchTopicView.Find(researchTopicID);
            DataRow drResearchTopic = DC.dtResearchTopic.Rows[cmResearchTopic.Position];
            txtLevel.Text = drResearchTopic["Level"].ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtResearchTopicID.Text = "";
            txtDescription.Text = "";
            txtLevel.Text = "";
            cboResearchTopics.Text = "";
            cboResearchTopics.Focus();
        }

        private void btnDeleteResearchTopic_Click(object sender, EventArgs e)
        {
            DataRow deleteResearchTopicRow = DC.dtResearchTopic.Rows[cmResearchTopic.Position];
            DataRow[] drResearchProjects = deleteResearchTopicRow.GetChildRows(DC.dtResearchTopic.ChildRelations["RESEARCHTOPIC_RESEARCHPROJECT"]);
            if (drResearchProjects.Length == 0)
            {
                while (cboResearchTopics.SelectedItem != null)
                {
                    cboResearchTopics.Items.Remove(cboResearchTopics.SelectedItem);
                }
                deleteResearchTopicRow.Delete();
                DC.UpdateResearchTopic();
                CustomMsgBox.Show("Research topic deleted successfully", "Delete Research Topic", "OK");
                System.Threading.Thread.Sleep(500);
                DialogResult dialogResult = MessageBox.Show("Delete another research topic?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtResearchTopicID.Text = "";
                    txtDescription.Text = "";
                    txtLevel.Text = "";
                    cboResearchTopics.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                    txtResearchTopicID.Text = "";
                    txtDescription.Text = "";
                    txtLevel.Text = "";
                    cboResearchTopics.Text = "";
                }
            }
        }

        private void ResearchTopicDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
