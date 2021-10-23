using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //1st form
        private void btn_goSafetyInspection_Click(object sender, EventArgs e)
        {
            SafetyInspection frmSafetyInspection = new SafetyInspection();
            this.Hide();
            frmSafetyInspection.ShowDialog();
            this.Show();
        }
        //2nd form
        private void btn_InspectionSubmission_Click(object sender, EventArgs e)
        {
            InspectionSubmission frmActComm = new InspectionSubmission();
            this.Hide();
            frmActComm.ShowDialog();
            this.Show();
        }
        //3rd form
        private void btn_actionComments_Click(object sender, EventArgs e)
        {
            ActionComments frmActComm = new ActionComments();
            this.Hide();
            frmActComm.ShowDialog();
            this.Show();
        }
    }
}
