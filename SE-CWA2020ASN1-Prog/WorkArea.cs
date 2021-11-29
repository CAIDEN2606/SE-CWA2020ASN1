using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    public class WorkArea
    {
        private List<Intervention> m_intervention;
        public WorkArea(string workArea, string iSummary)
        {
            m_workarea = workArea;
            m_inspectionSummary = iSummary;
            m_intervention = new List<Intervention>();
        }

        /// <summary>
        /// add intervention obj to intervention list
        /// </summary>
        public void addInterv(Intervention intObj)
        {
            m_intervention.Add(intObj);
        }
        
        private string m_workarea;
        public string Work_Area { get { return m_workarea; } set { m_workarea = value; } }

        private string m_inspectionSummary;
        public string Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }
        public string testString()
        {
            return "Work area --> work area= "+m_workarea + ",Inspection summary= "+ m_inspectionSummary;
        }

        internal string pdfformat()
        {
            throw new NotImplementedException();
        }
    }
}

