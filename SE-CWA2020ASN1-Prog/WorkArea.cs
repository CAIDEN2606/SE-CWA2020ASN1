//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//                                              //
//##############################################//

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
        /// <summary>
        /// Used to test if data is correct in wa list
        /// </summary>
        /// <returns></returns>
        public string testString()
        {
            return "Work area --> work area= "+m_workarea + ",Inspection summary= "+ m_inspectionSummary;
        }

        public string pdfWaFormat()
        {
            string ans ="\nwork area: "+m_workarea + "\nInspection summary = "+ m_inspectionSummary;


            return ans;
        }
    }
}

