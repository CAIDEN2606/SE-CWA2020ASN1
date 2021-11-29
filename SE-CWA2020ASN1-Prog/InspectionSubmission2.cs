//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//


// Class purpose:
// Collect workarea and intervention details including call to cature image class
// Submit work area inspection at the end 
// Methods are displayed in the order as they appear on the form to help with class navigation
// 
//
using Aspose.Html;
using SE_CWA2020ASN1_Prog.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class InspectionSubmission2 : Form
    {
        private int numTotalInterv = 0;
        private WorkArea wa;
        private IMethods im = new Methods();
        string filePath = Application.StartupPath + @"\inspectImages\";
        private Intervention interv;
        private Inspection insp;

        public InspectionSubmission2(Inspection insp)
            
        {
            InitializeComponent();
            popInterventionCombo();
             
            //display total interventions
            rtx_displayTotalInterv.Text = numTotalInterv.ToString();
            //to test
            Debug.WriteLine(filePath);
            Debug.WriteLine("print insp teststring"+ insp.teststring());
        }

        public string m_subheadings {get { return cmb_Interventions.Text; }set { cmb_Interventions.Text = value; }}
        public string m_intervType {get { return cmb_TypesOfIntervention.Text; }set { cmb_TypesOfIntervention.Text = value; }}
        public string m_actionComments {get {return rtx_actionTaken.Text; }set { rtx_actionTaken.Text=value; }}
        public string m_inspectionComments {get { return rtb_InspectCommsSummary.Text; }set { rtb_InspectCommsSummary.Text = value; }}
        
        /// <summary>
        /// Add all intervention subheadings to a combo box for easier user selection
        /// </summary>
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

        /// <summary>
        /// Creates inspectImages folder in bin/debug if not exist to store images taken.
        /// Need to create folder on each new machine when app built. 
        /// Calls image capture form to capture a max of 3 images to include in an intervention
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_takePic_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath + @"\inspectImages\");
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Debug.WriteLine("Image folder created: " + filePath);
                }
                else
                {
                    Debug.WriteLine("Folder already exists");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occured: " + ex.Message);
            }
            ImageCapture imc = new ImageCapture();
            imc.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Delete an image captured displayed in a list box as img1,img2,img3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("delete started");
            try
            {
                //string filelst = "";
                string filelst = lst_pics.Items[lst_pics.SelectedIndex].ToString() + ".jpg";
                string file = filePath + filelst;
                im.deleteImg(file);
                               
                Debug.WriteLine(file + " deleted.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error trying to delete file: " + ex.Message);
            }
            Debug.WriteLine("delete finished");
        }

        /// <summary>
        /// Sets a max of 3 images that a user can take with defined names img1,img2,img3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_pics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image image = null;
            string imageName = "";
            //name each selection in lst_pics with .jpg image 
            if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img1")
            {
                imageName = "img1.jpg";
            }
            else if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img2")
            {
                imageName = "img2.jpg";
            }
            else if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img3")
            {
                imageName = "img3.jpg";
            }
            //set image to file path of selected item above
            try
            {
                using (var bmpTemp = new Bitmap(filePath + @imageName))
                {
                    image = new Bitmap(bmpTemp);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("File not found: " + ex.Message);
            }
            //display image selected in pic viewer if exists, if not display default logo
            if (image == null)
            {
                pic_intervPics.Image = Resources.musk_logo;
            }
            else
            {
                pic_intervPics.Image = image;
            }
              //if selected from list display to fill pic viewer
            pic_intervPics.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        /// <summary>
        /// Saves all input fields to make an intervention object and adds to work area list
        /// Adds a total for interventions and display at the top of the page
        /// Clears input fields on completion, ready to add another intervention
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveIntervention_Click(object sender, EventArgs e)
        {
            int intervID = numTotalInterv + 1;
            string intDesc = cmb_Interventions.Text;
            string intervType = cmb_TypesOfIntervention.Text;
            string actComms = rtx_actionTaken.Text;
            string inspectComms = rtx_comments.Text;
            string workArea = rtb_WorkArea.Text;
            string inspectCommsSummary = rtb_InspectCommsSummary.Text;
            Image img1 = null;
            Image img2 = null;
            Image img3 = null;
            int i = numTotalInterv + 1;
            string ID = i.ToString();

            //check if images exist else save as null to keep to class structure
            //rename images with intervID which makes unavailable in pic_viewer
            //so new pics can be taken.
            try
            {
                if (File.Exists(filePath + @"img1.jpg"))
                {
                    FileInfo fi = new FileInfo(filePath + @"img1.jpg");
                    fi.MoveTo(filePath + @ID + @"img1.jpg");
                    img1 = Image.FromFile(filePath + @ID + @"img1.jpg");
                }
                if (File.Exists(filePath + @"img2.jpg"))
                {
                    FileInfo fi = new FileInfo(filePath + @"img2.jpg");
                    fi.MoveTo(filePath + @ID + @"img2.jpg");
                    img2 = Image.FromFile(filePath + @ID + @"img2.jpg");
                }
                if (File.Exists(filePath + @"img3.jpg"))
                {
                    FileInfo fi = new FileInfo(filePath + @"img3.jpg");
                    fi.MoveTo(filePath + @ID + @"img3.jpg");
                    img3 = Image.FromFile(filePath + @ID + @"img3.jpg");
                }
            }catch(Exception ex)
            {
                Debug.WriteLine("error renaming files: " + ex.Message);
            }
            //check all necessary fields are completed, can only continue if filled.
            if (im.isEmptyTextFieldForm2(workArea, intDesc, intervType) == false)
            {
                try
                {
                   //create new intervention obj, 
                    interv = new Intervention(intervID, intDesc, intervType, actComms, inspectComms, img1, img2, img3);

                    //create new workarea 
                    wa = new WorkArea(workArea, inspectCommsSummary);
                    //call addinterv to add intervention to workarea
                    wa.addInterv(interv);

                    //add an interv to total interventions and display at the top of the page
                    numTotalInterv++;
                    rtx_displayTotalInterv.Text = numTotalInterv.ToString();

                    lst_interventions.Items.Add(im.displayInterventions(interv));

                    //functional tests to console 
                    Console.WriteLine(interv.testString()); //print subheading
                    Console.WriteLine(wa.testString()); //print workarea
                }
                catch (NullReferenceException ex)
                {
                    Debug.WriteLine(ex.Message + " The list is empty,please check all fields are filled.");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An unexpected error occured saving intervention: " + ex.Message);
                }

                //clear fields
                cmb_Interventions.Text = "";
                cmb_TypesOfIntervention.Text = "";
                rtx_actionTaken.Text = "";
                rtx_comments.Text = "";
                //im.deleteImages(); //access denied exception images need dispose?
                Debug.WriteLine(interv.testString());
            }
        }

        /// <summary>
        /// Submit a list of the completed work area inspection containing any interventions made by the inspector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //// add workarea to inspection
            string workArea = rtb_WorkArea.Text;
            string inspectCommsSummary = rtb_InspectCommsSummary.Text;
            //create new workarea 
            try
            {
                wa = new WorkArea(workArea, inspectCommsSummary);
                //functional test
                Debug.WriteLine(wa.testString());
                
                //insp.addWorkArea(wa);
               //Debug.WriteLine(insp.teststring());
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex.Message + " The list is empty,please check all fields are filled.");
            }
            this.Close();
        }
        /// <summary>
        /// Close and exit the form without saving any data, data only saved on submit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExitNoSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 /*
 //dont know why 2 deletes
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string fileImage = "";
                fileImage = lst_pics.SelectedItem.ToString() + ".jpg";
                File.Delete(Application.StartupPath + @fileImage.ToString());
                Console.WriteLine("deleted file I think");
            }
            catch(Exception ex)
            {
                Console.WriteLine("error trying to delete file: " + ex.Message);
            }
            Console.WriteLine("delete finished");
        }*/

    }
}




