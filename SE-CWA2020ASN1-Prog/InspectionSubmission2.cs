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

        public InspectionSubmission2(List<object>form3)
        {
            InitializeComponent();
            //clear all fields when saved intervention to enter another
            testForm3(form3);
            //popSubheading();
        }

        //not needed all added to each combo properties
        private void popSubheading()
        {
            cmb_WorkingStandards.Items.Add("2.Lifting operations-Crane,fork lift truck,Hoists");
            cmb_WorkingStandards.Items.Add("3.Certification-Daily checksheets for MEWP and FLT");
            cmb_WorkingStandards.Items.Add("5.Electrical work");
           
            cmb_Quality.Items.Add("6.Site setup and appearance, Signage");
            cmb_Quality.Items.Add("7.Paperwork (Permits, Risk assessments, Method Statement)");
            cmb_Quality.Items.Add("8.Certification-Training,Insurance Inspection, Induction current");
                        
            cmb_Site_Rules.Items.Add("10.Isolation and lock Offs");
            cmb_Site_Rules.Items.Add("11.Fire exits and escape routes");
            cmb_Site_Rules.Items.Add("12.Awareness-Fire exit, assembly point");

            cmb_Environmental.Items.Add("13.Waste management");
            cmb_Environmental.Items.Add("14.Product contamination");
            cmb_Environmental.Items.Add("15.COSHH & Asbestos");
           
            cmb_Protection_Of_Individuals.Items.Add("16.PPE");
            cmb_Protection_Of_Individuals.Items.Add("17.Manual handling");
            cmb_Protection_Of_Individuals.Items.Add("18.Other contractors");
           
            cmb_Tools_Cables_And_Other.Items.Add("19.Power tools, Cables & other equipement");
            cmb_Tools_Cables_And_Other.Items.Add("20.Voltage detector checked");
            cmb_Tools_Cables_And_Other.Items.Add("21.Tools used fit for purpose");
           
            cmb_Miscellaneous.Items.Add("22.Company vehicles");
            cmb_Miscellaneous.Items.Add("23.Fire precautions");
            cmb_Miscellaneous.Items.Add("24.Workshop conditions");
            
            cmb_High_Risk.Items.Add("1.Work at height");
            cmb_High_Risk.Items.Add("4.Confined space work");
            cmb_High_Risk.Items.Add("9.Hot work");
 
        }

        /// <summary>
        ///  
        /// </summary>
        private List<InspectionArea> getInspectionArea()
        {
            InspectionArea ia = new InspectionArea();
            ia.Work_Area = rtb_WorkArea.Text;
            ia.Inspection_Summary = rtb_InspectionComments.Text;

            inspArea.Add(ia);
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
            Intervention intv = new Intervention();
            
            intv.Intervention_Type = getType();
            intv.Heading_Name = getHeading();
            intv.Subheading_Name = getSubHead();
            intv.Inspection_Comments = (string)form3.ElementAt(0); //throws argumentnullexception
            intv.Action_Comments = (string)form3.ElementAt(1); 
            intv.Inspection_Picture = (Image)form3.ElementAt(2);
            interv.Add(intv);
            getInterventionTest();
            return interv;
        }

        /// <summary>
        /// Returns the heading as string from combo boxes to add to intervention list
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        private string getHeading()
        {
            string heading = "";
            while (heading == "")
            {
                if (cmb_WorkingStandards.Text != "")
                {
                    heading = "Working Standards";
                }
                else if (cmb_Quality.Text != "")
                {
                    heading = "Quality";
                }
                else if (cmb_Site_Rules.Text != "")
                {
                    heading = "Site Rules";
                }
                else if (cmb_Environmental.Text != "")
                {
                    heading = "Environmental";
                }
                else if (cmb_Protection_Of_Individuals.Text != "")
                {
                    heading = "Protection Of Individuals";
                }
                else if (cmb_Tools_Cables_And_Other.Text != "")
                {
                    heading = "Tools, Cables And Other Equipment";
                }
                else if (cmb_Miscellaneous.Text != "")
                {
                    heading = "Miscellaneous";
                }
                else if (cmb_High_Risk.Text != "")
                {
                    heading = "High Risk";
                }
                else
                {
                    MessageBox.Show("Please enter a subheading");
                    break;
                }
            }
            return heading;
        }
        /// <summary>
        /// Returns the subheading as string from combo boxes to add to intervention list
        /// </summary>
        private string getSubHead()
        {
            int num = 0;
            string subheading = "";
            while (subheading == "")
            {
                if (cmb_WorkingStandards.Text != "" && num==0)
                {
                    subheading = cmb_WorkingStandards.Text;
                    num++;
                    
                }
                else if (cmb_Quality.Text != "" && num == 0)
                {
                    subheading = cmb_Quality.Text;
                    num++;
                    
                }
                else if (cmb_Site_Rules.Text != "" && num == 0)
                {
                    subheading = cmb_Site_Rules.Text;
                    num++;
                    

                }
                else if (cmb_Environmental.Text != "" && num == 0)
                {
                    subheading = cmb_Environmental.Text;
                    num++;
                    
                }
                else if (cmb_Protection_Of_Individuals.Text != "" && num == 0)
                {
                    subheading = cmb_Protection_Of_Individuals.Text;
                    num++;
                    
                }
                else if (cmb_Tools_Cables_And_Other.Text != "" && num == 0)
                {
                    subheading = cmb_Tools_Cables_And_Other.Text;
                    num++;
                    
                }
                else if (cmb_Miscellaneous.Text != "" && num == 0)
                {
                    subheading = cmb_Miscellaneous.Text;
                    num++;
                    

                }
                else if (cmb_High_Risk.Text != "" && num == 0)
                {
                    subheading = cmb_High_Risk.Text;
                    num++;
                    
                }
                else
                {
                    if (num > 0)
                    {
                        MessageBox.Show("Only one subheading can be chosen");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a subheading");
                        continue;
                    }
                }
            }
            return subheading;
        }


        /// <summary>
        /// Get type of intervention to pass as title in form3
        /// </summary>
        /// <returns></returns>
        private string getType()
        {
            String titleType = "";
            if (chk_Best_Practice.Checked == true)
            {
                titleType = "Best practice";
            }
            else if (chk_Intervention.Checked == true)
            {
                titleType = "Positive intervention";
            }
            else if (chk_Subcontractor.Checked == true)
            {
                titleType = "Subcontractor";
            }
            else
            {
                MessageBox.Show("Please select an intervention type");
            }
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
        /// <summary>
        /// print to console form3 comments and pics
        /// </summary>
        /// <param name="form3"></param>
        /// <returns></returns>
        public int testForm3(List<object> form3)
        {
            int num = 0;
            Console.WriteLine("Start form3 test");
            try
            {
                //test
                foreach (Object s in form3)
                    Console.WriteLine("item: " + s);
                num++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Form3 end test ok if return 1: " + num);
            return num;
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
            this.Close();
        }

             

        /// <summary>
        /// Go to form3 to get comments and pics and pass type to page title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_enterComments_Click(object sender, EventArgs e)
        {
            //pass type title to form3 heading
            String titleType = getType();
            if (titleType != "")
            {
                ActionComments3 frmAC3 = new ActionComments3(titleType);
                this.Hide();
                frmAC3.ShowDialog();
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //view list of interventions to select and change
        }
        
        /// <summary>
        /// Submit button to save all intervention data and add to inspectionArea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            getInspectionArea();
            //getIntervention();
            
            //save all data to sqlite
            
            this.Close();
            frmSI1.ShowDialog();
            this.Show();
        }
    }
}
