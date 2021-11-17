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
    public partial class ResearchTopicAddForm : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        public ResearchTopicAddForm(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnAddResearchTopic_Click(object sender, EventArgs e)
        {
            if ((txtDescription.Text == "") || (nudLevel.Text == ""))
            {
                MessageBox.Show("Please fill in the fields correctly", "Error");
                return;
            }

            else
            {
                DataRow newResearchTopicRow = DC.dtResearchTopic.NewRow();
                newResearchTopicRow["ResearchTopicDescription"] = txtDescription.Text;
                newResearchTopicRow["Level"] = nudLevel.Value;
                DC.dsSaintAlbert.Tables["ResearchTopic"].Rows.Add(newResearchTopicRow);
                DC.UpdateResearchTopic();
                CustomMsgBox.Show("Research topic added successfully", "Add Research Topic", "OK");
                System.Threading.Thread.Sleep(800);
                DialogResult dialogResult = MessageBox.Show("Add another research topic?", "Add", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtDescription.Text = "";
                    nudLevel.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                    txtDescription.Text = "";
                    nudLevel.Text = "";
                }
                txtDescription.Text = "";
                nudLevel.Text = "";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            txtDescription.Text = "";
            nudLevel.Text = "";
        }
    }
}
