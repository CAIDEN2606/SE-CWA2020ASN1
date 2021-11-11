using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class InspectionSubmission2 : Form
    {
 

        
        public InspectionSubmission2(Inspection insp)
        {
            InitializeComponent();

            //m_subheadings = subheading;
            //m_intervType = intervType;
            //m_comments = comments;
            //m_actionComments = actionComments;
            //m_inspectionComments = inspectionComments;
            //m_picture = picture;


        }


        public string m_subheadings
        { 
            get { return cmb_Interventions.Text; }
            set { cmb_Interventions.Text = value; }
        }
        public string m_intervType
        {
            get { return cmb_TypesOfIntervention.Text; }
            set { cmb_TypesOfIntervention.Text = value; }
        }
        
        
        public string m_actionComments
        {
            get {return rtx_actionTaken.Text; }
            set { rtx_actionTaken.Text=value; }
        }
        public string m_inspectionComments
        {
            get { return rtb_InspectionComments.Text; }
            set { rtb_InspectionComments.Text = value; }
        }
        public Image m_picture
        {
            get { return pic_viewer.Image; }
            set { pic_viewer.Image = value; }
        }

        //#######################################################
        //
        //                          Buttons
        //
        //#######################################################


        private void btn_takePic_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
        }

        private void btn_saveIntervention_Click(object sender, EventArgs e)
        {

            string intDesc="";
            string intervType="";

            lbl_error1.Visible = false;

            if (cmb_Interventions.SelectedIndex != -1)
            {

                intDesc = cmb_Interventions.Text;
            }
            else
            {
                lbl_error1.Visible = true;

            }
            if (cmb_TypesOfIntervention.SelectedIndex != -1)
            {
                intervType = cmb_TypesOfIntervention.Text;
            }
                string actComms = rtx_actionTaken.Text;
                string inspectComms = rtb_InspectionComments.Text;
            
            //Image pics=  pic_viewer.Image;
            //repeat for rest
            //
            //create new intervention obj call addinterv
            Intervention interv = new Intervention(intDesc,intervType,actComms,inspectComms);
            
        }

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // second redesign is okay!

            this.Close();

        }

        /**********************************************
*
*
Form2 testDialog = new Form2();
// Create your comments object 
// Show testDialog as a modal dialog and determine if DialogResult = OK.
if (testDialog.ShowDialog(this, myObject) == DialogResult.OK)
{
// Read the contents of testDialog's TextBox.
this.txtResult.Text = testDialog.TextBox1.Text;
// Add comments to your intervention
intervention.addComment(myObject);
}
else
{
this.txtResult.Text = "Cancelled";
}
testDialog.Dispose();
*/
    }
}
