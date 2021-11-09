using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class Inspection
    {
        //used just to print inspections as requested by project requirements
        private List<Inspection> inspection;
        //private List<InspectionArea> m_inspectionArea;

        //public Inspection(String iName, String type, String jobDescr, DateTime date, String sName)
        //{
        //    m_siteName = iName;
        //    m_type = type;
        //    m_jobDescription = jobDescr;
        //    m_inspectionDate = date;
        //    m_supervisorName = sName;
        //    //m_inspectionArea = new List<InspectionArea>();
        //}
            //}
            /// <summary>
            /// Used to add each inspectionArea to inspection list
            /// then send to external db before starting new work area
            /// </summary>
            /// <param name="ia"></param>
        //public void addInspectionArea(InspectionArea ia)
        //{
        //    m_inspectionArea.Add(ia);
        //}
        

        private String m_siteName;
        public String Site_Name { get { return m_siteName; } set { m_siteName = value; } }

        private String m_type;
        public String Type { get { return m_type; } set { m_type = value; } }

        private String m_jobDescription;
        public String Job_Description { get { return m_jobDescription; } set { m_jobDescription = value; } }

        private String m_inspectorName;
        public String Inspector_Name { get { return m_inspectorName; } set { m_inspectorName = value; } }

        private DateTime m_inspectionDate;
        public DateTime Inspection_Date { get { return m_inspectionDate; } set { m_inspectionDate = value; } }

        private String m_supervisorName;
        public String Supervisor_Name { get { return m_supervisorName; } set { m_supervisorName = value; } }
    
        public void listInspections()
        {
            
        }
    }

}

