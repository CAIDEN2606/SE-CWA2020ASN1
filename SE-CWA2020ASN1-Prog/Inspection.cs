//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

// Class purpose:
// Collect inspection details and work areas detail
// Creates a list of inspection
// Testing the list in console
// Getting output to PDF
// Methods are displayed in the order as they appear on the form to help with class navigation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    public class Inspection
    {
        private List<WorkArea> m_workAreaList;
       
        public Inspection(string iName, DateTime date, string inspectorName, string jobType, string jobDescr,  string sName)
        {
            m_siteName = iName;
            m_inspectionDate = date;
            m_inspectorName = inspectorName;
            m_jobType = jobType;
            m_jobDescription = jobDescr;
            m_supervisorName = sName;
            m_workAreaList = new List<WorkArea>();
           
        }
        /// <summary>
        /// Adding a workarea object to the workarea list 
        /// </summary>
        /// <param name="waObj"></param>
        public void addWorkArea(WorkArea waObj)
        {
            
            m_workAreaList.Add(waObj);
        }

        
        private string m_siteName;
        public string Site_Name { get { return m_siteName; } set { m_siteName = value; } }

        private string m_jobType;
        public string Type { get { return m_jobType; } set { m_jobType = value; } }

        private string m_jobDescription;
        public string Job_Description { get { return m_jobDescription; } set { m_jobDescription = value; } }

        private string m_inspectorName;
        public string Inspector_Name { get { return m_inspectorName; } set { m_inspectorName = value; } }

        private DateTime m_inspectionDate;
        public DateTime Inspection_Date { get { return m_inspectionDate; } set { m_inspectionDate = value; } }

        private string m_supervisorName;
        public string Supervisor_Name { get { return m_supervisorName; } set { m_supervisorName = value; } }
    
        /// <summary>
        /// Used to test print to console to confirm contains data 
        /// </summary>
        /// <returns></returns>
        public string teststring()
        {
            return "Inspection --> Site: "+ m_siteName + ", date: " + m_inspectionDate + ", Inspected by: " + m_inspectorName;
        }

        /// <summary>
        /// Getting output for PDF file
        /// </summary>
        /// <returns></returns>
        public string pdfInspFormat()
        {
            return
            "Site name: " + m_siteName +
            "\nDate: " + m_inspectionDate +
            "\nInspector Name: " + m_inspectorName +
            "\nJob Type: " + m_jobType +
            "\nJob Description: " + m_jobDescription +
            "\nSupervisor's name: " + m_supervisorName;
        }    
    }
}

