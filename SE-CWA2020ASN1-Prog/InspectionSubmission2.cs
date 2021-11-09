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

        public InspectionSubmission2(List<object>form3)
        {
            InitializeComponent();
            //clear all fields when saved intervention to enter another
            testForm3(form3);
        }

        /// <summary>
        ///  - get objects of interventions
        /// </summary>
        private void getInspectionArea()
        {



        }
        
                
        private void getIntervention(List<object> form3)
        {
            Intervention interv = new Intervention();
            InspectionArea ia = new InspectionArea();
             //get work area [0]
            ia.Work_Area = rtb_WorkArea.Text;
            //get type [1]
            interv.Intervention_Type = getType();
            //get heading [2]
            interv.Heading_Name = getHeading();
            //get subheading [3]
            interv.Subheading_Name = getSubHead();
            //get insp comments (form3)[4]
            //list form3 index 0
            //get action comments (form3)[5]
            //list form3 index 1
            //get pics (form3)[6]
            //list form3 index2
            foreach(Object o in form3)
            {
                interv.Action_Comments = form3.ToString();
                interv.Inspection_Comments= form3.ToString();
                //interv.Inspection_Picture= form3.Image;
            }
            //get summary[7]
            ia.Inspection_Summary = rtb_InspectionComments.Text;


            //add to intervention
            
            //interv.Insert(0, workArea);
            //interv.Insert(1, type);
            //interv.Insert(2, heading);
            //interv.Insert(3, subheading);
            //interv.Insert(4, iComments);
            //interv.Insert(5, aComments);
            //interv.Insert(6, pics);
            //interv.Insert(7, summary);

            //add intervention obj to inspectionArea obj
            
            //inspArea.Add(interv);

            //call method to send to sqlite

        }

        /// <summary>
        /// Returns the heading as string from combo boxes to add to intervention list
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        private string getHeading()
        {
            string heading = "";
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
            }
            return heading;
        }
        /// <summary>
        /// Returns the subheading as string from combo boxes to add to intervention list
        /// </summary>
        private string getSubHead()
        {
            string subheading = "";
            if (cmb_WorkingStandards.Text != "")
            {
                subheading = cmb_WorkingStandards.Text;
            }
            else if (cmb_Quality.Text != "")
            {
                subheading = cmb_Quality.Text;
            }
            else if (cmb_Site_Rules.Text != "")
            {
                subheading = cmb_Site_Rules.Text;
            }
            else if (cmb_Environmental.Text != "")
            {
                subheading = cmb_Environmental.Text;
            }
            else if (cmb_Protection_Of_Individuals.Text != "")
            {
                subheading = cmb_Protection_Of_Individuals.Text;
            }
            else if (cmb_Tools_Cables_And_Other.Text != "")
            {
                subheading = cmb_Tools_Cables_And_Other.Text;
            }
            else if (cmb_Miscellaneous.Text != "")
            {
                subheading = cmb_Miscellaneous.Text;
            }
            else if (cmb_High_Risk.Text != "")
            {
                subheading = cmb_High_Risk.Text;
            }
            else
            {
                MessageBox.Show("Please enter a subheading");
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
        ///  - print contents to console
        /// </summary>
        public void getInterventionTest()
        {

        }

        /// <summary>
        ///  - print objects to console, or rich text box or messagebox
        /// </summary>
        public void getInspectionAreaTest()
        {

        }
        /// <summary>
        /// print to console form3 comments and pics
        /// </summary>
        /// <param name="form3"></param>
        /// <returns></returns>
        public int testForm3(List<object> form3)
        {
            int num = 0;
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
            Console.WriteLine("test ok if return 1: " + num);
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
        /// Submit button to save all intervention data and add to inspectionArea 
        /// list as an object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_accept_Click(object sender, EventArgs e)
        {
            //save all data to sqlite

            //go to 3rd form
            SafetyInspection1 frmsafInsp = new SafetyInspection1();
            this.Hide();
            frmsafInsp.ShowDialog();
            this.Show();
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
    }
}
