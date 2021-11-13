using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class InspectionSubmission2 : Form
    {
       private int numTotalInterv = 0;
        
        public InspectionSubmission2(Inspection insp)
        {
            InitializeComponent();
            popInterventionCombo();
            //display total interventions
            rtx_displayTotalInterv.Text = numTotalInterv.ToString();

        }
        

        public string m_subheadings {get { return cmb_Interventions.Text; }set { cmb_Interventions.Text = value; }}
        public string m_intervType {get { return cmb_TypesOfIntervention.Text; }set { cmb_TypesOfIntervention.Text = value; }}
        public string m_actionComments {get {return rtx_actionTaken.Text; }set { rtx_actionTaken.Text=value; }}
        public string m_inspectionComments {get { return rtb_InspectCommsSummary.Text; }set { rtb_InspectCommsSummary.Text = value; }}
        public Image m_picture {get { return pic_viewer.Image; }set { pic_viewer.Image = value; }}
        private void popInterventionCombo()
        {
            cmb_Interventions.Items.Add("1.Work at height");
            cmb_Interventions.Items.Add("2.Lifting operations-Crane,fork lift truck,Hoists");
            cmb_Interventions.Items.Add("3.Certification-Daily checksheets for MEWP and FLT");
            cmb_Interventions.Items.Add("4.Confined space work");
            cmb_Interventions.Items.Add("5.Electrical work");
            
            cmb_Interventions.Items.Add("6.Site setup and appearance, Signage");
            cmb_Interventions.Items.Add("7.Paperwork (Permits, Risk assessments, Method Statement)");
            cmb_Interventions.Items.Add("8.Certification-Training,Insurance Inspection, Induction current");
            
            cmb_Interventions.Items.Add("9.Hot work");
            cmb_Interventions.Items.Add("10.Isolation and lock Offs");
            cmb_Interventions.Items.Add("11.Fire exits and escape routes");
            cmb_Interventions.Items.Add("12.Awareness-Fire exit, assembly point");

            cmb_Interventions.Items.Add("13.Waste management");
            cmb_Interventions.Items.Add("14.Product contamination");
            cmb_Interventions.Items.Add("15.COSHH & Asbestos");

            cmb_Interventions.Items.Add("16.PPE");
            cmb_Interventions.Items.Add("17.Manual handling");
            cmb_Interventions.Items.Add("18.Other contractors");

            cmb_Interventions.Items.Add("19.Power tools, Cables & other equipement");
            cmb_Interventions.Items.Add("20.Voltage detector checked");
            cmb_Interventions.Items.Add("21.Tools used fit for purpose");

            cmb_Interventions.Items.Add("22.Company vehicles");
            cmb_Interventions.Items.Add("23.Fire precautions");
            cmb_Interventions.Items.Add("24.Workshop conditions");

            
            
           
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
            
            //makes up an intervention
            string intDesc ="";
            string intervType="";
            string actComms = "";
            string inspectComms = "";

            //check if empty and makes red * visible to user as a must complete field if not
            lbl_error1.Visible = false;

            if (cmb_Interventions.SelectedIndex != -1)
            {
                intDesc = cmb_Interventions.Text;
            }
            else { lbl_error1.Visible = true; }
            if (cmb_TypesOfIntervention.SelectedIndex != -1)
            {
                intervType = cmb_TypesOfIntervention.Text;
            }
            else { lbl_error2.Visible = true; }
            actComms = rtx_actionTaken.Text;
            inspectComms = rtx_comments.Text; ;

            //Image pics=  pic_viewer.Image;
            
            //create new intervention obj, 
            Intervention interv = new Intervention(intDesc,intervType,actComms,inspectComms);

            string workArea = "";
            string inspectCommsSummary = "";
            // add workarea to inspection
            workArea = rtb_WorkArea.Text;
            inspectCommsSummary = rtb_InspectCommsSummary.Text;
            //create new workarea 
            WorkArea wa = new WorkArea(workArea, inspectCommsSummary);
            
            //add an interv to total interventions 
            numTotalInterv++;
            rtx_displayTotalInterv.Text = numTotalInterv.ToString();
            //call addinterv to add intervention to workarea
            wa.addInterv(interv);

            //functional tests
            Console.WriteLine(interv.testString()); //print subheading
            Console.WriteLine(wa.testString()); //print workarea
            //clear
            cmb_Interventions.Text = "";
            cmb_TypesOfIntervention.Text = "";
            rtx_actionTaken.Text="";
            rtx_comments.Text="";

        }

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // second redesign is okay!
            //add summary to workarea and add 'insp'
            
            
            
            //send

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
