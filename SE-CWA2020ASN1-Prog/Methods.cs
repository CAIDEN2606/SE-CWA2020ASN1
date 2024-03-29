﻿//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//
//Functional purpose and responsiblies
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    interface IMethods
    {
        void createInspMDfile(Inspection insp);
        void appendWorkAreaPDF(WorkArea wa);
        void deleteImg(string file);
        void deleteImages();
        string displayInterventions(Intervention interv);
        Boolean isEmptyTextFieldForm1(string siteName, string inspectorName, string jobType, string jobDesc, string supervisor);
        Boolean isEmptyTextFieldForm2(string workArea,string intDesc, string intervType);
    }

    class Methods : IMethods
    {
        public void createInspMDfile(Inspection insp)
        {
            string path = Application.StartupPath + @"\inspection.md";
            if (File.Exists(path) == true)
            {
                File.Delete(path);
                File.WriteAllText(path, insp.pdfInspFormat());
                Debug.WriteLine("Inspection File found, deleted and new file created");
            }
            else
            {
                File.WriteAllText(path, insp.pdfInspFormat());
                Debug.WriteLine("No Inspection file found so new file created");
            }
        }

        public void appendWorkAreaPDF(WorkArea wa)
        {
            string path = Application.StartupPath + @"\inspection.md";
            if (File.Exists(path) == true)
            {
                File.AppendAllText(path, wa.pdfWaFormat());
            }
            else
            {
                File.WriteAllText(path, wa.pdfWaFormat());
                Debug.WriteLine("New pdf inspection file appended to with WA details.\nMissing insp details");
            }
        }
        /// <summary>
        /// Delete image file
        /// </summary>
        /// <param name="file"></param>
        public void deleteImg(string file)
        {
            FileInfo img1 = new FileInfo(file);
            img1.Delete();
        }
        /// <summary>
        /// call to clear folder when inspection submitted
        /// </summary>
        public void deleteImages()
        {
            try
            {
                FileInfo img1 = new FileInfo(Application.StartupPath + @"\inspectImages\img1.jpg");
                FileInfo img2 = new FileInfo(Application.StartupPath + @"\inspectImages\img2.jpg");
                FileInfo img3 = new FileInfo(Application.StartupPath + @"\inspectImages\img3.jpg");
                img1.Delete();
                img2.Delete();
                img3.Delete();
            }catch(Exception ex)
            {
                Debug.WriteLine("Cannot delete file: " + ex.ToString());
            }
        }

        ///// <summary>
        ///// Display list of inspections and some details in rich text box as required by project reqs.
        ///// </summary>
        public string displayInterventions(Intervention interv)
        {
            string shead = interv.Subheading_Name;
            return shead;
        }

        /// <summary>
        /// Check to see if compulsary fields in safetyInspection1 are empty, displays message if it is. 
        /// </summary>
        /// <param name="siteName"></param>
        /// <param name="inspectorName"></param>
        /// <param name="jobType"></param>
        /// <param name="jobDesc"></param>
        /// <param name="supervisor"></param>
        /// <returns></returns>
        public Boolean isEmptyTextFieldForm1(string siteName, string inspectorName, string jobType, string jobDesc, string supervisor)
        {
        Boolean ans = true;
            if (siteName == "")
            {
                MessageBox.Show("Please, enter the site name");
            }
            if (inspectorName == "")
            {
                MessageBox.Show("Please, enter your name");
            }
            if (jobType == "")
            {
                MessageBox.Show("Please, enter the job type");
            }
            if (jobDesc == "")
            {
                MessageBox.Show("Please, enter a job description");
            }
            if (supervisor == "")
            {
                MessageBox.Show("Please, enter the supervisor's name");
            }
            else
            {
                ans = false;
            }
            return ans;
        }

        /// <summary>
        /// Check to see if compulsary fields in inspectionSubmission2 are empty, displays message if it is. 
        /// Will not continue if empty
        /// </summary>
        /// <param name="workArea"></param>
        /// <param name="intDesc"></param>
        /// <param name="intervType"></param>
        /// <returns></returns>
        public Boolean isEmptyTextFieldForm2(string workArea,string intDesc,string intervType)
        {
            Boolean ans = true;

                if (workArea == "")
                {
                    MessageBox.Show("Please, enter the work area");
                }
                if (intDesc == "")
                {
                    MessageBox.Show("Please, select an intervention");
                }
                if (intervType == "")
                {
                    MessageBox.Show("Please, select an intervention type");
                }
                else
                {
                    ans = false;
                }
            return ans;
        }
    }
}
