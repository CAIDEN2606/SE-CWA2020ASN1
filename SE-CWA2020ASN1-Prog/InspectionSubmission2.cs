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
        private List<InspectionArea> getInspectionArea()
        {
            InspectionArea ia = new InspectionArea();
            ia.Work_Area = rtb_WorkArea.Text;
            ia.Inspection_Summary = rtb_InspectionComments.Text;

            inspArea.Add(ia);
            return inspArea;
        }


        private List<Intervention> getIntervention(List<Object> form3)
        {
            Intervention intv = new Intervention();
            
            intv.Intervention_Type = getType();
            intv.Heading_Name = getHeading();
            intv.Subheading_Name = getSubHead();
            intv.Inspection_Comments = (string)form3.ElementAt(0);
            intv.Action_Comments = (string)form3.ElementAt(1); 
            intv.Inspection_Picture = (Image)form3.ElementAt(2);
            interv.Add(intv);
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
