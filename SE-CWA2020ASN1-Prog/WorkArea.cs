using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class WorkArea
    {
        private List<Intervention> intervention;
        public WorkArea(String workArea, String iSummary)
        {
            m_workarea = workArea;
            m_inspectionSummary = iSummary;
            intervention = new List<Intervention>();
        }

        /// <summary>
        /// add intervention obj to intervention list
        /// </summary>
        public void addInterv(Intervention intObj)
        {
            intervention.Add(intObj);
        }

        private String m_workarea;
        public String Work_Area { get { return m_workarea; } set { m_workarea = value; } }

        private String m_inspectionSummary;
        public String Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }

    }
}

