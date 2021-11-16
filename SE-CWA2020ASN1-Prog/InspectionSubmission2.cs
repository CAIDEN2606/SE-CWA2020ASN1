﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class InspectionSubmission2 : Form
    {
        private int numTotalInterv = 0;
        private WorkArea wa;
        
        
        public InspectionSubmission2(Inspection insp)
        {
            InitializeComponent();
            popInterventionCombo();
            //display total interventions
            rtx_displayTotalInterv.Text = numTotalInterv.ToString();
            Console.WriteLine("print insp teststring"+ insp.teststring());
        }

        public string m_subheadings {get { return cmb_Interventions.Text; }set { cmb_Interventions.Text = value; }}
        public string m_intervType {get { return cmb_TypesOfIntervention.Text; }set { cmb_TypesOfIntervention.Text = value; }}
        public string m_actionComments {get {return rtx_actionTaken.Text; }set { rtx_actionTaken.Text=value; }}
        public string m_inspectionComments {get { return rtb_InspectCommsSummary.Text; }set { rtb_InspectCommsSummary.Text = value; }}
        public string m_picture {get { return lst_pics.Text; }set { lst_pics.Text = value; }}
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

        

        
        
        private void btn_saveIntervention_Click(object sender, EventArgs e)
        {
            //makes up an intervention
            //string intDesc ="";
            //string intervType="";
            //string actComms = "";
            //string inspectComms = "";

            string intDesc = cmb_Interventions.Text;
            string intervType = cmb_TypesOfIntervention.Text;
            string actComms = rtx_actionTaken.Text;
            string inspectComms = rtx_comments.Text;
            string pics=   lst_pics.Text;

            //string workArea = "";
            //string inspectCommsSummary = "";
            string workArea = rtb_WorkArea.Text;
            string inspectCommsSummary = rtb_InspectCommsSummary.Text;

            IMethods im = new Methods();
            if (im.isEmptyTextFieldForm2(workArea,intDesc, intervType) == false)
            {
                try
                {
                    //create new intervention obj, 
                    Intervention interv = new Intervention(intDesc, intervType, actComms, inspectComms, pics);

                    //create new workarea 
                    wa = new WorkArea(workArea, inspectCommsSummary);
                    //call addinterv to add intervention to workarea
                    wa.addInterv(interv);

                    //add an interv to total interventions 
                    numTotalInterv++;
                    rtx_displayTotalInterv.Text = numTotalInterv.ToString();

                    lst_interventions.Items.Add(im.displayInterventions(interv));

                    //functional tests
                    Console.WriteLine(interv.testString()); //print subheading
                    Console.WriteLine(wa.testString()); //print workarea
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message+" The list is empty,please check all fields are filled.");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occured: "+ex.Message);
                }
                
                //clear fields
                cmb_Interventions.Text="";
                cmb_TypesOfIntervention.Text = "";
                rtx_actionTaken.Text = "";
                rtx_comments.Text = "";
               
            }
            
        }

        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            // second redisign is okay!
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // second redesign is okay!
            //// add workarea to inspection
            //string workArea = "";
            //string inspectCommsSummary = "";
            string workArea = rtb_WorkArea.Text;
            string inspectCommsSummary = rtb_InspectCommsSummary.Text;
            //create new workarea 
            try
            {
                wa = new WorkArea(workArea, inspectCommsSummary);

                Console.WriteLine(wa.testString());
                //send
            } catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message + " The list is empty,please check all fields are filled.");
            }

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
