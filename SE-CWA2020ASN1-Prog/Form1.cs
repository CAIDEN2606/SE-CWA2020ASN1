using System;

using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class Form1 : Form
    {
        private Inspection insp;

        public Form1()
        {
            InitializeComponent();
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
            
            InspectionSubmission2 frmInSub = new InspectionSubmission2(insp);
            this.Hide();
            frmInSub.ShowDialog();
            this.Show();
        }

        
    }
}
