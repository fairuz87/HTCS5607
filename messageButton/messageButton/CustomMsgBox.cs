using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageButton
{
    public partial class CustomMsgBox : Form
    {
        static CustomMsgBox newMessageBox;
        static string buttinID;
        public CustomMsgBox()
        {
            InitializeComponent();
        }
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new CustomMsgBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return buttinID;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            buttinID = "1";
            newMessageBox.Dispose();
        }
    }
}
