using Aspose.Html;
//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class SafetyInspection1 : Form
    {
        private Inspection insp;
        {
            InitializeComponent();
            clearFields();
            addComboData();
            //clears input fields
            
        }
        
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
        public void clearFields()
        {
            cmb_EnterSite.Text = "";
            txt_inspectorName.Text = "";
            cmb_EnterType.Text = "";
            txt_jobDescription.Text = "";
            txt_supervisor.Text = "";
        }
        
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
        public string m_inspector
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
        
        private void btn_Enter_Click(object sender, EventArgs e )
        {
            //string siteName = "";
            //DateTime date;
            //string inspectorName = "";
            //string jobDesc = "";
            //string jobType = "";
            //string supervisor = "";

            string siteName = cmb_EnterSite.Text;
            DateTime date = dateTimePicker1.Value;
            string inspectorName = txt_inspectorName.Text;
            string jobType = cmb_EnterType.Text;
            string jobDesc = txt_jobDescription.Text;
            string supervisor = txt_supervisor.Text;
            IMethods im = new Methods();
            if (im.isEmptyTextFieldForm1(siteName, inspectorName, jobType, jobDesc, supervisor) == false)
            {
                //create object of type inspection_area and pass to safetyInspection2
                insp = new Inspection(siteName, date, inspectorName, jobType, jobDesc, supervisor);
                Inspection insp = new Inspection(siteName, date, inspectorName, jobType, jobDesc, supervisor);
                //clear all input fields
                clearFields();
                frmIS2.ShowDialog(); 
                this.Show();
            }
            
                
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutMusk amusk = new AboutMusk();
            amusk.ShowDialog();
            
        }

        private void btn_SaveToPdf_Click(object sender, EventArgs e)
        {
            //Prepare a simple Markdown example




            // Create a Markdown file
            try
            {

                System.IO.File.WriteAllText("document.md", insp.pdfformat());

                //MessageBox.Show(insp.teststring());

                // Convert Markdown to HTML document
                //Aspose.Html.Converters.Converter.ConvertMarkdown("document.md", "document.html");
                HTMLDocument document = Aspose.Html.Converters.Converter.ConvertMarkdown("document.md");

                // Invoke the ConvertHTML method to convert the HTML to PDF.
                Aspose.Html.Converters.Converter.ConvertHTML(document, new Aspose.Html.Saving.PdfSaveOptions(), "Report.pdf");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


        }
    }
}

