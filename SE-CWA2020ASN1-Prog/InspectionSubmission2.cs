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
    public partial class InspectionSubmission2 : Form
    {
        public InspectionSubmission2()
        {
            InitializeComponent();
        }

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_enterComments_Click(object sender, EventArgs e)
        {
            //save head&sub&type

            //go to 3rd form
            ActionComments3 frmActComm = new ActionComments3();
            this.Close();
            frmActComm.ShowDialog();
            this.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //save to all and add totals

            //return to form2
            InspectionSubmission2 frmInspSub = new InspectionSubmission2();
            this.Close();
            frmInspSub.ShowDialog();
            this.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
