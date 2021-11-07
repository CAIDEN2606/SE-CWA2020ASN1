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
            SafetyInspection1 frmSafetyInspection = new SafetyInspection1();
            this.Hide();
            frmSafetyInspection.ShowDialog();
            this.Show();
        }
        //2nd form
        private void btn_InspectionSubmission_Click(object sender, EventArgs e)
        {
            InspectionSubmission2 frmInSub = new InspectionSubmission2();
            this.Hide();
            frmInSub.ShowDialog();
            this.Show();
        }
        //3rd form
        private void btn_actionComments_Click(object sender, EventArgs e)
        {
            
            //ActionComments3 frmActComm = new ActionComments3();
            //this.Hide();
            //frmActComm.ShowDialog();
            //this.Show();
        }
    }
}
