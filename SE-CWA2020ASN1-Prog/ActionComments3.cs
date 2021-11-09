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
        private List<object> form3 = new List<object>();
        
        public ActionComments3(String titleType)
        {
            InitializeComponent();
            
            //passing type from checkbox to form3 page heading
            lbl_sbheadingTitle.Text = titleType;

        }

        /// <summary>
        ///  pass the comments and pics to form2 to add to intervention list
        /// </summary>
        private List<object> passCommentsPics()
        {
            //store comments and pics as objects 
            form3.Add(rtx_comments.Text);
            form3.Add(rtx_actionTaken.Text);
            form3.Add(pic_viewer.Image);
            return form3;
        }

        //#################################################
        //                  Buttons                      ##
        //#################################################

        /// <summary>
        /// call passComments method and return to form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmInspection_Click(object sender, EventArgs e)
        {
            passCommentsPics();
            InspectionSubmission2 frmIS2 = new InspectionSubmission2(form3); // not new go back to previous
            this.Close();
            frmIS2.ShowDialog();
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
