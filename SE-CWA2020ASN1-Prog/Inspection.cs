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

        private String m_inspection;
        private List<InspectionArea> m_inspectionArea;
        public Inspection(String inspectionName)
        {
            m_inspection = inspectionName;
            m_inspectionArea = new List<InspectionArea>();

        }
        //used to add each inspectionArea to inspection list 
        public void addInspectionArea(InspectionArea insp)
        {
            m_inspectionArea.Add(insp);
        }
        private string m_siteName;
        public string Site_Name { get { return m_siteName; } set { m_siteName = value; } }

        private string m_type;
        public string Type { get { return m_type; } set { m_type = value; } }

        private string m_jobDescription;
        public string Job_Description { get { return m_jobDescription; } set { m_jobDescription = value; } }

        private string m_inspectorName;
        public string Inspector_Name { get { return m_inspectorName; } set { m_inspectorName = value; } }

        private DateTime m_inspectionDate;
        public DateTime Inspection_Date { get { return m_inspectionDate; } set { m_inspectionDate = value; } }

        private string m_supervisorName;
        public string Supervisor_Name { get { return m_supervisorName; } set { m_supervisorName = value; } }
    
    public void listInsections
    
    }

}

