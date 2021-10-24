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
    public partial class InspectionSubmission : Form
    {
        public InspectionSubmission()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ActionComments frmActComm = new ActionComments();
            this.Hide();
            frmActComm.ShowDialog();
            this.Show();
        }
    }
}
