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

        public InspectionSubmission2()
        {
            InitializeComponent();
            //clear all fields when saved intervention to enter another
        }
        
        private void getIntervention()
        {
            //List<Intervention> interv = new List<Intervention>();
            List<InspectionArea> inspArea = new List<InspectionArea>();
             //get work area [0]
            String workArea = rtb_WorkArea.Text;
            //get type [1]
            String type = getType();
            //get heading [2]
            
            //get subheading [3]
            //get insp comments (form3)[4]
            //get action comments (form3)[5]
            //get pics (form3)[6]
            //get summary[7]
            String summary = rtb_InspectionComments.Text;

            //add to intervention 
            interv.Insert(0, workArea);
            interv.Insert(1, type);
            interv.Insert(2, heading);
            interv.Insert(3, subheading);
            interv.Insert(4, iComments);
            interv.Insert(5, aComments);
            interv.Insert(6, pics);
            interv.Insert(7, summary);

            //add intervention obj to inspectionArea obj
            
            inspArea.Add(interv);

            //call method to send to sqlite

        }

        /// <summary>
        /// Get heading and subheading of interventions
        /// </summary>
        private void getHeadSubHead(String heading, String subheading)
        {
            
            
            if (cmb_WorkingStandards.Text != "")
            {
                subheading = cmb_WorkingStandards.Text;
                heading = "Working Standards";
            }
            else if (cmb_Quality.Text != "")
            {
                subheading = cmb_Quality.Text;
                heading = "Quality";
            }
            else if (cmb_Site_Rules.Text != "")
            {
                subheading = cmb_Site_Rules.Text;
                heading = "Site Rules";
            }
            else if (cmb_Environmental.Text != "")
            {
                subheading = cmb_Environmental.Text;
                heading = "Environmental";
            }
            else if (cmb_Protection_Of_Individuals.Text != "")
            {
                subheading = cmb_Protection_Of_Individuals.Text;
                heading = "Protection Of Individuals";
            }
            else if (cmb_Tools_Cables_And_Other.Text != "")
            {
                subheading = cmb_Tools_Cables_And_Other.Text;
                heading = "Tools, Cables And Other Equipment";
            }
            else if (cmb_Miscellaneous.Text != "")
            {
                subheading = cmb_Miscellaneous.Text;
                heading = "Miscellaneous";
            }
            else if (cmb_High_Risk.Text != "")
            {
                subheading = cmb_High_Risk.Text;
                heading = "High Risk";
             }
            else
            {
                MessageBox.Show("Please enter a subheading");
            }
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
        /// Go to form3 to get comments and pics
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
