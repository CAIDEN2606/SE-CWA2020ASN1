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
    public partial class InspectionSubmission3 : Form
    {
        public InspectionSubmission3()
        {
            InitializeComponent();
        }

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            //save all data to sqlite

            //got to 3rd form
            ActionComments3 frmActComm = new ActionComments3();
            this.Hide();
            frmActComm.ShowDialog();
            this.Show();
        }

        private void btn_enterComments_Click(object sender, EventArgs e)
        {
            //go to form3 to get comments and pics
        }
    }
}
