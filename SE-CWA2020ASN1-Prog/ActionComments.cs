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
    public partial class ActionComments : Form
    {
        public ActionComments()
        {
            InitializeComponent();
        }

        private void btn_confirmInspection_Click(object sender, EventArgs e)
        {

        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exit page without saving data warn user first to confirm action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_backSubHead_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("This will exit without saving. Are you sure?",
                "Exit no save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
