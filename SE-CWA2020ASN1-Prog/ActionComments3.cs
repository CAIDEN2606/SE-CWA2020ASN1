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
    public partial class ActionComments3 : Form
    {
        //add the type selected in form2 and add ...
        public ActionComments3(String titleType)
        {
            InitializeComponent();
            
            //keep this and add the string passed in public Actioncomments(String....)
            lbl_sbheadingTitle.Text = titleType;

        }



        /// <summary>
        ///  pass the comments and pics to form2 to add to intervention list
        /// </summary>
        private void passComments()
        {
            //1st text box
            var iComments = rtx_comments.Text;
            //2nd text box
            var aComments = rtx_actionTaken.Text;
            //pics
            //??


        }

        /// <summary>
        /// call passComments method and return to form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmInspection_Click(object sender, EventArgs e)
        {
            passComments();
            InspectionSubmission2 frmInSub = new InspectionSubmission2();
            this.Hide();
            frmInSub.ShowDialog();
            this.Show();
        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exit page without saving data
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
