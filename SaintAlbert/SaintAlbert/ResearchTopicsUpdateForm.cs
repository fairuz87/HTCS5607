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
    public partial class ResearchTopicUpdateForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmResearchTopic;
        private int researchTopicID;
        public ResearchTopicUpdateForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
            loadResearchTopics();

        }
        private void loadResearchTopics()
        {
            foreach (DataRow drResearchTopic in DC.dtResearchTopic.Rows)
            {
                ListViewItem item = new ListViewItem(drResearchTopic["ResearchTopicID"].ToString());
                item.SubItems.Add(drResearchTopic["ResearchTopicDescription"].ToString());
                lstResearchTopics.Items.Add(item);
            }
        }

            public void BindControls()
        {
            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsSaintAlbert, "ResearchTopic"];
        }

        private void lstResearchTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResearchTopics.SelectedItems.Count > 0)
            {
                ListViewItem item = lstResearchTopics.SelectedItems[0];
                txtResearchTopicID.Text = item.SubItems[0].Text;
                txtDescription.Text = item.SubItems[1].Text;
                string selectedItem = item.SubItems[0].Text;
                researchTopicID = Convert.ToInt32(selectedItem);
                cmResearchTopic.Position = DC.researchTopicView.Find(researchTopicID);
                DataRow drResearchTopic = DC.dtResearchTopic.Rows[cmResearchTopic.Position];
                nudLevel.Value = Convert.ToInt32(drResearchTopic["Level"]);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstResearchTopics.SelectedItems.Count > 0)
                for (int i = 0; i < lstResearchTopics.SelectedItems.Count; i++)
                {
                    lstResearchTopics.SelectedItems[i].Selected = false;
                }
            this.Hide();
            frmMenu.Show();
            txtResearchTopicID.Text = "";
            txtDescription.Text = "";
            nudLevel.Text = "";
        }

        private void btnUpdateResearchTopic_Click(object sender, EventArgs e)
        {
            DataRow updateResearchTopicRow = DC.dtResearchTopic.Rows[cmResearchTopic.Position];
            if (nudLevel.Value < 1 || nudLevel.Value > 10)
            {
                MessageBox.Show("The level must be between 1 to 10", "Error");
                return;
            }
            else if (nudLevel.Text == "" || txtDescription.Text == "" || lstResearchTopics.SelectedItems.Count < 0)
            {
                MessageBox.Show("Please fill in the fields correctly", "Error");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update the research topic?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    updateResearchTopicRow["ResearchTopicDescription"] = txtDescription.Text;
                    updateResearchTopicRow["Level"] = nudLevel.Value;
                    {
                        lstResearchTopics.SelectedItems[0].SubItems[1].Text = txtDescription.Text;
                    }
                    cmResearchTopic.EndCurrentEdit();
                    DC.UpdateResearchTopic();
                    CustomMsgBox.Show("Payment recorded successfully", "Record Payment", "OK");
                    txtResearchTopicID.Text = "";
                    txtDescription.Text = "";
                    nudLevel.Text = "";
                    System.Threading.Thread.Sleep(800);
                    DialogResult dialogAgain = MessageBox.Show("Update another research topic?", "Update", MessageBoxButtons.YesNo);
                    if (dialogAgain == DialogResult.Yes)
                    {
                        txtResearchTopicID.Text = "";
                        txtDescription.Text = "";
                        nudLevel.Text = "";
                    }
                    else if (dialogAgain == DialogResult.No)
                    {
                        this.Hide();
                        frmMenu.Show();
                        if (lstResearchTopics.SelectedItems.Count > 0)
                            for (int i = 0; i < lstResearchTopics.SelectedItems.Count; i++)
                            {
                                lstResearchTopics.SelectedItems[i].Selected = false;
                            }
                        txtResearchTopicID.Text = "";
                        txtDescription.Text = "";
                        nudLevel.Text = "";
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                    if (lstResearchTopics.SelectedItems.Count > 0)
                        for (int i = 0; i < lstResearchTopics.SelectedItems.Count; i++)
                        {
                            lstResearchTopics.SelectedItems[i].Selected = false;
                        }
                    txtResearchTopicID.Text = "";
                    txtDescription.Text = "";
                    nudLevel.Text = "";
                }
            }
        }
    }
}