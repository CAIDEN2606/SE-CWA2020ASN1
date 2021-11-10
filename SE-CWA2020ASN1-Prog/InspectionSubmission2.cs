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
        private List<Intervention> interv = new List<Intervention>();
        private List<InspectionArea> inspArea = new List<InspectionArea>();
        public List<Object> form3;
        SafetyInspection1 frmSI1 = new SafetyInspection1();

        public InspectionSubmission2(List<object>pform3)
        {
            InitializeComponent();
            form3 = pform3;
            //clear all fields when saved intervention to enter another
            //popSubheading();
        }

        //not needed all added to each combo properties
        private void popSubheading()
        {
            cmb_Interventions.Items.Add("2.Lifting operations-Crane,fork lift truck,Hoists");
            cmb_Interventions.Items.Add("3.Certification-Daily checksheets for MEWP and FLT");
            cmb_Interventions.Items.Add("5.Electrical work");

            cmb_Interventions.Items.Add("6.Site setup and appearance, Signage");
            cmb_Interventions.Items.Add("7.Paperwork (Permits, Risk assessments, Method Statement)");
            cmb_Interventions.Items.Add("8.Certification-Training,Insurance Inspection, Induction current");

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

            cmb_Interventions.Items.Add("1.Work at height");
            cmb_Interventions.Items.Add("4.Confined space work");
            cmb_Interventions.Items.Add("9.Hot work");
 
        }

        /// <summary>
        ///  
        /// </summary>
        private List<InspectionArea> getInspectionArea()
        {
            //InspectionArea ia = new InspectionArea();
            //ia.Work_Area = rtb_WorkArea.Text;
            //ia.Inspection_Summary = rtb_InspectionComments.Text;

            //inspArea.Add(ia);
            getInspectionAreaTest();
            return inspArea;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form3"></param>
        /// <returns></returns>
        private List<Intervention> getIntervention()
        {
            //Intervention intv = new Intervention();
            
            //intv.Intervention_Type = getType();
            //intv.Subheading_Name = getSubHead();

            //// Check stuff in form 3
            //intv.Inspection_Comments = (string)form3.ElementAt(0); //throws argumentnullexception
            //intv.Action_Comments = (string)form3.ElementAt(1); 
            //intv.Inspection_Picture = (Image)form3.ElementAt(2);
            //interv.Add(intv);
            //getInterventionTest();
            return interv;
        }
        /// <summary>
        /// Returns the subheading as string from combo boxes to add to intervention list
        /// </summary>
        private void getSubHead()
        {
            return;
        }


        /// <summary>
        /// Get type of intervention to pass as title in form3
        /// </summary>
        /// <returns></returns>
        private string getType()
        {
            String titleType = "";
            //if (chk_Best_Practice.Checked == true)
            //{
            //    titleType = "Best practice";
            //}
            //else if (chk_Intervention.Checked == true)
            //{
            //    titleType = "Positive intervention";
            //}
            //else if (chk_Subcontractor.Checked == true)
            //{
            //    titleType = "Subcontractor";
            //}
            //else
            //{
            //    MessageBox.Show("Please select an intervention type");
            //}
            return titleType;

        }



        //#######################################//
        //              test methods             //
        //                                       //
        //#######################################//

        /// <summary>
        /// print intervention list contents to console
        /// </summary>
        public void getInterventionTest()
        {
            foreach (Intervention i in interv)
            {
                Console.WriteLine("Intervention = " + i.Heading_Name.ToString() + "," + "Subheading = " + i.Subheading_Name.ToString());
            }
        }

        /// <summary>
        /// print inspectionArea objects to console
        /// </summary>
        public void getInspectionAreaTest()
        {
            foreach (InspectionArea ia in inspArea)
            {
                Console.WriteLine("Inspection area = " + ia.Work_Area.ToString());
            }
        }
        
        //
        //###############  test methods end   ###################

        //#######################################################
        //
        //                          Buttons
        //
        //#######################################################

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // second redesign is okay!
            getInspectionArea();
            //getIntervention();

            //save all data to sqlite

            //this.Hide();
            // frmSI1.ShowDialog();
            //this.Show();
            this.Close();

        }

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
inttervention.addComment(myObject);
}
else
{
this.txtResult.Text = "Cancelled";
}
testDialog.Dispose();
*/
    }
}
