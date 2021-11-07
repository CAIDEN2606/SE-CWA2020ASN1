using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class InspectionArea 
    {
        private String m_workarea;
        private String m_inspectionSummary;

        private List<Intervention> m_interventionObjs;

        public InspectionArea(String workArea, String iSummary)
        {
            m_workarea = workArea;
            m_inspectionSummary = iSummary;
            m_interventionObjs = new List<Intervention>();
        }
        /// <summary>
        /// multiple intervention objects added to single work area list
        /// </summary>
        public void addIntervention(Intervention i)
        {
            m_interventionObjs.Add(i);
        }
        public String Work_Area { get { return m_workarea; } set { m_workarea = value; } }


        public String Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }

    }

}
}
