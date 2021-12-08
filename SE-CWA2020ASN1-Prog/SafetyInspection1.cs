//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

// Class purpose:
// Collect inspection details and then add to intervention
// Creates markdown file and coverts it to PDF format
// Methods are displayed in the order as they appear on the form to help with class navigation

using System;
//using System.Data.SQLite;
using System.Windows.Forms;
using Aspose.Html;
using System.Diagnostics;

namespace SE_CWA2020ASN1_Prog
{
    public partial class SafetyInspection1 : Form
    {
        private Inspection insp;
        IMethods im = new Methods();

        public SafetyInspection1()
        {
            InitializeComponent();
            clearFields();
            addComboData();  
        }

        /// <summary>
        /// Select inspection site and select inspection type 
        /// </summary>
        private void addComboData()
        {
            cmb_EnterSite.Items.Add("Weetabix Burton AP1 / Main");
            cmb_EnterSite.Items.Add("Project Safety Audits");
            cmb_EnterSite.Items.Add("Tate and Lyle");
            cmb_EnterSite.Items.Add("Musk Design");
            cmb_EnterSite.Items.Add("AkzoNobel Stowmarket");
            cmb_EnterType.Items.Add("Installation");
            cmb_EnterType.Items.Add("General maintenance");
            cmb_EnterType.Items.Add("Building works");
            cmb_EnterType.Items.Add("Repairing");
        }

        /// <summary>
        /// Clears input fields
        /// </summary>
        public void clearFields()
        {
            cmb_EnterSite.Text = "";
            txt_inspectorName.Text = "";
            cmb_EnterType.Text = "";
            txt_jobDescription.Text = "";
            txt_supervisor.Text = "";
        }

        /// <summary>
        /// Getters and setters for safety inspection.
        /// </summary>
        public string m_siteName
        {
            get { return cmb_EnterSite.Text; }
            set { cmb_EnterSite.Text = value; }
        }
        public DateTime m_date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public string m_inspectorName
        {
            get { return txt_inspectorName.Text; }
            set { txt_inspectorName.Text = value; }
        }
        public string m_jobDesc
        {
            get { return txt_jobDescription.Text; }
            set { txt_jobDescription.Text = value; }
        } 
        public string m_jobType
        {
            get { return cmb_EnterType.Text; }
            set { cmb_EnterType.Text = value; }
        } 
        public string m_supervisor
        {
            get { return txt_supervisor.Text; }
            set { txt_supervisor.Text = value; }
        } 

                

        //###########################################################
        //                              buttons
        //
        //###########################################################

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// cretaes an object of type inspection_area and pass to safetyInspection2y
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Enter_Click(object sender, EventArgs e )
        {
            IMethods im = new Methods();
            if (im.isEmptyTextFieldForm1(m_siteName, m_inspectorName, m_jobType, m_jobDesc, m_supervisor) == false)
            {
                insp = new Inspection(m_siteName, m_date, m_inspectorName, m_jobType, m_jobDesc, m_supervisor);
                try
                {
                    Debug.WriteLine("Creating insp md file");
                    //create inspection.md file
                    im.createInspMDfile(insp);
                    Debug.WriteLine("insp md file created, \ndetails= "+insp.teststring());
                }catch(Exception ex)
                {
                    Debug.WriteLine("error creating inspMDfile: " + ex.Message);
                }
                //clear all input fields
                clearFields();
                InspectionSubmission2 frmIS2 = new InspectionSubmission2(insp);
                frmIS2.ShowDialog(); 
                this.Show();
            }      
        }
        /// <summary>
        /// Provides system information, including version and company name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutMusk amusk = new AboutMusk();
            amusk.ShowDialog(); 
        }

        /// <summary>
        /// Create markdown file and coverts it to PDF format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pdf_Click(object sender, EventArgs e)
        { 
            string filePath = Application.StartupPath + @"\inspection.md";
            try
            {
                // Convert Markdown to HTML document
                HTMLDocument document = Aspose.Html.Converters.Converter.ConvertMarkdown(filePath);
                // Invoke the ConvertHTML method to convert the HTML to PDF.
                Aspose.Html.Converters.Converter.ConvertHTML(document, new Aspose.Html.Saving.PdfSaveOptions(),@"Report.pdf");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {

        }
    }
}

