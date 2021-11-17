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
        private System.Windows.Forms.Timer tmr;
        static CustomMsgBox newMessageBox;
        static string buttinID;
        public CustomMsgBox()
        {
            InitializeComponent();
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(0.03).TotalMilliseconds;
            tmr.Start();
        }
        public static string Show(string txtMessage, string caption, string btnOkText)
        {
            newMessageBox = new CustomMsgBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.Text = caption;
            newMessageBox.btn.Text = btnOkText;
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
