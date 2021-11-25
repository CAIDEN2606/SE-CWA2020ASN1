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
        private List<Inspection> m_inspectionList;
        public Inspection(string iName, DateTime date, string inspectorName, string jobType, string jobDescr,  string sName)
        {
            m_siteName = iName;
            m_inspectionDate = date;
            m_inspectorName = inspectorName;
            m_jobType = jobType;
            m_jobDescription = jobDescr;
            m_supervisorName = sName;
            m_workAreaList = new List<WorkArea>();
            m_inspectionList = new List<Inspection>();
        }

        public void addWorkArea(WorkArea waObj)
        {
            m_workAreaList.Add(waObj);
        }
        public void addInsp(Inspection insp)
        {
            m_inspectionList.Add(insp);
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
    
        public string teststring()
        {
            return "Inspection --> Site: "+ m_siteName + ", date: " + m_inspectionDate + ", Inspected by: " + m_inspectorName;
        }
        public string pdfformat()
        {
            return
            "Site name: "+ m_siteName +
            "\nDate: " + m_inspectionDate +
            "\nInspector Name: " + m_inspectorName +
            "\nJob Type: " + m_jobType +
            "\nJob Description: " + m_jobDescription +
            "\nSupervisor's name: " + m_supervisorName;
            
        }




    }

}

