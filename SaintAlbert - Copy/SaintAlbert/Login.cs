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
    public partial class Login : Form
    {
        private DataController DC;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataRow login = DC.dtLogin.TableName;
                if (txtPassword.Text == null || txtUsername.Text == null)
                {
                    MessageBox.Show("Either one is null", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtPassword.Text != login["Password"].ToString() && txtUsername.Text != drLogin["Username"].ToString())
                {
                    MessageBox.Show("Both are wrong username and password", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataRow drLogin in DC.dtLogin.Rows)
                    {
                        if (drLogin["User"].ToString() == "Assistant Administrator")
                        {
                            MessageBox.Show("Your login is successful", "Successful", MessageBoxButtons.OK);
                            MainMenu fm = new MainMenu();
                            this.Hide();
                            fm.btnAddResearchTopic.Hide();
                            fm.btnUpdateResearchTopic.Hide();
                            fm.btnDeleteResearchTopic.Hide();
                            fm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Your login is successful", "Successful", MessageBoxButtons.OK);
                            MainMenu fm = new MainMenu();
                            this.Hide();
                            fm.btnAddPatient.Hide();
                            fm.btnUpdatePatient.Hide();
                            fm.btnDeletePatient.Hide();
                            fm.btnPatientsReport.Hide();
                            fm.btnRecordPayment.Hide();
                            fm.Show();
                        }
                }
            }
        }
    }
}
