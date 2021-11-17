using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class InspectionArea
    {
        private string m_workarea;
        private string m_inspectionSummary;

        private List<Intervention> m_interventionObjs;

        //public InspectionArea(string workArea, string iSummary)
        //{
        //    m_workarea = workArea;
        //    m_inspectionSummary = iSummary;
        //    m_interventionObjs = new List<Intervention>();
        //}
        /// <summary>
        /// multiple intervention objects added to single work area list
        /// </summary>
        public void addIntervention(Intervention i)
        {
            m_interventionObjs.Add(i);
        }
        public string Work_Area { get { return m_workarea; } set { m_workarea = value; } }


        public string Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }

    }
}

